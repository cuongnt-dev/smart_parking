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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly HttpClient httpClient;
        FilterInfoCollection listWebcamInfo;
        VideoCaptureDevice videoCaptureDeviceCheckin;
        VideoCaptureDevice videoCaptureDeviceCheckout;


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

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Make a GET request to an API endpoint
                // string selectedPath = (listFile.SelectedItem as MediaFile).Path;
                string selectedPath = "abc.jpoh";
                HttpResponseMessage response = await httpClient.GetAsync($"detect?image={selectedPath}");

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
                    pictureBoxPlateImage.Image = Image.FromFile(plateExtractPath);
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

        private void buttonCaptureWebcam_Click(object sender, EventArgs e)
        {
            pictureBoxWebcamCheckout.Image = pictureBoxWebcamCheckin.Image;
            // Generate a filename based on the current timestamp
            string fileName = $"{DateTime.Now.Ticks}.jpg";

            // Combine the filename with the directory where you want to save the image
            string filePath = Path.Combine("D:\\LV\\capture", fileName);

            // Save the image to the specified file
            pictureBoxWebcamCheckout.Image.Save(filePath, ImageFormat.Jpeg);
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
    }
}
