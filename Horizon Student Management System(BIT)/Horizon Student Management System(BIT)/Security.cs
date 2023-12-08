using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon_Student_Management_System_BIT_
{
    public partial class Security : Form
    {
        public static Security instance;
        public TextBox tb1;
        public Security()
        {
            InitializeComponent();
            instance = this;
            tb1 = txt_password;
        }

        private void lbl_msgbox_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Security.instance.tb1.Text == "Kasthury1908" || Security.instance.tb1.Text == "Suganth2002")
            {
                
                Form f5 = new Payment();
                f5.TopLevel = false;
                homepage.instance.p3.Controls.Add(f5);
                f5.BringToFront();
                f5.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Permission Denied");
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
