using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicRentalSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminSubmit_Click(object sender, EventArgs e)
        {
            string adminPassword = txtBxPassword.Text;
            if(adminPassword == "1234")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
