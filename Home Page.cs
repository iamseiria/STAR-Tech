using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Employee registeremployee = new Register_Employee();
            registeremployee.ShowDialog();
            
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_of_Employee listofemployee = new List_of_Employee();
            listofemployee.ShowDialog();
            
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance_Summary attendancesummary = new Attendance_Summary();
            attendancesummary.ShowDialog();
            
        }

        private void btnclose1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }
    }
}
