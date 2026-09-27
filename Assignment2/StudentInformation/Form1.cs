using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void btnShowinfo_Click(object sender, EventArgs e)
        {
            string name, dept;
            int semester, studentId;
            name = txtname.Text;
            dept = txtdepartment.Text;
            studentId = int.Parse(txtStudentId.Text);
            semester = int.Parse((string)txtSemester.Text);

            lbloutput.Text =
                "Student Name: " + name + " Student ID: " 
                + studentId + " Department: " 
                + dept + " Semester: " + semester;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "";
            txtStudentId.Text = string.Empty;
            txtSemester.Text = string.Empty;
            txtname.Text = string.Empty;
            txtdepartment.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
