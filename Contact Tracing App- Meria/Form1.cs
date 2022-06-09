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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void titleHeader_Click(object sender, EventArgs e)
        {

        }

        private void citizenBtn_Click(object sender, EventArgs e)
        {
            var Form2 = new FillOutForm();
            Form2.Show();
            this.Hide();
        }

        private void merchantBtn_Click(object sender, EventArgs e)
        {
            var Form2 = new FillOutForm();
            Form2.Show();
            this.Hide();
        }
    }
}
