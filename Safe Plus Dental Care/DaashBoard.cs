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
    

    public partial class DaashBoard : Form
    {
        string connectionString =
@"Data Source=EASHAN-PC\SQLEXPRESS;
  Initial Catalog=SafePlusDentalDB;
  Integrated Security=True";

        List<AppointmentItem> todayQueue = new List<AppointmentItem>();
        int currentIndex = 0;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadTodayAppointments();
        }

        private void RefreshDashboard()
        {
            // Chair 1
            lb1chair.Text = currentIndex < todayQueue.Count
                ? todayQueue[currentIndex].PatientName
                : "Empty";

            // Chair 2
            lb2chair.Text = (currentIndex + 1) < todayQueue.Count
                ? todayQueue[currentIndex + 1].PatientName
                : "Empty";

            // Up Next (after two chairs)
            var upNextList = todayQueue.Skip(currentIndex + 2).ToList();

            dgvUpNext.DataSource = null;
            dgvUpNext.DataSource = upNextList;
        }


        private void LoadTodayAppointments()
        {
            todayQueue.Clear();
            currentIndex = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AppointmentID, PatientName
                         FROM dbo.Appointments
                         WHERE CAST(AppointmentDate AS DATE) = CAST(GETDATE() AS DATE)
                         ORDER BY AppointmentID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    todayQueue.Add(new AppointmentItem
                    {
                        AppointmentID = Convert.ToInt32(row["AppointmentID"]),
                        PatientName = row["PatientName"].ToString()
                    });
                }
            }

            RefreshDashboard();
        }


        public DaashBoard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void btn2next_Click(object sender, EventArgs e)
        {
            if (currentIndex + 2 >= todayQueue.Count)
            {
                MessageBox.Show("No more patients in queue.");
                return;
            }

            currentIndex++;
            RefreshDashboard();


        }
    }
}
