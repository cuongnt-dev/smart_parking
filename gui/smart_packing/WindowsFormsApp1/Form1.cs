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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private VideoCaptureDevice FinalFrame;
        public Form1()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click me");
        }
    }
}
