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
    public partial class List_of_Employee : Form
    {
        public List_of_Employee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page page = new Home_Page();
            page.ShowDialog();
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
