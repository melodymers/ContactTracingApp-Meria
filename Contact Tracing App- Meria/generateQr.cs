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
    public partial class generateQr : Form
    {

        private FilterInfoCollection capturingDevice;
        private VideoCaptureDevice capturedFrame;
        public generateQr()
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
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)picBox.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    txtBox.Text = decoded;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            string data = picBox.Text;
            if (data == "")
            {
                MessageBox.Show("Please try again");
            }
            else
            {
                StreamWriter QRfolder = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\QR code.txt", true);
                QRfolder.WriteLine(data);
                MessageBox.Show("Inforamation is uploaded");
                Application.Restart();
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
