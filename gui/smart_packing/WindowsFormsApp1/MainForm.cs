using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net.Http;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using Npgsql;
using WindowsFormsApp1.database;
using System.Timers;
using WindowsFormsApp1.model;
using Microsoft.Scripting.ComInterop;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.utils;
using ZXing;
using WindowsFormsApp1.form;
using System.Drawing.Text;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly HttpClient httpClient;
        FilterInfoCollection listWebcamInfo;

        private Dictionary<string, CameraData> camCaptureList = new Dictionary<string, CameraData>();

        List<Setting> settingsList;
        private List<Button> buttonControlList = new List<Button>();
        int filename = 111;
        private System.Timers.Timer debounceTimer;
        Setting entranceState1;
        Setting entranceState2;
        User authenticateUser = null;
        private string controlMode;
        public MainForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:3000/");
            camCaptureList.Add(Constant.ENTRANCE_1_CAM_IN, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxCamEntrance1In,
            });
            camCaptureList.Add(Constant.ENTRANCE_1_CAM_OUT, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxCamEntrance1Out
            });
            camCaptureList.Add(Constant.ENTRANCE_2_CAM_IN, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxCamEntrance2In
            });
            camCaptureList.Add(Constant.ENTRANCE_2_CAM_OUT, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxCamEntrance2Out
            });
            camCaptureList.Add(Constant.ENTRANCE_1_CAM_QR, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxEntrance1QRCode
            });
            camCaptureList.Add(Constant.ENTRANCE_2_CAM_QR, new CameraData
            {
                VideoCapture = null,
                PictureBox = pictureBoxEntrance2QRCode
            });
            buttonControlList.Add(buttonOpenEntrance1Barier1);
            buttonControlList.Add(buttonCloseEntrance1Barier1);
            buttonControlList.Add(buttonOpenEntrance1Barier2);
            buttonControlList.Add(buttonCloseEntrance1Barier2);
            buttonControlList.Add(buttonOpenEntrance2Barier1);
            buttonControlList.Add(buttonCloseEntrance2Barier1);
            buttonControlList.Add(buttonOpenEntrance2Barier2);
            buttonControlList.Add(buttonCloseEntrance2Barier2);
            controlMode = Constant.CONTROL_MODE_MANUAL;
            labelControlMode.Text = $"Control Mode: {controlMode}";
            UpdateControlItemMode();
        }

        private void UpdateControlItemMode()
        {
            foreach (var item in buttonControlList)
            {
                item.Enabled = controlMode == Constant.CONTROL_MODE_MANUAL;
            }
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // connectSerialPort();
            if (!PLC.IsRunning())
            {
                PLC.Connect();
            }
            try
            {
                if (!DB.IsRunning())
                {
                    DB.Connect();
                }
                settingsList = DB.GetAllSetting();
                if(settingsList != null)
                {
                    // Clean all Frame
                    foreach (var item in camCaptureList)
                    {
                        camCaptureList[item.Key].CleanFrame();
                    }

                    foreach (var item in camCaptureList)
                    {
                        Setting st = settingsList.FirstOrDefault(setting => setting.Name == item.Key);
                        if (st != null && st.Value != "" && st.Value != "-1")
                        {
                            int index = int.Parse(st.Value);
                            if(index < listWebcamInfo.Count)
                            {
                                VideoCaptureDevice vcd = new VideoCaptureDevice(listWebcamInfo[index].MonikerString);
                                camCaptureList[item.Key].StartFrame(vcd);
                            }
                        }
                    }
                    entranceState1 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_1);
                    if (entranceState1 != null)
                    {
                        labelEntranceState1.Text = $"State: {entranceState1.Value}";
                    }
                    entranceState2 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_2);
                    if (entranceState2 != null)
                    {
                        labelEntranceState2.Text = $"State: {entranceState2.Value}";
                    }
                    if(controlMode == null)
                    {
                        controlMode = Constant.CONTROL_MODE_MANUAL;
                    } else
                    {
                        if(authenticateUser != null && controlMode == Constant.CONTROL_MODE_AUTOMATION)
                        {
                            if(entranceState1.Value == Constant.CHECKIN_STATE)
                            {
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR2);
                                Thread.Sleep(1000);
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR1);
                                Thread.Sleep(1000);
                            } else if(entranceState1.Value == Constant.CHECKOUT_STATE)
                            {
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR1);
                                Thread.Sleep(1000);
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR2);
                                Thread.Sleep(1000);
                            }

                            if (entranceState2.Value == Constant.CHECKIN_STATE)
                            {
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR2);
                                Thread.Sleep(1000);
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR1);
                                Thread.Sleep(1000);
                            }
                            else if (entranceState2.Value == Constant.CHECKOUT_STATE)
                            {
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR1);
                                Thread.Sleep(1000);
                                PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR2);
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    labelControlMode.Text = $"Control Mode: {controlMode}";
                    UpdateControlItemMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when load form {ex}");
            }
        }

        private void CreateQRCodeToday()
        {
            List<User> usrs = DB.GetUserWithCondition("");
            foreach (var usr in usrs)
            {
                if(usr.Card != null)
                {
                    string data = $"{usr.Card}_{Helper.GetCurrentDay()}";
                    UserManageForm.ExportQRCode(data, false);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMainForm(sender, e);
            CreateQRCodeToday();
        }

        private async void buttonCaptureCheckin_Click(object sender, EventArgs e)
        {
            DetectResponse res = await CapturePlateAsync(Constant.ENTRANCE_1, Constant.CHECKIN_STATE);
            if (Helper.HasValue(res.Error))
            {
                MessageBox.Show($"Error when Checkin {res.Error}");
                return;
            }
            UpdateEntranceLabelInfor(Constant.ENTRANCE_1, "No Parking cardId", res, Constant.CHECKIN_STATE ,DateTime.Now, "Testing");
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR1);
            Helper.PlaySound(Constant.CHECKIN_STATE);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in camCaptureList)
            {
                if (item.Value.VideoCapture.IsRunning)
                {
                    item.Value.VideoCapture.Stop();
                }
            }
        }

        private void UpdateAuthenticateUser(User usr)
        {
            authenticateUser = usr;
        }
        private void UpdateControlMode(string mode)
        {
            controlMode = mode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (authenticateUser != null)
            {
                UserManageForm form = new UserManageForm(authenticateUser);
                form.Show();
            } else
            {
                AuthenicationForm authenicationForm = new AuthenicationForm("UserManageForm", controlMode);
                authenicationForm.UpdateAuthenticateUser += UpdateAuthenticateUser;
                authenicationForm.ShowDialog();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (authenticateUser != null)
            {
                ParkingManageForm form = new ParkingManageForm();
                form.Show();
            }
            else
            {
                AuthenicationForm authenicationForm = new AuthenicationForm("ParkingManageForm", controlMode);
                authenicationForm.UpdateAuthenticateUser += UpdateAuthenticateUser;
                authenicationForm.ShowDialog();
            }
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (authenticateUser != null)
            {
                SystemManageForm form = new SystemManageForm(controlMode);
                form.UpdateControlMode += UpdateControlMode;
                form.ReloadMainForm += LoadMainForm;
                form.Show();
            }
            else
            {
                AuthenicationForm authenicationForm = new AuthenicationForm("SystemManageForm", controlMode);
                authenicationForm.UpdateAuthenticateUser += UpdateAuthenticateUser;
                authenicationForm.UpdateControlMode += UpdateControlMode;
                authenicationForm.LoadMainForm += LoadMainForm;
                authenicationForm.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async Task<DetectResponse> ScanPlate(string filePath)
        {
            try
            {
                // Make a GET request to an API endpoint
                // string selectedPath = (listFile.SelectedItem as MediaFile).Path;
                HttpResponseMessage response = await httpClient.GetAsync($"detect?image={filePath}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DetectResponse responseObj = JsonConvert.DeserializeObject<DetectResponse>(apiResponse);
                    return responseObj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new DetectResponse
                {
                    Error = ex.Message
                };
            }
        }

        private string cardId = "";
        private bool isReadyReceiveCard = false;
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ';')
            {
                isReadyReceiveCard = true;
                debounceTimer = new System.Timers.Timer(200);
                debounceTimer.Elapsed += EndTimer;
                return;
            }
            if (isReadyReceiveCard)
            {
                cardId += e.KeyChar;
                debounceTimer.Stop();
                debounceTimer.Start();
            }
        }

        private void UpdateEntranceLabelInfor(string entrance, string parkingCardId, DetectResponse res, string state, DateTime occurance, string userName)
        {
            if (entrance == Constant.ENTRANCE_1)
            {
                labelEntrance1CardID.Text = $"Card ID: {parkingCardId}";
                labelEntrance1PlateNumber.Text = $"Plate Number: {res.PlateText}";
                labelEntrance1Type.Text = $"Type: {state}";
                labelEntrance1Occurence.Text = $"Occurance: {occurance}";
                labelEntrance1User.Text = $"User: {userName}";
                textBoxPlateEntrance1.Text = res.PlateText;
                if(state == Constant.CHECKIN_STATE)
                {
                    pictureBoxSelectedImageEntrance1Cam1.Image = Image.FromFile(res.PlateExtractPath);
                } else
                {
                    pictureBoxSelectedImageEntrance1Cam2.Image = Image.FromFile(res.PlateExtractPath);
                }
            } else
            {
                labelEntrance2CardID.Text = $"Card ID: {parkingCardId}";
                labelEntrance2PlateNumber.Text = $"Plate Number: {res.PlateText}";
                labelEntrance2Type.Text = $"Type: {state}";
                labelEntrance2Occurence.Text = $"Occurance: {occurance}";
                labelEntrance2User.Text = $"User: {userName}";
                textBoxPlateEntrance2.Text = res.PlateText;
                if (state == Constant.CHECKIN_STATE)
                {
                    pictureBoxSelectedImageEntrance2Cam1.Image = Image.FromFile(res.PlateExtractPath);
                }
                else
                {
                    pictureBoxSelectedImageEntrance2Cam2.Image = Image.FromFile(res.PlateExtractPath);
                }
            }
        }

        private async Task<DetectResponse> CapturePlateAsync(string entrance, string state)
        {
            // Generate a filename based on the current timestamp
            Int64 currentTime = DateTime.Now.Ticks;
            string frontFilePath = Path.Combine(Constant.CAPTURE_PATH, $"{currentTime}_front.jpg");
            string backFilePath = Path.Combine(Constant.CAPTURE_PATH, $"{currentTime}_back.jpg");
            Image captureFrontImage;
            Image captureBackImage;
            bool testing = true;
            Random random = new Random();
            // Generate a random number between 1 and 25 (inclusive)
            int endRand = 23; //26
            int randomNumber = random.Next(21, endRand);
            if (entrance == Constant.ENTRANCE_1)
            {
                if (state == Constant.CHECKIN_STATE)
                {
                    captureFrontImage = pictureBoxCamEntrance1Out.Image;
                    captureBackImage = testing ? Image.FromFile($"{Constant.TEST_PLATE_PATH}\\{randomNumber}.jpg"): pictureBoxCamEntrance1In.Image;
                }
                else
                {
                    captureFrontImage = pictureBoxCamEntrance1In.Image;
                    captureBackImage = testing ? Image.FromFile($"{Constant.TEST_PLATE_PATH}\\{randomNumber}.jpg") : pictureBoxCamEntrance1Out.Image;
                }
            }
            else
            {
                if (state == Constant.CHECKIN_STATE)
                {
                    captureFrontImage = pictureBoxCamEntrance2Out.Image;
                    captureBackImage = testing ? Image.FromFile($"{Constant.TEST_PLATE_PATH}\\{randomNumber}.jpg") : pictureBoxCamEntrance2In.Image;
                }
                else
                {
                    captureFrontImage = pictureBoxCamEntrance2In.Image;
                    captureBackImage = testing ? Image.FromFile($"{Constant.TEST_PLATE_PATH}\\{randomNumber}.jpg") : pictureBoxCamEntrance2Out.Image;
                }
            }
            if (captureFrontImage != null)
            {
                captureFrontImage.Save(frontFilePath, ImageFormat.Jpeg);
            }
            if (captureBackImage != null)
            {
                captureBackImage.Save(backFilePath, ImageFormat.Jpeg);
                DetectResponse res = await ScanPlate(backFilePath);
                return res;
            } 
            else
            {
                return new DetectResponse
                {
                    Error = "Didn't found capture plate image"
                };
            }
        }

        private async 
        Task
Checkin(string parkingCardId, string entrance)
        {
            // Get CardId data
            User usr = DB.GetUserByCardId(parkingCardId);
            if(usr == null)
            {
                MessageBox.Show("CardID invalid");
                return;
            }
            DetectResponse res = await CapturePlateAsync(entrance, Constant.CHECKIN_STATE);
            if(Helper.HasValue(res.Error)){
                MessageBox.Show($"Error when Checkin {res.Error}");
                return;
            }
            /*if (usr.Plate != res.PlateText)
            {
                MessageBox.Show("Invalid Plate");
                return;
            }*/
            // Open barier
            if(entrance == Constant.ENTRANCE_1)
            {
                if(entranceState1.Value == Constant.CHECKIN_STATE)
                {
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR1);
                    Thread.Sleep(1000);
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR2);
                    Thread.Sleep(1000);
                } else if(entranceState1.Value == Constant.CHECKOUT_STATE)
                {
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR1);
                    Thread.Sleep(1000);
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR2);
                    Thread.Sleep(1000);
                }
            } else if(entrance == Constant.ENTRANCE_2)
            {
                if (entranceState2.Value == Constant.CHECKIN_STATE)
                {
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR1);
                    Thread.Sleep(1000);
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR2);
                    Thread.Sleep(1000);
                }
                else if (entranceState2.Value == Constant.CHECKOUT_STATE)
                {
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR1);
                    Thread.Sleep(1000);
                    PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR2);
                    Thread.Sleep(1000);
                }
            }
            
            Helper.PlaySound(Constant.CHECKIN_STATE);
            

            // Trigger cardId Checkin {cardId}
            _ = Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    UpdateEntranceLabelInfor(entrance, parkingCardId, res, Constant.CHECKIN_STATE, DateTime.Now, usr.Name);
                }));
                Log l = new Log
                {
                    UserID = usr.ID,
                    Plate = res.PlateText,
                    Type = Constant.CHECKIN_STATE,
                    Occurrence = DateTime.Now,
                };
                DB.CreateLog(l);
            });
        }

        private async 
        Task
Checkout(string parkingCardId, string entrance)
        {
            User usr = DB.GetUserByCardId(parkingCardId);
            // Trigger cardId Checkout {tmpCardId}
            DetectResponse res = await CapturePlateAsync(entrance, Constant.CHECKOUT_STATE);
            
            // Get latest log of this user
            Log log = DB.GetLatestLog(parkingCardId);
            if (log.Type != "Checkin")
            {
                MessageBox.Show("This card didn't used for checkin before");
                return;
            }
            if(res.PlateText != log.Plate)
            {
                MessageBox.Show("This plate different with one when checkin");
                return;
            }
            Helper.PlaySound(Constant.CHECKOUT_STATE);
            // Trigger cardId Checkin {cardId}
            _ = Task.Run(() =>
            {
                UpdateEntranceLabelInfor(entrance, parkingCardId, res, Constant.CHECKOUT_STATE, DateTime.Now, usr.Name);
                Log l = new Log
                {
                    Plate = res.PlateText,
                    Type = Constant.CHECKOUT_STATE,
                    Occurrence = DateTime.Now,
                };
                DB.CreateLog(l);
            });
        }

        public void EndTimer(object sender, ElapsedEventArgs e)
        {
            debounceTimer.Stop();
            // Check last character
            if (cardId.Length == 9)
            {
                char lastChar = cardId[cardId.Length - 1];
                string parkingCardId = cardId.Remove(cardId.Length - 1);
                if (lastChar == Constant.LAST_CHAR_ENTRANCE_1)
                {
                    // Check current state of entrance
                    if (entranceState1.Value == Constant.CHECKIN_STATE)
                    {
                        _ = Checkin(parkingCardId, Constant.ENTRANCE_1);
                    }
                    else
                    {
                        _ = Checkout(parkingCardId, Constant.ENTRANCE_1);
                    }
                }
                if (lastChar == Constant.LAST_CHAR_ENTRANCE_2)
                {
                    // Check current state of entrance
                    if (entranceState2.Value == Constant.CHECKIN_STATE)
                    {
                        _ = Checkin(parkingCardId, Constant.ENTRANCE_2);
                    }
                    else
                    {
                        _ = Checkout(parkingCardId, Constant.ENTRANCE_2);
                    }
                }
            }
            cardId = "";
            isReadyReceiveCard = false;
        }

        private void buttonToggleCheckinBarier_Click_1(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR1);
        }

        private void buttonCloseCheckinBarier_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*int value = PLC.ReadFrom(int.Parse(textBoxAddress.Text));
            textBoxValue.Text = value.ToString();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // PLC.WriteTo(int.Parse(textBoxAddress.Text), Convert.ToInt16(textBoxValue.Text));
        }

        private void buttonOpenBarier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR1);
        }

        private void buttonCloseBarier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR1);
        }

        private void Entrance1Barier1Infor(Color c, string text)
        {
            statusIndicatorEntrance1Barier1.StatusColor = c;
            labelEntrance1Barier1State.Text = text;
        }

        private void Entrance1Barier2Infor(Color c, string text)
        {
            statusIndicatorEntrance1Barier2.StatusColor = c;
            labelEntrance1Barier2State.Text = text;
        }

        private void Entrance2Barier1Infor(Color c, string text)
        {
            statusIndicatorEntrance2Barier1.StatusColor = c;
            labelEntrance2Barier1State.Text = text;
        }

        private void Entrance2Barier2Infor(Color c, string text)
        {
            statusIndicatorEntrance2Barier2.StatusColor = c;
            labelEntrance2Barier2State.Text = text;
        }

        private void timerListenBarierState_Tick_1(object sender, EventArgs e)
        {
            int state = PLC.ReadFrom(Constant.PLC_READ_ENTRANCE_1_BR_REGISTER);
            if(state == Constant.PLC_READ_ENTRANCE_1_BR1C_BR2C)
            {
                Entrance1Barier1Infor(Color.Red, "Close");
                Entrance1Barier2Infor(Color.Red, "Close");
            }
            if (state == Constant.PLC_READ_ENTRANCE_1_BR1O_BR2O) {
                Entrance1Barier1Infor(Color.Green, "Open");
                Entrance1Barier2Infor(Color.Green, "Open");
            }
            if (state == Constant.PLC_READ_ENTRANCE_1_BR1O_BR2C)
            {
                Entrance1Barier1Infor(Color.Green, "Open");
                Entrance1Barier2Infor(Color.Red, "Close");
            }
            if (state == Constant.PLC_READ_ENTRANCE_1_BR1C_BR2O)
            {
                Entrance1Barier1Infor(Color.Red, "Close");
                Entrance1Barier2Infor(Color.Green, "Open");
            }

            int state_2 = PLC.ReadFrom(Constant.PLC_READ_ENTRANCE_2_BR_REGISTER);
            if (state_2 == Constant.PLC_READ_ENTRANCE_2_BR1C_BR2C)
            {
                Entrance2Barier1Infor(Color.Red, "Close");
                Entrance2Barier2Infor(Color.Red, "Close");
            }
            if (state_2 == Constant.PLC_READ_ENTRANCE_2_BR1O_BR2O)
            {
                Entrance2Barier1Infor(Color.Green, "Open");
                Entrance2Barier2Infor(Color.Green, "Open");
            }
            if (state_2 == Constant.PLC_READ_ENTRANCE_2_BR1O_BR2C)
            {
                Entrance2Barier1Infor(Color.Green, "Open");
                Entrance2Barier2Infor(Color.Red, "Close");
            }
            if (state_2 == Constant.PLC_READ_ENTRANCE_2_BR1C_BR2O)
            {
                Entrance2Barier1Infor(Color.Red, "Close");
                Entrance2Barier2Infor(Color.Green, "Open");
            }
        }

        private void timerInforDatetime_Tick(object sender, EventArgs e)
        {
            labelInforDatetime.Text = $"Datetime: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR2);
        }

        private void buttonOpenEntrance2Barier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_OPEN_BR2);
        }

        private void buttonCloseEntrance2Barier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_2_CLOSE_BR2);
        }

        private async void timerEntrancd1QRCode_Tick(object sender, EventArgs e)
        {
            try
            {
                // Load the image
                Bitmap bitmap = (Bitmap)pictureBoxEntrance1QRCode.Image;

                // Create a BarcodeReader instance
                BarcodeReader barcodeReader = new BarcodeReader();

                // Decode the QR code
                var result = barcodeReader.Decode(bitmap);

                // Check if a QR code was found
                if (result != null)
                {
                    timerEntrancd1QRCode.Enabled = false;
                    string data = Hash.DecryptData(result.Text);
                    if(data == "")
                    {
                        MessageBox.Show("Error when checkin");
                        return;
                    }
                    string[] parts = data.Split('_');
                    string plate = parts[0];
                    string day = parts[1];
                    if(day != Helper.GetCurrentDay())
                    {
                        MessageBox.Show("QR Code Expired");
                        return;
                    }
                    Helper.PlaySound(Constant.RECOGNIZE_QR_STATE);
                    // Check current state of entrance
                    if (entranceState1.Value == Constant.CHECKIN_STATE)
                    {
                        await Checkin(plate, Constant.ENTRANCE_1);
                    }
                    else
                    {
                        await Checkout(plate, Constant.ENTRANCE_1);
                    }
                    timerEntrancd1QRCode.Enabled = true;
                }
                else
                {
                    Console.WriteLine("-------- No QR code found in the image. ----------");
                }
            }
            catch (Exception ex)
            {
                timerEntrancd1QRCode.Enabled = true;
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private async void timerEntrancd2QRCode_Tick(object sender, EventArgs e)
        {
            try
            {
                // Load the image
                Bitmap bitmap = (Bitmap)pictureBoxEntrance2QRCode.Image;

                // Create a BarcodeReader instance
                BarcodeReader barcodeReader = new BarcodeReader
                {
                    Options =
                    {
                        TryHarder = true,
                        TryInverted = true,
                    },
                    AutoRotate = true,
                };

                // Decode the QR code
                var result = barcodeReader.Decode(bitmap);

                // Check if a QR code was found
                if (result != null)
                {
                    timerEntrancd2QRCode.Enabled = false;
                    string data = Hash.DecryptData(result.Text);
                    if (data == "")
                    {
                        MessageBox.Show("Error when checkin");
                        return;
                    }
                    string[] parts = data.Split('_');
                    string plate = parts[0];
                    string day = parts[1];
                    if (day != Helper.GetCurrentDay())
                    {
                        MessageBox.Show("QR Code Expired");
                        return;
                    }
                    Helper.PlaySound(Constant.RECOGNIZE_QR_STATE);
                    // Check current state of entrance
                    if (entranceState2.Value == Constant.CHECKIN_STATE)
                    {
                        await Checkin(plate, Constant.ENTRANCE_2);
                    }
                    else
                    {
                        await Checkout(plate, Constant.ENTRANCE_2);
                    }
                    timerEntrancd2QRCode.Enabled = true;
                }
                else
                {
                    Console.WriteLine("No QR code found in the image.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                timerEntrancd2QRCode.Enabled = true;
            }
        }

        private  void timerEntrance1CheckBike_Tick(object sender, EventArgs e)
        {
            int sensor_data = PLC.ReadFrom(Constant.PLC_READ_ENTRANCE_1_SENSOR_REGISTER);
            Console.WriteLine($"Read from PLC_READ_ENTRANCE_1_SENSOR_REGISTER {sensor_data}");
            if(sensor_data == 0)
            {
                int br_data = PLC.ReadFrom(Constant.PLC_READ_ENTRANCE_1_BR_REGISTER);
                if (entranceState1 == null) return;
                if (entranceState1.Value == Constant.CHECKIN_STATE)
                {
                    if (br_data == Constant.PLC_READ_ENTRANCE_1_BR1O_BR2C)
                    {
                        PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR1);
                        Thread.Sleep(1000);
                        PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR2);
                        Thread.Sleep(1000);
                    }
                } else
                {
                    if (br_data == Constant.PLC_READ_ENTRANCE_1_BR1C_BR2O)
                    {
                        PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_CLOSE_BR2);
                        Thread.Sleep(1000);
                        PLC.WriteTo(Constant.PLC_WRITE_ENTRANCE_1_OPEN_BR1);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void UpdateStatisticInformation()
        {
            int checkinCount = DB.GetTotalCheckToday(Constant.CHECKIN_STATE);
            int checkoutCount = DB.GetTotalCheckToday(Constant.CHECKOUT_STATE);
            Log latestCheckin = DB.GetLatestCheck(Constant.CHECKIN_STATE);
            Log latestCheckout = DB.GetLatestCheck(Constant.CHECKOUT_STATE);
            int availableSlot = DB.GetAvaiableSlot();
            string time = latestCheckin != null && latestCheckin.Occurrence != null ? latestCheckin.Occurrence.ToString("dd/MM/yyyy HH:mm:ss"): "Not Found";
            labelLastCheckin.Text = $"Latest Checkin: {time}";
            time = latestCheckout != null && latestCheckout.Occurrence != null ? latestCheckout.Occurrence.ToString("dd/MM/yyyy HH:mm:ss") : "Not Found";
            labelLastCheckout.Text = $"Latest Checkout: {time}";
            labelSlotAvailable.Text = $"Slot Avaiable: {availableSlot}";
            labelNumberCheckin.Text = $"Number Checkin Today: {checkinCount}";
            labelNumberCheckout.Text = $"Number Checkout Today: {checkoutCount}";
        }

        private void timerUpdateParkingInformation_Tick(object sender, EventArgs e)
        {
            UpdateStatisticInformation();
        }
    }
}
