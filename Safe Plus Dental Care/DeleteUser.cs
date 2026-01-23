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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();

            // Setup password masking so characters appear as dots
            txtPass.UseSystemPasswordChar = true;
            textBox1.UseSystemPasswordChar = true; // Confirm Password field
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // 1. Basic Validation
            if (textUsername.Text == "" || txtPass.Text == "" ||
                textBox1.Text == "" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields to verify deletion.");
                return;
            }

            // 2. Check if Password and Confirm Password match
            if (txtPass.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Connection String
            string conStr = @"Data Source=EASHAN-PC\SQLEXPRESS;Initial Catalog=SafePlusDentalDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // 3. Check if this specific user exists with these credentials
                    // We check Username, Password AND Role to ensure we are deleting the exact right person
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password AND Role=@role";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                        int matchFound = (int)checkCmd.ExecuteScalar();

                        if (matchFound == 0)
                        {
                            MessageBox.Show("User not found or credentials incorrect. Deletion failed.");
                            return;
                        }
                    }

                    // 4. Perform the Delete Operation
                    string deleteQuery = "DELETE FROM Users WHERE Username=@username AND Password=@password";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User deleted successfully.");

                        // Optional: Clear fields or close form after successful deletion
                        ClearFields();
                        // this.Close(); // Uncomment if you want the window to close immediately
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            // Navigate back to Login or close the app
            Login login = new Login();
            login.Show();
            this.Close();
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
