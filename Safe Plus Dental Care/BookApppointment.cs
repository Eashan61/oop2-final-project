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



namespace Safe_Plus_Dental_Care
{
    public partial class BookApppointment : Form
    {
        public BookApppointment()
        {
            InitializeComponent();

            


        }

        string connectionString =
@"Data Source=EASHAN-PC\SQLEXPRESS;
Initial Catalog=SafePlusDentalDB;
Integrated Security=True";


        private void button2_Click(object sender, EventArgs e)
        {
            ReceptionistHome rh = new ReceptionistHome();
            
            
            rh.Show();
            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {


            // 1. Basic field validation
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                comGender.SelectedIndex == -1 ||
                comBlood.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbPh.Text))
            {
                MessageBox.Show("Please fill all fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = AppDate.Value.Date;
            DateTime today = DateTime.Today;

            // 2. ❌ Past date check
            if (selectedDate < today)
            {
                MessageBox.Show("You cannot book an appointment in the past.",
                                "Invalid Date",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. ❌ Friday check
            if (selectedDate.DayOfWeek == DayOfWeek.Friday)
            {
                MessageBox.Show("Appointments are not available on Friday.",
                                "Clinic Closed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 4. SQL Insert Query
            string query = @"INSERT INTO dbo.Appointments
                     (PatientName, Gender, BloodGroup, PhoneNumber, AppointmentDate)
                     VALUES
                     (@PatientName, @Gender, @BloodGroup, @PhoneNumber, @AppointmentDate)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PatientName", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", comGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BloodGroup", comBlood.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNumber", tbPh.Text.Trim());
                    cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment booked successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            tbName.Clear();
            tbPh.Clear();
            comGender.SelectedIndex = -1;
            comBlood.SelectedIndex = -1;
            AppDate.Value = DateTime.Now;
        }





    }
}
