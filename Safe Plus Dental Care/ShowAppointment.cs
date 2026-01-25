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
    public partial class ShowAppointment : Form
    {
        string connectionString =
@"Data Source=EASHAN-PC\SQLEXPRESS;
Initial Catalog=SafePlusDentalDB;
Integrated Security=True";

        private void LoadAppointmentsByDate(DateTime date)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AppointmentID, PatientName, PhoneNumber, Gender, BloodGroup, AppointmentDate
                         FROM dbo.Appointments
                         WHERE AppointmentDate = @AppointmentDate
                         ORDER BY AppointmentID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AppointmentDate", date.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAppointments.DataSource = dt;
                }
            }

            dgvAppointments.Columns["AppointmentID"].Visible = false;
        }

        private void DoctorAppointments_Load(object sender, EventArgs e)
        {
            dtDoctorDate.Value = DateTime.Today;
            LoadAppointmentsByDate(DateTime.Today);
        }






        public ShowAppointment()
        {
            InitializeComponent();



        }



        private void btnView_Click(object sender, EventArgs e)
        {
            LoadAppointmentsByDate(dtDoctorDate.Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
