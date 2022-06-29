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
    public partial class name_form : Form
    {
        public name_form()
        {
            InitializeComponent();
            var namefls = Directory.GetFiles(@"C:\Users\Melody\source\repos\Contact Tracing App- Meria\INFORMATION CTAPP\name folder");
            foreach (string file in namefls)
            {
                string dates = File.ReadAllText(file);
                nameformtxtbox.Text = nameformtxtbox.Text + dates + "\n";
            }
        }

        private void name_form_Load(object sender, EventArgs e)
        {

        }

        private void nameformtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
