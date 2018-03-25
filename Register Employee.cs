using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Form
{
    public partial class Register_Employee : Form
    {
        public Register_Employee()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EmployeeID.Clear();
            firstname.Clear();
            middleinitial.Clear();
            lastname.Clear();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page home = new Home_Page();
            home.ShowDialog();
            
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Jas Orda\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"; ;

            cnn = new SqlConnection(connectionString);
    sql = "insert into User (First Name, Middle Initial, Last Name) values(firstname.Text,middleinitial.Text, lastname.Text)";

    try
    {
        cnn.Open();
        adapter.InsertCommand = new SqlCommand(sql, cnn);
        adapter.InsertCommand.ExecuteNonQuery();
         MessageBox.Show ("Row inserted !! ");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
        }
        }
    }
        }