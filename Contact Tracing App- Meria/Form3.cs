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

        private void DisplayAllBtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\test.txt", true);
            string all = reader.ReadToEnd();
            MessageBox.Show(all);
        }
    }
}
