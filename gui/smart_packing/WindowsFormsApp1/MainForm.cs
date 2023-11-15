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
        
        private VideoCaptureDevice FinalFrame;
        private readonly HttpClient httpClient;
        FilterInfoCollection listWebcamInfo;
        VideoCaptureDevice videoCaptureDevice;
        
        public MainForm()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:3000/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff|All Files|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(filename);
                        files.Add(new MediaFile()
                        {
                            FileName = Path.GetFileNameWithoutExtension(fi.FullName),
                            Path = fi.FullName
                        });
                    }
                    listFile.DataSource = files;
                }
            }
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFile.SelectedIndex != -1)
            {
                string selectedImagePath = (listFile.SelectedItem as MediaFile).Path;
                pictureBoxSelectedImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click me");
            try
            {
                // Make a GET request to an API endpoint
                string selectedPath = (listFile.SelectedItem as MediaFile).Path;
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

        private void buttonPlayWebcam_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(listWebcamInfo[comboBoxListWebcam.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebcam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void buttonCaptureWebcam_Click(object sender, EventArgs e)
        {
            pictureBoxCaptureWebcam.Image = pictureBoxWebcam.Image;
            // Generate a filename based on the current timestamp
            string fileName = $"{DateTime.Now.Ticks}.jpg";

            // Combine the filename with the directory where you want to save the image
            string filePath = Path.Combine("D:\\LV\\capture", fileName);

            // Save the image to the specified file
            pictureBoxCaptureWebcam.Image.Save(filePath, ImageFormat.Jpeg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthenicationForm authenicationForm = new AuthenicationForm("UserManageForm");
            authenicationForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
            listWebcamInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in listWebcamInfo)
            {
                comboBoxListWebcam.Items.Add(item.Name);
            }
            if(comboBoxListWebcam.Items.Count > 0)
            {
                comboBoxListWebcam.SelectedIndex = 0;
            }
            videoCaptureDevice = new VideoCaptureDevice();
            DB.Connect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AuthenicationForm authenicationForm = new AuthenicationForm("ParkingManageForm");
            authenicationForm.ShowDialog();
        }
    }
}
