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
    public partial class Attendance_Summary : Form
    {
        public Attendance_Summary()
        {
            InitializeComponent();
        }

        private void btnahome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page hpage = new Home_Page();
            hpage.ShowDialog();
        }
    }
}
