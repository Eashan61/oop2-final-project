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
    public partial class DeleteAppointment : Form
    {
        string connectionString =
                    @"Data Source=EASHAN-PC\SQLEXPRESS;
                    Initial Catalog=SafePlusDentalDB;
                    Integrated Security=True";
        public DeleteAppointment()
        {
            
            InitializeComponent();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT AppointmentID, PatientName, PhoneNumber, AppointmentDate FROM dbo.Appointments ORDER BY AppointmentDate",
                    con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int appointmentId = Convert.ToInt32(
                dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM dbo.Appointments WHERE AppointmentID = @AppointmentID", con))
            {
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Appointment deleted successfully.",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
    }
}
