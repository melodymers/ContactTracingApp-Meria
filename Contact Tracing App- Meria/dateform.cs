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
    public partial class dateform : Form
    {
        public dateform()
        {
            InitializeComponent();
            var datefls = Directory.GetFiles(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP");
            foreach (string file in datefls)
            {
                string dates = File.ReadAllText(file);
                recDateLbl.Text = recDateLbl.Text + dates + "\n";
            }

        }

        private void dateform_Load(object sender, EventArgs e)
        {
            
        }
    }
}
