using AxWMPLib;
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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly HttpClient httpClient;
        FilterInfoCollection listWebcamInfo;
        VideoCaptureDevice videoCaptureDeviceCheckin;
        VideoCaptureDevice videoCaptureDeviceCheckout;
        int filename = 111;

        public MainForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:3000/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in listWebcamInfo)
            {
                comboBoxListWebcamCheckin.Items.Add(item.Name);
                comboBoxListWebcamCheckout.Items.Add(item.Name);
            }
            if (comboBoxListWebcamCheckin.Items.Count > 0)
            {
                comboBoxListWebcamCheckin.SelectedIndex = 0;
            }
            if (comboBoxListWebcamCheckout.Items.Count > 1)
            {
                comboBoxListWebcamCheckout.SelectedIndex = 1;
            }
            DB.Connect();
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
                    plateResult.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                }
                else
                {
                    plateResult.Text = "Error: " + response.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                plateResult.Text = "Error: " + ex.Message;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPlayWebcam_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxListWebcamCheckin_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCaptureDeviceCheckin = new VideoCaptureDevice(listWebcamInfo[comboBoxListWebcamCheckin.SelectedIndex].MonikerString);
            videoCaptureDeviceCheckin.NewFrame += videoCaptureDeviceCheckin_NewFrame;
            videoCaptureDeviceCheckin.Start();
        }

        private void comboBoxListWebcamCheckout_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCaptureDeviceCheckout = new VideoCaptureDevice(listWebcamInfo[comboBoxListWebcamCheckout.SelectedIndex].MonikerString);
            videoCaptureDeviceCheckout.NewFrame += videoCaptureDeviceCheckout_NewFrame;
            videoCaptureDeviceCheckout.Start();
        }

        private async void buttonTestCapture_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxSelectedImageCheckin.Image = Image.FromFile($"D:\\LV\\smart_parking\\detect_plate\\test\\{filename}.jpg");
                filename = filename + 1;
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
                    // Access individual properties
                    string plateExtractPath = responseObj.PlateExtractPath;
                    string platePath = responseObj.PlatePath;
                    string plateText = responseObj.PlateText;
                    // Process the API response here
                    plateResult.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                }
                else
                {
                    plateResult.Text = "Error: " + response.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                plateResult.Text = "Error: " + ex.Message;
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
                    // Access individual properties
                    string plateExtractPath = responseObj.PlateExtractPath;
                    string platePath = responseObj.PlatePath;
                    string plateText = responseObj.PlateText;
                    // Process the API response here
                    plateResult.Text = plateText;
                    // pictureBoxPlateImageCheckout.Image = Image.FromFile(plateExtractPath);
                    return responseObj;
                }
                else
                {
                    plateResult.Text = "Error: " + response.ReasonPhrase;
                    return null;
                }
            }
            catch (Exception ex)
            {
                plateResult.Text = "Error: " + ex.Message;
                return null;
            }
        }

        private System.Timers.Timer debounceTimer;
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

        public async void EndTimer(object sender, ElapsedEventArgs e)
        {
            debounceTimer.Stop();
            
            if (cardId.Length == 8)
            {
                // Get CardId data
                User usr = DB.GetUserByCardId(cardId);
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
                    Type = "Checkin",
                    Occurrence = DateTime.Now,
                };
                DB.CreateLog(l);
            }
            else if (cardId.Length == 9 && cardId[cardId.Length - 1] == '?')
            {
                // Trigger cardId Checkout {tmpCardId}
                string tmpCardId = cardId.Substring(0, cardId.Length - 1);
                User usr = DB.GetUserByCardId(tmpCardId);
                DetectResponse res = await ScanPlate();
                if (usr.Plate != res.PlateText)
                {
                    MessageBox.Show("Invalid Plate");
                    return;
                }
                // Get latest log of this user
                Log log = DB.GetLatestLog(usr.ID);
                if(log.Type != "Checkin")
                {
                    MessageBox.Show("This card didn't used for checkin before");
                    return;
                }
                // Trigger cardId Checkin {cardId}
                Log l = new Log
                {
                    UserID = usr.ID,
                    Type = "Checkout",
                    Occurrence = DateTime.Now,
                };
                DB.CreateLog(l);
            }
            cardId = "";
            isReadyReceiveCard = false;
        }
    }
}
