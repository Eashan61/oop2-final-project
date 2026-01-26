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
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            BookApppointment ba = new BookApppointment();
            ba.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeleteAppointment deleteAppointment = new DeleteAppointment();
            deleteAppointment.Show();
            
        }

        private void btnGenBill_Click(object sender, EventArgs e)
        {
            

            BillingForm billForm = new BillingForm();
            billForm.Show();

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DaashBoard daashBoard = new DaashBoard();
            daashBoard.Show();
        }
    }
}
