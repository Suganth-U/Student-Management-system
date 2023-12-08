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
    public partial class homepage : Form
    {
        public static homepage instance;
        public Panel p3;
        public homepage()
        {
            InitializeComponent();
            instance = this;
            p3 = panel3;
        }

      

        private void lbl_close_Click(object sender, EventArgs e)
        {
            new homeclose().ShowDialog();
            /*this.Close();
            Application.Exit();*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new LogOut().ShowDialog();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form f3 = new Register();
            f3.TopLevel = false;
            panel3.Controls.Add(f3);
            f3.BringToFront();
            f3.Show();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            Form f4 = new Attendance();
            f4.TopLevel = false;
            panel3.Controls.Add(f4);
            f4.BringToFront();
            f4.Show();
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            Form f8 = new AdminAccess();
            f8.Show();

            /* if(Security.instance.tb1.Text == "Kasthury1908" || Security.instance.tb1.Text == "Suganth2002") {
                 Form f5 = new Payment();
                 f5.TopLevel = false;
                 panel3.Controls.Add(f5);
                 f5.BringToFront();
                 f5.Show();
             }
             else
             {
                 MessageBox.Show("Permission Denied");
             }*/

        }

        private void btn_Syllabus_Click(object sender, EventArgs e)
        {
            Form f6 = new Syllabus();
            f6.TopLevel = false;
            panel3.Controls.Add(f6);
            f6.BringToFront();
            f6.Show();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            
            Form f7 = new Dashboard();
            f7.TopLevel = false;
            panel3.Controls.Add(f7);
            f7.BringToFront();
            f7.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Form f7 = new Dashboard();
            f7.TopLevel = false;
            panel3.Controls.Add(f7);
            f7.BringToFront();
            f7.Show();
        }
    }
}
