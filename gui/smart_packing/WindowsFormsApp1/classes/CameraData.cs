using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.classes
{
    internal class CameraData
    {
        public PictureBox PictureBox { get; set; }
        public VideoCaptureDevice VideoCapture { get; set; }

        public void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void StartFrame(VideoCaptureDevice vcd)
        {
            VideoCapture = vcd;
            VideoCapture.NewFrame += NewFrame;
            VideoCapture.Start();
        }

        public void CleanFrame()
        {
            if(VideoCapture != null)
            {
                VideoCapture.NewFrame -= NewFrame;
                if (VideoCapture.IsRunning)
                {
                    VideoCapture.Stop();
                }
                PictureBox.Image = null;
                VideoCapture = null;
            }
        }
    }
}
