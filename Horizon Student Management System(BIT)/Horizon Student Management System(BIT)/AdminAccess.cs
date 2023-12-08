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
    public partial class AdminAccess : Form
    {
        public AdminAccess()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
            new Security().ShowDialog();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
