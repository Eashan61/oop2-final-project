using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Plus_Dental_Care
{
    public partial class BillingForm : Form
    {
        int selectedAppointmentId = 0;

        private bool _isLoadingAppointments = false;


        string connectionString =
            @"Data Source=EASHAN-PC\SQLEXPRESS;
              Initial Catalog=SafePlusDentalDB;
              Integrated Security=True";

        public BillingForm()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void BillingForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BillingForm_Load fired");
            LoadAppointments();


            MessageBox.Show("Billing form loaded");

        }

        // ================= LOAD APPOINTMENTS =================
        private void LoadAppointments()
        {
            _isLoadingAppointments = true; 

            dgvAppointments.DataSource = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AppointmentID,
                                PatientName,
                                PhoneNumber,
                                Gender,
                                BloodGroup
                         FROM dbo.Appointments
                         WHERE CAST(AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)
                         ORDER BY AppointmentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAppointments.DataSource = dt;
            }

            if (dgvAppointments.Columns.Contains("AppointmentID"))
                dgvAppointments.Columns["AppointmentID"].Visible = false;

            dgvAppointments.ClearSelection();

            _isLoadingAppointments = false; 

        }

        // ================= SERVICE SELECTION =================
        private void comService_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal charge = 0;

            switch (comService.SelectedItem.ToString())
            {
                case "Dental Checkup":
                    charge = 500;
                    break;
                case "Tooth Extraction":
                    charge = 1500;
                    break;
                case "Root Canal":
                    charge = 5000;
                    break;
                case "Teeth Cleaning":
                    charge = 2000;
                    break;
            }

            tbServiceCharge.Text = charge.ToString("0.00");
            tbTotal.Text = charge.ToString("0.00");
        }

        // ================= SAVE BILL =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == 0)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            if (comService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AppointmentID,
                        PatientName,
                        PhoneNumber,
                        Gender,
                        BloodGroup
                 FROM dbo.Appointments
                 WHERE CAST(AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)";




                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Today", SqlDbType.Date).Value = DateTime.Today;



                cmd.Parameters.AddWithValue("@AppointmentID", selectedAppointmentId);
                cmd.Parameters.AddWithValue("@PatientName", tbName.Text);
                cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@Service", comService.Text);
                cmd.Parameters.AddWithValue("@Charge", tbServiceCharge.Text);
                cmd.Parameters.AddWithValue("@Total", tbTotal.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Bill saved successfully.");
        }

        // ================= PRINT BUTTON =================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // ================= PRINT CONTENT =================
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 14, FontStyle.Bold);

            int x = 50, y = 50;

            e.Graphics.DrawString("SAFE PLUS DENTAL CARE",
                new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 180, y);

            y += 50;
            e.Graphics.DrawString("Patient Name: " + tbName.Text, font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Phone: " + tbPhone.Text, font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Service: " + comService.Text, font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Charge: " + tbServiceCharge.Text + " BDT", font, Brushes.Black, x, y);
            y += 40;

            e.Graphics.DrawString("TOTAL: " + tbTotal.Text + " BDT", bold, Brushes.Black, x, y);
        }

        // ================= BACK =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Row selected: " + dgvAppointments.SelectedRows.Count);
        }

        private void BillingForm_Load_1(object sender, EventArgs e)
        {
            LoadAppointments();

        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            //  Ignore events while loading
            if (_isLoadingAppointments)
                return;

            //  Nothing selected
            if (dgvAppointments.CurrentRow == null)
                return;

            //  Ignore new/invalid rows
            if (dgvAppointments.CurrentRow.Index < 0)
                return;

            DataGridViewRow row = dgvAppointments.CurrentRow;

            //  SAFE access (NO indexes)
            selectedAppointmentId = Convert.ToInt32(row.Cells["AppointmentID"].Value);

            tbName.Text = row.Cells["PatientName"].Value?.ToString();
            tbPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
            tbGender.Text = row.Cells["Gender"].Value?.ToString();
            tbBlood.Text = row.Cells["BloodGroup"].Value?.ToString();

        }
    }
}