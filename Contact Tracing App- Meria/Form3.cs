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
    public partial class adminDesk : Form
    {
        public adminDesk()
        {
            InitializeComponent();
        }

        private void adminDesk_Load(object sender, EventArgs e)
        {

        }
        //all info
        private void DisplayAllBtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\all information\test.txt");
            string all = reader.ReadToEnd();
            forAllDisplayBox.Text = all.ToString();
            reader.Close();
        }

       //dates
        private void DatePickrBtn_Click(object sender, EventArgs e)
        {
        List<string> date = new List<string>();
        string dates = SetDatePickr.Text;
        int daterslt = 0;
        var datefile = Directory.EnumerateFiles(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\all information");
            foreach (string file in datefile)
            {
                string datecontents = File.ReadAllText(file);
                if (datecontents.Contains(dates))
                {
                    date.Add(datecontents);
                    daterslt++;
                    continue;
                }
            }
                if (daterslt == 0)
                {
                MessageBox.Show("NOTHING FOUND");
                this.Hide();
                }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\date file.txt");
                foreach(string datecontents in date)
                {
                    file.WriteLine(datecontents);
                }
                file.Close();
                MessageBox.Show("Found: " + daterslt + " records on your specified date");
                MessageBox.Show("Saved in the Contact Tracing Folder");
                dateform data = new dateform();
                data.ShowDialog();
            }
        }
        private void SetDatePickr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recDateLbl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
