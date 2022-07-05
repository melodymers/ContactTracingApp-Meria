using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void GenerateBtn_Click_1(object sender, EventArgs e)
        {
        if (nameTxtBx.Text == "" || AgeTxtBx.Text == "" || genderTxtBx.Text =="" || AddTxtBx.Text=="" || bdayTxtBx.Text=="" || tempTxtBx.Text=="" || inTxtBx.Text=="" || outTxtBx.Text=="" || vaxTxtBx.Text=="" || bstrTxtBx.Text=="")
            {
                MessageBox.Show("Please complete the form", "REQUIRED");
            }
        else
            {
                StreamWriter dox = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\all information\test.txt", true);
                dox.WriteLine("FULL NAME: " + nameTxtBx.Text + ", " + "AGE: " + AgeTxtBx.Text + ", " + "GENDER: " + genderTxtBx.Text + ", " +
                    "ADDRESS: " + AddTxtBx.Text + ", " + "BIRTH DATE: " + bdayTxtBx.Text + ", " + "TEMPERATURE: " + tempTxtBx.Text + ", " +
                    "TIME IN: " + inTxtBx.Text + ", " + "TIME IN: " + inTxtBx.Text + ", " + "TIME OUT: " + outTxtBx.Text + ", " +
                    "ARE YOU VACCINATED? " + vaxTxtBx.Text + ", " + "RECEIVED A BOOSTER? " + bstrTxtBx.Text + ", " + "DATE: " + SetDatePickr.Text);
                dox.WriteLine("-------------------");
                dox.Close();
                MessageBox.Show("THANK YOU FOR YOUR TIME", "COMPLETED");
            }
        }
        private void tempTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tempTxtBx.Text, "[^0-9:.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tempTxtBx.Text = tempTxtBx.Text.Remove(tempTxtBx.Text.Length - 1);
            }
          }
        private void AgeTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(AgeTxtBx.Text, "[^0-9:.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                AgeTxtBx.Text = AgeTxtBx.Text.Remove(AgeTxtBx.Text.Length - 1);
            }
        }
        private void inTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inTxtBx.Text, "[^0-9:.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                inTxtBx.Text = inTxtBx.Text.Remove(inTxtBx.Text.Length - 1);
            }
        }

        private void outTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(outTxtBx.Text, "[^0-9:.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                outTxtBx.Text = outTxtBx.Text.Remove(outTxtBx.Text.Length - 1);
            }
        }
        private void nameTxtBx_TextChanged(object sender, EventArgs e)
        {
        }

        private void genderTxtBx_TextChanged(object sender, EventArgs e)
        {
        }
        private void AddTxtBx_TextChanged(object sender, EventArgs e)
        {
        }
        private void bdayTxtBx_TextChanged(object sender, EventArgs e)
        {
        }
        private void vaxTxtBx_TextChanged(object sender, EventArgs e)
        {
        }

        private void bstrTxtBx_TextChanged(object sender, EventArgs e)
        {
        }
        private void admnBtn_Click_1(object sender, EventArgs e)
        {
            String pss = passBtn.Text;
            if (pss == "admin123") 
            {
                var Form3 = new adminDesk();
                Form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }
        private void passBtn_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void SetDatePickr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ScanQR_Click(object sender, EventArgs e)
        {
            var scanQr = new scanQr();
            scanQr.Show();
            this.Hide();
        }

        private void GenrBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBx.Text == "" || AgeTxtBx.Text == "" || genderTxtBx.Text == "" || AddTxtBx.Text == "" || bdayTxtBx.Text == "" || tempTxtBx.Text == "" || inTxtBx.Text == "" || outTxtBx.Text == "" || vaxTxtBx.Text == "" || bstrTxtBx.Text == "")
            {
                MessageBox.Show("Please complete the form", "REQUIRED");
            }
            else
            {
                StreamWriter dox = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\QR code folder\generated.txt", true);
                dox.WriteLine("FULL NAME: " + nameTxtBx.Text + ", " + "AGE: " + AgeTxtBx.Text + ", " + "GENDER: " + genderTxtBx.Text + ", " +
                    "ADDRESS: " + AddTxtBx.Text + ", " + "BIRTH DATE: " + bdayTxtBx.Text + ", " + "TEMPERATURE: " + tempTxtBx.Text + ", " +
                    "TIME IN: " + inTxtBx.Text + ", " + "TIME IN: " + inTxtBx.Text + ", " + "TIME OUT: " + outTxtBx.Text + ", " +
                    "ARE YOU VACCINATED? " + vaxTxtBx.Text + ", " + "RECEIVED A BOOSTER? " + bstrTxtBx.Text + ", " + "DATE: " + SetDatePickr.Text);
                dox.WriteLine("-------------------");
                dox.Close();
            }

            var GenQr = new GenQr();
            GenQr.Show();
            this.Hide();
        }
    }
}

        
