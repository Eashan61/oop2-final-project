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
using System.Configuration;



namespace Safe_Plus_Dental_Care
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txtPass.Multiline = false;
            txtPass.UseSystemPasswordChar = true;
            txtPass.PasswordChar = '*';



        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (textUsername.Text == "" || txtPass.Text == "" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string conStr = @"Data Source=EASHAN-PC\SQLEXPRESS;Initial Catalog=SafePlusDentalDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    string query = @"SELECT COUNT(*) FROM Users 
                             WHERE Username=@username 
                             AND Password=@password 
                             AND Role=@role";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            MessageBox.Show("Login Successful");

                            // ROLE BASED NAVIGATION
                            if (cmbRole.SelectedItem.ToString() == "Admin")
                            {
                                new AdminHome().Show();
                            }
                            else if (cmbRole.SelectedItem.ToString() == "Doctor")
                            {
                                new DoctorHome().Show();
                            }
                            else if (cmbRole.SelectedItem.ToString() == "Receptionist")
                            {
                                new ReceptionistHome().Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username, password, or role");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
