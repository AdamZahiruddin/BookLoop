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
using static ComicRentalSystem.Rent;

namespace ComicRentalSystem
{
    public partial class Extend : Form
    {
        private string username;
        public static class sharedData
        {
            // This is for sharing data any other form
            // From Form Rent
            public static string username = "";
            public static string mediaType = "";
            public static string genre = "";
            public static string selectedItems = "";
            // From Form Payment
            public static string rentalStart = "";
            public static string rentalEnd = "";
            public static string bookMethod = "";
            public static string payMethod = "";
            public static string address = "";
        }
        public Extend(string username)
        {
            InitializeComponent();
            sharedData.username = username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            string query = $"SELECT * FROM Rental JOIN Books ON Rental.BookID = Books.BookID JOIN Renters ON Rental.CustomerID = Renters.CustomerID WHERE Name = '{sharedData.username}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Title"].ToString());
                }
                reader.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Terms().Show();
            this.Close();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = listBox1.SelectedIndex.ToString();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
            string query = $"SELECT * FROM Rental JOIN Books ON Rental.BookID = Books.BookID JOIN Renters ON Rental.CustomerID = Renters.CustomerID WHERE Name = '{sharedData.username}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Title"].ToString());
                }
                reader.Close();
            }
        }
    }
}
