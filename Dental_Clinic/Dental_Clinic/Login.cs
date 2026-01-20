using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedIndex > 0)
                {
                    if(textUsername.Text==String.Empty)
                    {
                        textUsername.Focus();
                        return;
                    }
                    if(txtPass.Text==String.Empty)
                    {
                        txtPass.Focus();
                        return;
                    }
                    if(cmbRole.SelectedIndex > 0 && textUsername.Text != String.Empty && txtPass.Text != String.Empty)
                    {
                        //database connection for login
                    }
                    else
                    {
                        MessageBox.Show("Login Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cmbRole.SelectedIndex = 0;
                        textUsername.Clear();
                        txtPass.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter UserName or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmbRole.SelectedIndex = 0;
                    textUsername.Clear();
                    txtPass.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
