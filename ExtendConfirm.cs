using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComicRentalSystem.Rent;

namespace ComicRentalSystem
{
    public partial class ExtendConfirm : Form
    {
        public ExtendConfirm()
        {
            InitializeComponent();
        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            // ADD YOUR DB SOURCE HERE
            string connectionString = "";

            string updateQuery = @"
UPDATE Receipt
SET rentalEnd = @newReturnDate
WHERE RentID IN (
    SELECT Rental.RentID
    FROM Rental
    INNER JOIN Books ON Rental.BookID = Books.BookID
    INNER JOIN Renters ON Rental.CustomerID = Renters.CustomerID
    WHERE Renters.Name = @username AND Books.Title = @title
)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@newReturnDate", DateTime.Parse(sharedData.rentalEnd.ToString()));
                cmd.Parameters.AddWithValue("@username", sharedData.username);
                cmd.Parameters.AddWithValue("@title", sharedData.selectedItems);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Build the receipt string from listBox1 items
            StringBuilder sb = new StringBuilder();
            foreach (var item in listBox1.Items)
            {
                sb.AppendLine(item.ToString());
            }
            string receipt1 = sb.ToString();

            // Save receipt to file using SaveFileDialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Receipt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FileName = $"Receipt_{sharedData.username}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, receipt1);
                    MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Login page = new Login();
            page.Show();
            this.Close();
            
        }

        private void ExtendConfirm_Load(object sender, EventArgs e)
        {
            //string selectedTitle = listBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add("EXTENDED RECEIPT");
            listBox1.Items.Add("=========================");
            listBox1.Items.Add("Customer Name: " + sharedData.username);
            listBox1.Items.Add("Title: " + sharedData.selectedItems);
            listBox1.Items.Add("Original Return Date: " + sharedData.rentalStart);
            listBox1.Items.Add("New Return Date: " + sharedData.rentalEnd);
            listBox1.Items.Add("Extension Fee: RM 7.00");
            listBox1.Items.Add("=========================");
            listBox1.Items.Add("THANK YOU FOR EXTENDING!");
        }
    }
    }
