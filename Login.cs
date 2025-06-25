using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicRentalSystem
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        public string username;
        private bool found;
        public Login()
        {
            InitializeComponent();

            // Initialize the form and its components
            this.Text = "Comic Rental System";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
       
            this.BackColor = Color.PeachPuff;
            this.Font = new Font("Arial", 10, FontStyle.Regular);
            btnLoginNext.MouseEnter += btnLoginNext_MouseEnter;
            btnLoginNext.MouseLeave += btnLoginNext_MouseLeave;
            btnLoginNext.FlatStyle = FlatStyle.Flat;
            btnLoginNext.FlatAppearance.BorderSize = 3;
            btnLoginNext.FlatAppearance.MouseOverBackColor = Color.BurlyWood; // Optional: matches your MouseEnter handler
            btnLoginNext.BackColor = Color.PeachPuff; 
        }

        // Pseudocode:
        // 1. Handle the MouseEnter event for the button.
        // 2. In the event handler, set the button's BackColor property to the desired color.
        // 3. Optionally, handle MouseLeave to revert the color.

        // Example implementation for a button named btnLoginNext:

        private void btnLoginNext_MouseEnter(object sender, EventArgs e)
        {}

        private void btnLoginNext_MouseLeave(object sender, EventArgs e)
        {}


        private void btnLoginNext_Click(object sender, EventArgs e)
        {
            username = txtName.Text;
            // Initialize the connection object
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Renters WHERE Name LIKE @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@username", "%" + username + "%");

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Renters");

                // Get the table from the dataset
                DataTable renters = dataSet.Tables["Renters"];
                found = false;

                // Check each row to see if the name matches the textbox
                foreach (DataRow row in renters.Rows)
                {
                    string nameInDb = row["Name"].ToString();
                    if (nameInDb.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your name and email.");
                return;
            }
            else
            {
                if (username == "admin")
                {
                    AdminLogin admLogin = new AdminLogin();
                    admLogin.MdiParent = this.MdiParent;
                    admLogin.Dock = DockStyle.Fill;
                    admLogin.Show();
                    this.Hide();
                }
                else if (found)
                {
                    Rent form2 = new Rent(username);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No match found. Make new one");
                    NewUser newUser = new NewUser();
                    newUser.Show();
                    this.Hide();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true; 
        }
    }   
}
