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
using System.Windows.Markup;

namespace ComicRentalSystem
{
    public partial class NewUser : Form
    {
        private SqlConnection connection;
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnUserSubmit_Click(object sender, EventArgs e)
        {

            // Initialize the connection object
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Github\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            // Step 1: Get last CustomerID
            string lastId = null;
            string getLastIdQuery = "SELECT TOP 1 CustomerID FROM Renters ORDER BY CustomerID DESC";

            using (SqlCommand getIdCmd = new SqlCommand(getLastIdQuery, connection))
            {
                connection.Open();
                object result = getIdCmd.ExecuteScalar();
                connection.Close();

                if (result != null)
                    lastId = result.ToString();
            }

            // Step 2: Generate next ID
            int nextNumber = 1;
            if (!string.IsNullOrEmpty(lastId) && lastId.Length > 1)
            {
                int.TryParse(lastId.Substring(1), out nextNumber);
                nextNumber++;
            }
            string newCustomerId = $"C{nextNumber:D3}";

            // Step 3: Insert new user
            string insertQuery = "INSERT INTO Renters (CustomerID, Name, Email, Status) VALUES (@CustomerID, @Name, @Email, @Status)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
            {
                insertCmd.Parameters.AddWithValue("@CustomerID", newCustomerId);
                insertCmd.Parameters.AddWithValue("@Name", txtName.Text);
                insertCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                insertCmd.Parameters.AddWithValue("@Status", "Available");

                connection.Open();
                insertCmd.ExecuteNonQuery();
                connection.Close();
            }


            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
