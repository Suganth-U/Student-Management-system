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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_password.Text = string.Empty;
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Admin/Suganth" && txt_password.Text.ToLower() == "kasthury1908")
                {
                    this.Hide();

                    Form f2 = new homepage();
                    f2.ShowDialog();
                    f2 = null;
                    this.Show();
                }
                else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Student" && txt_password.Text == "Campus@2023")
                {
                    this.Hide();

                    Form f2 = new homepage();
                    f2.ShowDialog();
                    f2 = null;
                    this.Show();
                }
                else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Guest" && txt_password.Text == "Campus@2023")
                {
                    this.Hide();

                    Form f2 = new homepage();
                    f2.ShowDialog();
                    f2 = null;
                    this.Show();
                }
                else
                {
                    new Msgbox_Home_().ShowDialog();

                }
            }
            catch { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
