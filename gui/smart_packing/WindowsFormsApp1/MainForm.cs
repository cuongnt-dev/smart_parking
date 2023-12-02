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
using ActUtlTypeLib;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly HttpClient httpClient;
        FilterInfoCollection listWebcamInfo;

        private Dictionary<string, CameraData> camCaptureList = new Dictionary<string, CameraData>();

        List<Setting> settingsList;
        int filename = 111;
        private System.Timers.Timer debounceTimer;
        Setting entranceState1;
        Setting entranceState2;
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
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // connectSerialPort();
            if (!PLC.IsRunning())
            {
                PLC.Connect(Constant.ACT_LOGICAL_STATION_NUMBER);
            }
            try
            {
                if (!DB.IsRunning())
                {
                    DB.Connect();
                }
                settingsList = DB.GetAllSetting();
                // Clean all Frame
                foreach (var item in camCaptureList)
                {
                    camCaptureList[item.Key].CleanFrame();
                }

                foreach (var item in camCaptureList)
                {
                    Setting st = settingsList.FirstOrDefault(setting => setting.Name == item.Key);
                    if (st != null && st.Value != "")
                    {
                        VideoCaptureDevice vcd = new VideoCaptureDevice(listWebcamInfo.Cast<FilterInfo>().FirstOrDefault(info => info.Name == st.Value).MonikerString);
                        camCaptureList[item.Key].StartFrame(vcd);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when load form {ex}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMainForm(sender, e);
        }

        private async void buttonCaptureCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxSelectedImageCheckin.Image = pictureBoxCamEntrance1In.Image;
                // Generate a filename based on the current timestamp
                string fileName = $"{DateTime.Now.Ticks}.jpg";

                // Combine the filename with the directory where you want to save the image
                string filePath = Path.Combine("D:\\LV\\capture", fileName);
                
                // Save the image to the specified file
                pictureBoxSelectedImageCheckin.Image.Save(filePath, ImageFormat.Jpeg);
                // Make a GET request to an API endpoint
                // string selectedPath = (listFile.SelectedItem as MediaFile).Path;
                HttpResponseMessage response = await httpClient.GetAsync($"detect?image={filePath}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DetectResponse responseObj = JsonConvert.DeserializeObject<DetectResponse>(apiResponse);
                    Console.WriteLine("Current Time Calling API: " + DateTime.Now.ToString("HH:mm:ss"));
                    // Access individual properties
                    string plateExtractPath = responseObj.PlateExtractPath;
                    string platePath = responseObj.PlatePath;
                    string plateText = responseObj.PlateText;
                    // Process the API response here
                    textBoxPlateEntrance1.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                }
                else
                {
                    textBoxPlateEntrance1.Text = "Error: " + response.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                textBoxPlateEntrance1.Text = "Error: " + ex.Message;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            AuthenicationForm authenicationForm = new AuthenicationForm("UserManageForm");
            authenicationForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AuthenicationForm authenicationForm = new AuthenicationForm("ParkingManageForm");
            authenicationForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AuthenicationForm authenicationForm = new AuthenicationForm("SystemManageForm");
            authenicationForm.LoadMainForm += LoadMainForm;
            authenicationForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


        private async void buttonTestCapture_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxSelectedImageCheckin.Image = Image.FromFile($"{Constant.TEST_PLATE_PATH}\\{filename}.jpg");
                filename = filename + 1;
                // Generate a filename based on the current timestamp
                string fileName = $"{DateTime.Now.Ticks}.jpg";

                // Combine the filename with the directory where you want to save the image
                string filePath = Path.Combine(Constant.CAPTURE_PATH, fileName);

                // Save the image to the specified file
                pictureBoxSelectedImageCheckin.Image.Save(filePath, ImageFormat.Jpeg);
                // Make a GET request to an API endpoint
                // string selectedPath = (listFile.SelectedItem as MediaFile).Path;
                HttpResponseMessage response = await httpClient.GetAsync($"detect?image={filePath}");
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DetectResponse responseObj = JsonConvert.DeserializeObject<DetectResponse>(apiResponse);
                    // Access individual properties
                    string plateExtractPath = responseObj.PlateExtractPath;
                    string platePath = responseObj.PlatePath;
                    string plateText = responseObj.PlateText;
                    // Process the API response here
                    textBoxPlateEntrance1.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                }
                else
                {
                    textBoxPlateEntrance1.Text = "Error: " + response.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                textBoxPlateEntrance1.Text = "Error: " + ex.Message;
            }
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
                    // Access individual properties
                    string plateExtractPath = responseObj.PlateExtractPath;
                    string platePath = responseObj.PlatePath;
                    string plateText = responseObj.PlateText;
                    // Process the API response here
                    textBoxPlateEntrance1.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                    return responseObj;
                }
                else
                {
                    textBoxPlateEntrance1.Text = "Error: " + response.ReasonPhrase;
                    return null;
                }
            }
            catch (Exception ex)
            {
                textBoxPlateEntrance1.Text = "Error: " + ex.Message;
                MessageBox.Show($"Error: {ex.Message}");
                return null;
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

        private void UpdateEntranceLabelInfor(string entrance, string parkingCardId, string plate, string state, DateTime occurance, string userName)
        {
            if(entrance == Constant.ENTRANCE_1)
            {
                labelEntrance1CardID.Text = $"Card ID: {parkingCardId}";
                labelEntrance1PlateNumber.Text = $"Plate Number: {plate}";
                labelEntrance1Type.Text = $"Type: {state}";
                labelEntrance1Occurence.Text = $"Occurance: {occurance}";
                labelEntrance1User.Text = $"User: {userName}";
            } else
            {
                labelEntrance2CardID.Text = $"Card ID: {parkingCardId}";
                labelEntrance2PlateNumber.Text = $"Plate Number: {plate}";
                labelEntrance2Type.Text = $"Type: {state}";
                labelEntrance2Occurence.Text = $"Occurance: {occurance}";
                labelEntrance2User.Text = $"User: {userName}";
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
            int randomNumber = random.Next(1, 26);
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
                return null;
            }
        }

        private async void Checkin(string parkingCardId, string entrance)
        {
            // Get CardId data
            User usr = DB.GetUserByCardId(parkingCardId);
            DetectResponse res = await CapturePlateAsync(entrance, Constant.CHECKIN_STATE);
            if (usr.Plate != res.PlateText)
            {
                MessageBox.Show("Invalid Plate");
                return;
            }
            UpdateEntranceLabelInfor(entrance, parkingCardId, res.PlateText, Constant.CHECKIN_STATE, DateTime.Now, usr.Name);
            // Trigger cardId Checkin {cardId}
            _ = Task.Run(() =>
            {
                Log l = new Log
                {
                    UserID = usr.ID,
                    Type = Constant.CHECKIN_STATE,
                    Occurrence = DateTime.Now,
                };
                DB.CreateLog(l);
            });
        }

        private async void Checkout(string parkingCardId, string entrance)
        {
            // Trigger cardId Checkout {tmpCardId}
            User usr = DB.GetUserByCardId(parkingCardId);
            DetectResponse res = await CapturePlateAsync(entrance, Constant.CHECKOUT_STATE);
            if (usr.Plate != res.PlateText)
            {
                MessageBox.Show("Invalid Plate");
                return;
            }
            // Get latest log of this user
            Log log = DB.GetLatestLog(usr.ID);
            if (log.Type != "Checkin")
            {
                MessageBox.Show("This card didn't used for checkin before");
                return;
            }
            UpdateEntranceLabelInfor(entrance, parkingCardId, res.PlateText, Constant.CHECKOUT_STATE, DateTime.Now, usr.Name);
            // Trigger cardId Checkin {cardId}
            _ = Task.Run(() =>
            {
                Log l = new Log
                {
                    UserID = usr.ID,
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
                        Checkin(parkingCardId, Constant.ENTRANCE_1);
                    }
                    else
                    {
                        Checkout(parkingCardId, Constant.ENTRANCE_1);
                    }
                }
                if (lastChar == Constant.LAST_CHAR_ENTRANCE_2)
                {
                    // Check current state of entrance
                    if (entranceState2.Value == Constant.CHECKIN_STATE)
                    {
                        Checkin(parkingCardId, Constant.ENTRANCE_2);
                    }
                    else
                    {
                        Checkout(parkingCardId, Constant.ENTRANCE_2);
                    }
                }
            }
            cardId = "";
            isReadyReceiveCard = false;
        }

        private void buttonToggleCheckinBarier_Click_1(object sender, EventArgs e)
        {
            PLC.WriteTo("X0", 1);
        }

        private void buttonCloseCheckinBarier_Click(object sender, EventArgs e)
        {
            PLC.WriteTo("X0", 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int value = PLC.ReadFrom(textBoxAddress.Text);
            textBoxValue.Text = value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PLC.WriteTo(textBoxAddress.Text, Convert.ToInt16(textBoxValue.Text));
        }

        private void buttonOpenBarier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo("X1", 1);
        }

        private void buttonCloseBarier2_Click(object sender, EventArgs e)
        {
            PLC.WriteTo("X1", 0);
        }

        private void timerListenBarierState_Tick_1(object sender, EventArgs e)
        {
            int state1 = PLC.ReadFrom("y0");
            if (state1 == 0)
            {
                statusIndicatorBarier1.StatusColor = Color.Red;
                labelBarierState1.Text = "Close";
            }
            else
            {
                statusIndicatorBarier1.StatusColor = Color.Green;
                labelBarierState1.Text = "Open";
            }
            int state2 = PLC.ReadFrom("y1");
            if (state2 == 0)
            {
                statusIndicatorBarier2.StatusColor = Color.Red;
                labelBarierState2.Text = "Close";
            }
            else
            {
                statusIndicatorBarier2.StatusColor = Color.Green;
                labelBarierState2.Text = "Open";
            }
        }

        private void timerInforDatetime_Tick(object sender, EventArgs e)
        {
            labelInforDatetime.Text = $"Datetime: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }
    }
}
