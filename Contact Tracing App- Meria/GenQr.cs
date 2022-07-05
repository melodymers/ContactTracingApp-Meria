using QRCoder;
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

namespace Contact_Tracing_App__Meria
{
    public partial class GenQr : Form
    {
        public GenQr()
        {
            InitializeComponent();

                StreamReader reader = new StreamReader(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\all information\generated.txt");
                string all = reader.ReadToEnd();
                txtBox.Text = all.ToString();
                reader.Close();
        }

        private void lblOnly_Click(object sender, EventArgs e)
        {

        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picGen.Image = code.GetGraphic(5);
        }

        private void picGen_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
