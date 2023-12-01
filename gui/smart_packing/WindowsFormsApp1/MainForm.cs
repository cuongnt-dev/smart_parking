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
        VideoCaptureDevice videoCaptureDeviceCheckin;
        VideoCaptureDevice videoCaptureDeviceCheckout;
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
        }

        private void connectSerialPort()
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = Constant.PORT_NAME;
                    serialPort.BaudRate = Convert.ToInt32(Constant.BAUD_RATE);
                    serialPort.Open();
                    labelCheckinBarierStatus.Text = "Barier 1: Normal";
                }
                catch (Exception ex)
                {
                    labelCheckinBarierStatus.Text = "Barier 1: Abnormal";
                }
            }
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // connectSerialPort();
            PLC.Connect(Constant.ACT_LOGICAL_STATION_NUMBER);
            try
            {
                DB.Connect();
                settingsList = DB.GetAllSetting();
                Setting entranceCamSetting1 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_CAM_1);
                if (entranceCamSetting1 != null)
                {
                    videoCaptureDeviceCheckin = new VideoCaptureDevice(listWebcamInfo.Cast<FilterInfo>().FirstOrDefault(info => info.Name == entranceCamSetting1.Value).MonikerString);
                    videoCaptureDeviceCheckin.NewFrame += videoCaptureDeviceCheckin_NewFrame;
                    videoCaptureDeviceCheckin.Start();
                }
                Setting entranceCamSetting2 = settingsList.FirstOrDefault(setting => setting.Name == Constant.ENTRANCE_CAM_2);
                if (entranceCamSetting2 != null)
                {
                    videoCaptureDeviceCheckout = new VideoCaptureDevice(listWebcamInfo.Cast<FilterInfo>().FirstOrDefault(info => info.Name == entranceCamSetting2.Value).MonikerString);
                    videoCaptureDeviceCheckout.NewFrame += videoCaptureDeviceCheckout_NewFrame;
                    videoCaptureDeviceCheckout.Start();
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
                pictureBoxSelectedImageCheckin.Image = pictureBoxWebcamCheckin.Image;
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

        private void videoCaptureDeviceCheckin_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebcamCheckin.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void videoCaptureDeviceCheckout_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebcamCheckout.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDeviceCheckin.IsRunning == true)
            {
                videoCaptureDeviceCheckin.Stop();
            }
            if (videoCaptureDeviceCheckout.IsRunning == true)
            {
                videoCaptureDeviceCheckout.Stop();
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
                pictureBoxSelectedImageCheckin.Image = Image.FromFile($"E:\\Document\\Essay\\code\\smart_parking\\detect_plate\\test\\{filename}.jpg");
                filename = filename + 1;
                // Generate a filename based on the current timestamp
                string fileName = $"{DateTime.Now.Ticks}.jpg";

                // Combine the filename with the directory where you want to save the image
                string filePath = Path.Combine("E:\\Document\\Essay\\code\\capture", fileName);

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

        private async Task<DetectResponse> ScanPlate()
        {
            try
            {
                pictureBoxSelectedImageCheckin.Image = pictureBoxWebcamCheckin.Image;
                // Generate a filename based on the current timestamp
                string fileName = $"{DateTime.Now.Ticks}.jpg";

                // Combine the filename with the directory where you want to save the image
                string filePath = Path.Combine("E:\\Document\\Essay\\code\\capture", fileName);

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
                debounceTimer = new System.Timers.Timer(100);
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

        private async void Checkin(string parkingCardId)
        {
            // Get CardId data
            User usr = DB.GetUserByCardId(parkingCardId);
            DetectResponse res = await ScanPlate();
            if (usr.Plate != res.PlateText)
            {
                MessageBox.Show("Invalid Plate");
                return;
            }
            // Trigger cardId Checkin {cardId}
            Log l = new Log
            {
                UserID = usr.ID,
                Type = Constant.CHECKIN_STATE,
                Occurrence = DateTime.Now,
            };
            DB.CreateLog(l);
        }

        private async void Checkout(string parkingCardId)
        {
            // Trigger cardId Checkout {tmpCardId}
            User usr = DB.GetUserByCardId(parkingCardId);
            DetectResponse res = await ScanPlate();
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
            // Trigger cardId Checkin {cardId}
            Log l = new Log
            {
                UserID = usr.ID,
                Type = Constant.CHECKOUT_STATE,
                Occurrence = DateTime.Now,
            };
            DB.CreateLog(l);
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
                        Checkin(parkingCardId);
                    }
                    else
                    {
                        Checkout(parkingCardId);
                    }
                }
                if (lastChar == Constant.LAST_CHAR_ENTRANCE_2)
                {
                    // Check current state of entrance
                    if (entranceState2.Value == Constant.CHECKIN_STATE)
                    {
                        Checkin(parkingCardId);
                    }
                    else
                    {
                        Checkout(parkingCardId);
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
