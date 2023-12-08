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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f2 = new Form1();
            f2.ShowDialog();
           Application.Exit();
            //f2 = null;
            //this.Show();
           /* this.Close();
            Form f2 = new homepage();
            f2.Hide();
            Form f1 = new Form1();
            f1.Show();*/
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
