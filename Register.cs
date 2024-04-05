using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public static String name;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void clean()
        {
            guna2TextBox1.Text = string.Empty;
            guna2TextBox2.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox1.Text = name;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                guna2TextBox1.Focus();
                guna2TextBox1.BorderColor = Color.Red;
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (guna2TextBox2.Text != guna2TextBox3.Text)
            {
                MessageBox.Show("Please enter a password correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserRegistered(username))
            {
                MessageBox.Show("You are already registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RegisterUser(username);
            }
        }

        private bool IsUserRegistered(string username)
        {
            using (SqlConnection connection = ConnectToDatabase())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void RegisterUser(string username)
        {
            // Here you can implement the registration process, for example, inserting the new user into the database
            // You can add additional functionality such as password input, validation, etc.
            MessageBox.Show("You have been successfully registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean();
        }

        // Method to establish database connection
        public static SqlConnection ConnectToDatabase()
        {
            // Replace these with your actual database details
            string connectionString = "Server=MSI; Database=Library; User Id=root; Password=;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2TextBox3.UseSystemPasswordChar = true;

            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
            guna2TextBox3.UseSystemPasswordChar = true;
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

