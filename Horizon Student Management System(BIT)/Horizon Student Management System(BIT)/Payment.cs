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
    public partial class Payment : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("Student ID NO", Type.GetType("System.String"));
            table.Columns.Add("Student name", Type.GetType("System.String"));
            table.Columns.Add("Payment Status", Type.GetType("System.String"));
            table.Columns.Add("Payment Method", Type.GetType("System.String"));
            table.Columns.Add("Paid(month/semester)", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_id.Text, txt_fullname.Text, comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem),txt_sem.Text);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
           
            newdata.Cells[0].Value = txt_id.Text;
            newdata.Cells[1].Value = txt_fullname.Text;
            newdata.Cells[2].Value = comboBox1.GetItemText(comboBox1.SelectedItem);
            newdata.Cells[3].Value = comboBox2.GetItemText(comboBox2.SelectedItem);
            newdata.Cells[4].Value = txt_sem.Text;
            MessageBox.Show("Succesfully update the new data");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fullname.Text = string.Empty;
            txt_id.Text = string.Empty;
            txt_sem.Text = string.Empty;
        }

        private void datagridview1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_fullname.Text = row.Cells[1].Value.ToString();
            txt_sem.Text = row.Cells[4].Value.ToString();
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

        private void printdocument1_printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
    }
}
