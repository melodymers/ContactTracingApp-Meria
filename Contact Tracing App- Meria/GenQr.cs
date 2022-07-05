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

namespace Contact_Tracing_App__Meria
{
    public partial class GenQr : Form
    {
        public GenQr()
        {
            InitializeComponent();
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
    }
}
