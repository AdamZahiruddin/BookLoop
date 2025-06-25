using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComicRentalSystem
{
    public partial class Dashboard : Form
    {

        private SqlConnection connection;
        private string connectionString;

        public Dashboard()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM Renters ";


            using (connection = new SqlConnection(connectionString))
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Renters");

                dgvRent.DataSource = dataSet.Tables["Renters"];
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string idBox = txtBxCustID.Text.Trim();
            string nameBox = txtBxName.Text.Trim();

            string query = "SELECT * FROM Renters ";
            string bookQuery = "SELECT b.Title FROM Rental r JOIN Books b ON r.BookID = b.BookID WHERE CustomerID = @id";

            if(!string.IsNullOrEmpty(nameBox))
            {
                query += "WHERE Name =@name";
            }
            else if(!string.IsNullOrEmpty(idBox))
            {
                query += "WHERE CustomerID = @id";
            }

            using(connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command2 = new SqlCommand(bookQuery, connection);
                command.Parameters.AddWithValue("@id", idBox);
                command.Parameters.AddWithValue ("@name", nameBox);


                command2.Parameters.AddWithValue("@id", idBox);
                connection.Open();
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    string title = reader2["Title"].ToString();
                    lsBxBooks.Items.Add(title);
                }
                else
                {
                    lsBxBooks.Text = "No borrowed books.";
                }
                connection.Close();

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset, "Renters");

                dgvRent.DataSource = dataset.Tables["Renters"];

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string id = reader["CustomerID"].ToString();
                    string name = reader["Name"].ToString();
                    string status = reader["Status"].ToString();
                    txtBxInfo.Text = id + "\n" + name + "\n" + status;
                }
                else
                {
                    txtBxInfo.Text = "Record not found.";
                }

                
            }



        }
    }
}
