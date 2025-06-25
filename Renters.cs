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
    public partial class Renters : Form

    {
        private SqlConnection connection;
        private string connectionString;

        public Renters()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Renters_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM Renters ";

            using (connection)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Renters");

                dgvRenters.DataSource = dataSet.Tables["Renters"];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Renters SET Status = 'Banned' WHERE CustomerID = @id";
            connection = new SqlConnection(connectionString);
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@id", textBox1.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            loadData();
            clearText();

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string idBox = textBox1.Text.Trim();

            string query = "SELECT * FROM Renters WHERE CustomerID = @id ";


            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idBox);


                

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset, "Renters");

                dgvRenters.DataSource = dataset.Tables["Renters"];

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string id = reader["CustomerID"].ToString();
                    string name = reader["Name"].ToString();
                    string status = reader["Status"].ToString();
                    string email = reader["Email"].ToString();
                    txtBxDetails.Text = id + "\n" + name + "\n" + email + "\n" + status;
                }
                else
                {
                    txtBxDetails.Text = "Record not found.";
                }
                connection.Close();


            }
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            string checkStatus = "SELECT Status FROM Renters WHERE CustomerID=@id";
            connection = new SqlConnection(connectionString);

            using(SqlCommand command = new SqlCommand(checkStatus,connection))
            {
                command.Parameters.AddWithValue("@id", textBox1.Text);

                connection.Open();
                object result = command.ExecuteScalar();
                string status = result.ToString();
                if (status == "Banned    ")
                {
                    Console.WriteLine(status);
                        string query = "UPDATE Renters SET Status = 'Active' WHERE CustomerID = @id";
                        using(SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@id",textBox1.Text);
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("User status changed successfully");
                    loadData();
                    clearText();

                }
                else
                {
                    Console.WriteLine(status);
                    MessageBox.Show("Error: User is not banned.");
                }
            }
        }

        private void clearText()
        {
            textBox1.Text = string.Empty;
            txtBxDetails.Text = string.Empty;
        }
    }
}
