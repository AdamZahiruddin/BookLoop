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
            // ADD YOUR DB SOURCE HERE
            connectionString = "";
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
            string bookQuery = @"SELECT DISTINCT b.Title FROM Books b JOIN Rental r ON r.BookID = b.BookID JOIN Renters rs ON r.CustomerID = rs.CustomerID WHERE rs.CustomerID LIKE @id OR rs.Name LIKE @name";


            if (!string.IsNullOrEmpty(nameBox))
            {
                query += "WHERE Name LIKE @name";
            }
            else if(!string.IsNullOrEmpty(idBox))
            {
                query += "WHERE CustomerID LIKE @id";
            }

            using(connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command2 = new SqlCommand(bookQuery, connection);
                command.Parameters.AddWithValue("@id", "%" + idBox + "%");
                command.Parameters.AddWithValue ("@name", "%" + nameBox + "%");


                command2.Parameters.AddWithValue("@id", "%" + idBox + "%");
                command2.Parameters.AddWithValue("@name", "%" + nameBox + "%");
                connection.Open();

                SqlDataReader reader2 = command2.ExecuteReader();
                listBox1.Items.Clear();
                if (reader2.Read())
                {
                    listBox1.Items.Add(reader2["Title"].ToString());
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("No borrowed books");
                }
                reader2.Close();
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
                    txtBxInfo.Text = id + Environment.NewLine + name + Environment.NewLine + status;
                }
                else
                {
                    txtBxInfo.Text = "Record not found.";
                }

                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBxCustID.Text = string.Empty;
            listBox1.Items.Clear();
            txtBxName.Text = string.Empty;
            loadData();
        }
    }
}
