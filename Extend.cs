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
        public Extend(string username)
        {
            InitializeComponent();
            sharedData.username = username;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // ADD YOUR DB SOURCE HERE
            string connectionString = "";
            string query = @"
            SELECT DISTINCT Books.Title 
            FROM Rental 
            INNER JOIN Books ON Rental.BookID = Books.BookID 
            INNER JOIN Renters ON Rental.CustomerID = Renters.CustomerID 
            WHERE Renters.Name = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", sharedData.username);
                SqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Title"].ToString());
                }
                reader.Close();
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                sharedData.selectedItems = listBox1.SelectedItem.ToString();
                // ADD YOUR DB SOURCE HERE
                string connectionString = "";

                string query = @"
            SELECT TOP 1 Receipt.rentalEnd 
            FROM Receipt
            INNER JOIN Rental ON Receipt.RentID = Rental.RentID
            INNER JOIN Books ON Rental.BookID = Books.BookID
            INNER JOIN Renters ON Rental.CustomerID = Renters.CustomerID
            WHERE Renters.Name = @Username AND Books.Title = @Title
            ORDER BY Receipt.rentalEnd DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", sharedData.username);
                    cmd.Parameters.AddWithValue("@Title", sharedData.selectedItems);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime originalEnd = Convert.ToDateTime(reader["rentalEnd"]);
                        DateTime extendedEnd = originalEnd.AddDays(7);

                        // ✅ Set values to DateTimePickers
                        dateTimePickerOriginal.Value = originalEnd;
                        dateTimePickerExtended.Value = extendedEnd;

                        // Optional: store in sharedData if needed
                        sharedData.rentalStart = originalEnd.ToString("dddd, d MMMM, yyyy");
                        sharedData.rentalEnd = extendedEnd.ToString("dddd, d MMMM, yyyy");
                    }
                    else
                    {
                        MessageBox.Show("No receipt found for this book.");
                    }

                    reader.Close();
                }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            new ExtendConfirm().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check if a book is selected
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book from the list first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button3.Enabled = false;
                return;
            }

            // Check if any radio button is checked
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please choose a payment method.", "Missing Duration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button3.Enabled = false;
                return;
            }

            // All conditions met — enable the proceed button
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rent page = new Rent(sharedData.username);
            page.Show();
            this.Close();
        }
    }
}
