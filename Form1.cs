using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace FacialRecognition
{
    public partial class Web_Cam : Form
    {
        public Web_Cam()
        {
            InitializeComponent();
        }

        //intialise stopwach for frame counting
        Stopwatch stopwatch = new Stopwatch();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        int count = 0;


        private void webCamLoad(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comCamera.Items.Add(filterInfo.Name);

            comCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            stopwatch.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            

        }

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if(stopwatch.ElapsedMilliseconds > setFPS())
            {
                Console.WriteLine(setFPS());
                Bitmap photoFrame = (Bitmap)eventArgs.Frame.Clone();

                photoFrame.RotateFlip(RotateFlipType.RotateNoneFlipX);

                if (chkbxFaceDetction.Checked)
                {
                    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(photoFrame);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

                    if (rectangles.Length > 0)
                    {
                        foreach (Rectangle rectangle in rectangles)
                        {
                            using (Graphics graphics = Graphics.FromImage(photoFrame))
                            {
                                using (Pen pen = new Pen(Color.Red, 5))
                                {
                                    graphics.DrawRectangle(pen, rectangle);
                                }
                            }

                            Console.WriteLine(count);
                            count++;

                        }
                    }

                }

                webCam.SizeMode = PictureBoxSizeMode.StretchImage;
                webCam.Image = photoFrame;
            }
            stopwatch.Restart();

        }

        private void Web_Cam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }

        private double setFPS()
        {

            double milliseconds = 0;
            if (fpsBar.InvokeRequired)
            {
                fpsBar.Invoke(new MethodInvoker(delegate { milliseconds = 1000 / fpsBar.Value; }));
            }

            else
            {
                milliseconds = 1000 / fpsBar.Value;
            }

            return milliseconds;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
                webCam.Image = null;
            }
        }

        private void chkbxFaceDetction_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fpsBar_Scroll(object sender, EventArgs e)
        {
            if(videoCaptureDevice.IsRunning == true)
            {
                fpsCounter.Text = fpsBar.Value.ToString();
            }

            else
            {
                fpsCounter.Text = "Camera off";
            }
        }
    }


}
