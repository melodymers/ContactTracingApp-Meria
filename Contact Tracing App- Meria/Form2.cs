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
        public FillOutForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            StreamWriter doc = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP.txt", true);
            doc.WriteLine("FULL NAME: " + nameTxtBx.Text);
            doc.WriteLine("AGE: " + ageTxtBx.Text);
            doc.WriteLine("GENDER: " + genderTxtBx.Text);
            doc.WriteLine("ADDRESS: " + AddTxtBx.Text);

            doc.Close();
        }
        private void ageTxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
