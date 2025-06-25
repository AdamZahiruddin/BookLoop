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
    public partial class Addmin : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet dataset;
        private string connectionString;
        public Addmin()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        private void Addmin_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string query = "SELECT * from Admin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Admin");

                dgvBooks.DataSource = dataSet.Tables["Admin"];
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Get the latest ID
            conn = new SqlConnection(connectionString);
            string idquery = "SELECT TOP 1 AdminID FROM Admin ORDER BY AdminID DESC";
            SqlCommand cmd = new SqlCommand(idquery, conn);
            conn.Open();
            string latestId = (string)cmd.ExecuteScalar();

            string newId;
            if (latestId != null)
            {
                int number = int.Parse(latestId.Substring(1, 3)); // get number part
                newId = "A" + (number + 1).ToString("D3"); // USR004 ➝ USR005
            }
            else
            {
                newId = "A001";
            }

            string query = "INSERT INTO Admin (AdminID,Name) VALUES (@id,@name)";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@id", newId);
                command.Parameters.AddWithValue("@name", txtBxAdminName.Text);

                command.ExecuteNonQuery();
                conn.Close();
            }
            load_data();
        }
    }
}
