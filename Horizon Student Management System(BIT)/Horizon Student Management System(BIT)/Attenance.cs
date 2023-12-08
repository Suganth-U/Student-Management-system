using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon_Student_Management_System_BIT_
{

    public partial class Attendance : Form
    {
        DataTable table = new DataTable("table");
        int index;

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attenance_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", Type.GetType("System.String"));
            table.Columns.Add("Student ID NO", Type.GetType("System.String"));
            table.Columns.Add("Student name", Type.GetType("System.String"));
            table.Columns.Add("Status", Type.GetType("System.String"));
            
            dataGridView1.DataSource = table;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(dateTimePicker1.Value.ToString(),txt_id.Text, txt_fullname.Text, comboBox1.GetItemText(comboBox1.SelectedItem));

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data is ready to print");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printdocument_printPAge(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void datagridview1_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            
            txt_id.Text = row.Cells[1].Value.ToString();
            txt_fullname.Text = row.Cells[2].Value.ToString();
            


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = dateTimePicker1.Value.ToString();
            newdata.Cells[1].Value = txt_id.Text;
            newdata.Cells[2].Value = txt_fullname.Text;
            newdata.Cells[3].Value = comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show("Succesfully update the new data");

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fullname.Text = string.Empty;
            txt_id.Text = string.Empty;
        }
    }
}
