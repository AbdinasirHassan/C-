using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshowdate_Click(object sender, EventArgs e)

        {
            //declare variable
            string week, month, year, day;


            //Assign varible
            week = dayofweektextbox.Text;
            month = monthtextbox.Text;
            year = yeartextbox.Text;
            day=dayofmonthtextbox.Text;

            outputlabel.Text = day+ " "+ week +" "+ month + " " + year;

            



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dayofmonthtextbox.Clear();
            dayofweektextbox.Clear();
            yeartextbox.Clear();
            monthtextbox.Clear();
            outputlabel.Text="";

        }
    }
}
