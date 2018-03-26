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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator admin = new Administrator();
            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            INOUT inout = new INOUT();
            inout.ShowDialog();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            EmpolyeeID.Clear();
        }

    }
}
