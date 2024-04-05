using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private static string username = string.Empty;
        private static string password = string.Empty;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Register register = new Register();
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = string.Empty;
            guna2TextBox2.Text = string.Empty;  
        }
        // 23 24
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Please enter a username or password . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2TextBox1.Focus();
            }
            else
            {
                if (username == "senal" || password == "1234")
                {

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar=true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            username = guna2TextBox1.Text;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            password = guna2TextBox2.Text;  
        }
    }
}
