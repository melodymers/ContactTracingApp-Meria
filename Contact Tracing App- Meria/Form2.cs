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

namespace Contact_Tracing_App__Meria
{
    public partial class FillOutForm : Form
    {
        private object txtGenerateBtn;

        public FillOutForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            StreamWriter dox = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\test.txt", true);
            dox.WriteLine("FULL NAME: " + nameTxtBx.Text);
            dox.WriteLine("AGE: " + ageTxtBx.Text);
            dox.WriteLine("GENDER: " + genderTxtBx.Text);
            dox.WriteLine("ADDRESS: " + AddTxtBx.Text);
            dox.WriteLine("BIRTH DATE: " + bdayTxtBx.Text);
            dox.WriteLine("TEMPERATURE: " + tempTxtBx.Text);
            dox.WriteLine("TIME IN: " + inTxtBx.Text);
            dox.WriteLine("TIME OUT: " + outTxtBx.Text);
            dox.WriteLine("ARE YOU VACCINATED? " + vaxTxtBx.Text);
            dox.WriteLine("RECEIVED A BOOSTER? " + bstrTxtBx.Text);
            dox.Close();
        }
        private void ageTxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
