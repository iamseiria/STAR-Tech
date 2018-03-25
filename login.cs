using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Class;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        } 

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username  ='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                LoginInfo.UserID = textBox1.Text;
                home signup = new home();
                signup.Show();
            }
            else
            {
                MessageBox.Show("Please Check you Username and Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
