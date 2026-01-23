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
    public partial class BookApppointment : Form
    {
        public BookApppointment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceptionistHome rh = new ReceptionistHome();
            rh.Show();
            this.Close();
        }
    }
}
