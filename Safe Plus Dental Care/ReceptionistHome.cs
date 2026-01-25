using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Plus_Dental_Care
{
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            BookApppointment ba = new BookApppointment();
            ba.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeleteAppointment deleteAppointment = new DeleteAppointment();
            deleteAppointment.Show();
            
        }
    }
}
