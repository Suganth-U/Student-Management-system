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
    public partial class Msgbox_Home_ : Form
    {
        public Msgbox_Home_()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
