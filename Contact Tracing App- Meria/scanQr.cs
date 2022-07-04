using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Contact_Tracing_App__Meria
{
    public partial class scanQr : Form
    {

        private FilterInfoCollection capturingDevice;
        private VideoCaptureDevice capturedFrame;
        public scanQr()
        {
            InitializeComponent();
        }

        private void generateQr_Load(object sender, EventArgs e)
        {
            capturingDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo thisdevice in capturingDevice)
                CBBox.Items.Add(thisdevice.Name);
            CBBox.SelectedIndex = 0;
            capturedFrame = new VideoCaptureDevice();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            capturedFrame = new VideoCaptureDevice(capturingDevice[CBBox.SelectedIndex].MonikerString);
            capturedFrame.NewFrame += new NewFrameEventHandler(final_Newframe);
            capturedFrame.Start();
            genTmr.Start();
        }
        private void final_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            picBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void generateQr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capturedFrame.IsRunning == true)
                capturedFrame.Stop();
        }

        private void IndTmr(object sender, EventArgs e)
        {
           if (picBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)picBox.Image);
                if (result != null)
                {
                    txtBox.Text = result.ToString();

                    
                }
            }
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            string data = txtBox.Text;
            if (data == "")
            {
                MessageBox.Show("Please try again");
            }
            else
            {
                StreamWriter QRfolder = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\QR code folder\QR code.txt", true);
                QRfolder.WriteLine(data);
                QRfolder.Close();
                MessageBox.Show("Information is uploaded");
                Application.Restart();
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            capturedFrame = new VideoCaptureDevice(capturingDevice[CBBox.SelectedIndex].MonikerString);
            capturedFrame.NewFrame += new NewFrameEventHandler(final_Newframe);
            capturedFrame.Stop();
        }

        private void CBBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
