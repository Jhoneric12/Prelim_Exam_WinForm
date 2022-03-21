using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelim_Exam_Aton
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Verify the username and password
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                timer1.Enabled = true;
            }
            else
            {
                DialogResult dialogRes = MessageBox.Show("Invalid Credentials, Try Again?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogRes == DialogResult.Yes)
                {
                    this.Hide();
                    LogIn login = new LogIn();
                    login.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            pbLoading.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Progressbar
            pbLoading.Value = pbLoading.Value + 5;
            lblLoad.Text = pbLoading.Value + "%";

            if (pbLoading.Value == 100)
            {
                Ordering order = new Ordering();
                order.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
