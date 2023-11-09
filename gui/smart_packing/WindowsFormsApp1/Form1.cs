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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private VideoCaptureDevice FinalFrame;
        private readonly HttpClient httpClient;
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
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
    }
}
