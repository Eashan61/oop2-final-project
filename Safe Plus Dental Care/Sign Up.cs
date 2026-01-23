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

namespace Safe_Plus_Dental_Care
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
            textBox1.UseSystemPasswordChar = true; // confirm password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation
            if (textUsername.Text == "" || txtPass.Text == "" ||
                textBox1.Text == "" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (txtPass.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string conStr = @"Data Source=EASHAN-PC\SQLEXPRESS;Initial Catalog=SafePlusDentalDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }

                    // Insert user
                    string insertQuery = @"INSERT INTO Users (Username, Password, Role)
                                           VALUES (@username, @password, @role)";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User created successfully");

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close(); // Exit Sign Up
        }

        private void ClearFields()
        {
            textUsername.Clear();
            txtPass.Clear();
            textBox1.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}
