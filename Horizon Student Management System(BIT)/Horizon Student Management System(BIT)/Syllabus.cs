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
    public partial class Syllabus : Form
    {
        public Syllabus()
        {
            InitializeComponent();
            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label1.Text = "Semester - 1" + '\n' + '\n' + "ITE 1912 - Communication Skills Development" + '\n' + "ITE 1112 - Visual Application Programming" + '\n' + "ITE 1812 - Mathematics for IT" + '\n' +
                    "ITE 1712 - Web Design" + '\n' + "ITE 1922 - ICT Applications";
            }else if(comboBox1.SelectedIndex == 1)
            {
                label1.Text = "Semester - 2" + '\n' + '\n' + "ITE 1122 - Fundamentals of Programming" + '\n' + "ITE 1932 - Technical Writing" + '\n' + "ITE 1412 - Information Management" + '\n' +
                   "ITE 1212 - Computer Systems" + '\n' + "ITE 1222 - System Analysis & Design" + '\n' + "ITE 1942 - ICT Project";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = "Semester - 3" + '\n' + '\n' + "ITE 2132 - Object Oriented Programming" + '\n' + "ITE 2142 - Data Structures and Algorithms" + '\n' + "ITE 2232 - Computer Networks & Operating System" + '\n' +
                   "ITE 2722 - Web Programming" + '\n' + "ITE 2422 - Database Management System";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Text = "Semester - 4" + '\n' + '\n' + "ITE 2732 - Multimedia Development" + '\n' + "ITE 2152 - Mobile Application Development" + '\n' + "ITE 2162- Software Engineering" + '\n' +
                   "ITE 2312 - IT Quality Assurance" + '\n' + "ITE 2612 - IT Project Management" + '\n' + "ITE 2952 - IT Programming Group Project";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label1.Text = "Semester - 5" + '\n' + '\n' + "ITE 3822 - Discrete MAthematics" + '\n' + "ITE 3322 - Professional Practice" + '\n' + "ITE 3342 - Information Security" + '\n' +
                   "ITE 3962 - Project**" + '\n' + "ITE 3512 - Fundamentals of AI - (E)" + '\n' + "ITE 3622 - Business Processes & Accounting Systems - (E)"
                   + '\n' + "ITE 3632 - Principle of Management - (E)" + '\n' + "ITE 3172 - Enterprice Application Development - (E)" + '\n' + "ITE 3972 - Research Methodology - (E)";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label1.Text = "Semester - 6" + '\n' + '\n' + "ITE 3962 - Project**" + '\n' + "ITE 3742 - Web Services - (E)" + '\n' + "ITE 3642 - Marketing - (E)" + '\n' +
                 "ITE 3432 - Data Mining - (E)" + '\n' + "ITE 3832 - Probability and Statistics - (E)" + '\n' + "ITE 3442 - Managenment Information System - (E)"
                 + '\n' + "ITE 3752 - Human Computer Interaction - (E)" + '\n' + "ITE 3352 - Quality Assurance in Practice - (E)" + '\n' + "ITE 3652 - Organizational Behavior - (E)"
                 + '\n' + "ITE 3522 - Essentials of Artificial Cognitive Systems - (E)" + '\n' + "ITE 3532 - Essentials of Machine Learning - (E)";
            }
            else
            {
                new MsgBox().ShowDialog();
                //MessageBox.Show("Please Choose the semester to see the Syllabus");
            }
        }
    }
}
