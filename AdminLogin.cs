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
            string adminName = txtBxUsername.Text;
            string adminPassword = txtBxPassword.Text;

            // ADD YOUR DB SOURCE HERE
            string connectionString = "";
            string query = "SELECT COUNT(*) FROM Admin WHERE Name = @name AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", adminName);
                command.Parameters.AddWithValue("@password", adminPassword);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
