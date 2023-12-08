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
    public partial class Register : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Register()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_id.Text,txt_fullname.Text,txt_address.Text,txt_con_NO.Text,txt_Email.Text);
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Student ID NO", Type.GetType("System.String"));
            table.Columns.Add("Fullname", Type.GetType("System.String"));
            table.Columns.Add("Address", Type.GetType("System.String"));
            table.Columns.Add("Contact NO", Type.GetType("System.String"));
            table.Columns.Add("E-mail", Type.GetType("System.String"));
            dataGridView1.DataSource = table; 
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Email.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_con_NO.Text = string.Empty;
            txt_fullname.Text = string.Empty;
            txt_id.Text = string.Empty;
        }

        private void datagridview1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_fullname.Text = row.Cells[1].Value.ToString();
            txt_address.Text = row.Cells[2].Value.ToString();
            txt_con_NO.Text = row.Cells[3].Value.ToString();
            txt_Email.Text = row.Cells[4].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txt_id.Text;
            newdata.Cells[1].Value = txt_fullname.Text;
            newdata.Cells[2].Value = txt_address.Text;
            newdata.Cells[3].Value = txt_con_NO.Text;
            newdata.Cells[4].Value = txt_Email.Text;
            MessageBox.Show("Succesfully update the new data");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void printDocument_Printpage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data is ready to print");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
