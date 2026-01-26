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
    public partial class PrescriptionForm : Form
    {
        string connectionString =
@"Data Source=EASHAN-PC\SQLEXPRESS;
  Initial Catalog=SafePlusDentalDB;
  Integrated Security=True";

        public PrescriptionForm()
        {
            InitializeComponent();
            this.Load += PrescriptionForm_Load;
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            LoadTodayAppointments();
        }

        private void LoadTodayAppointments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AppointmentID, PatientName, PhoneNumber, Gender, BloodGroup
                         FROM dbo.Appointments
                         WHERE CAST(AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)
                         ORDER BY AppointmentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTodayAppointments.DataSource = dt;
            }

            if (dgvTodayAppointments.Columns["AppointmentID"] != null)
                dgvTodayAppointments.Columns["AppointmentID"].Visible = false;
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void dgvTodayAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTodayAppointments.CurrentRow == null)
                return;

            var row = dgvTodayAppointments.CurrentRow;

            tbName.Text = row.Cells["PatientName"].Value?.ToString();
            tbPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
            tbGender.Text = row.Cells["Gender"].Value?.ToString();
            tbBlood.Text = row.Cells["BloodGroup"].Value?.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);

            int x = 50;
            int y = 40;

            e.Graphics.DrawString("SAFE PLUS DENTAL CARE",
                headerFont, Brushes.Black, 180, y);

            y += 50;

            e.Graphics.DrawString("Patient Name: " + tbName.Text, boldFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Phone: " + tbPhone.Text, normalFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Gender: " + tbGender.Text, normalFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Blood Group: " + tbBlood.Text, normalFont, Brushes.Black, x, y);

            y += 40;

            e.Graphics.DrawString("Diagnosis:", boldFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString(tbDiagnosis.Text, normalFont, Brushes.Black,
                new RectangleF(x, y, 700, 100));
            y += 110;

            e.Graphics.DrawString("Medicines:", boldFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString(tbMedicines.Text, normalFont, Brushes.Black,
                new RectangleF(x, y, 700, 120));
            y += 130;

            e.Graphics.DrawString("Advice:", boldFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString(tbAdvice.Text, normalFont, Brushes.Black,
                new RectangleF(x, y, 700, 100));

            y += 120;

            e.Graphics.DrawString("Doctor Signature: _______________________",
                normalFont, Brushes.Black, x, y);
        }
    }
}
