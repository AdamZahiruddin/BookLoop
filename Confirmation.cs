using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComicRentalSystem.Rent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ComicRentalSystem
{
    public partial class Confirmation : Form
    {
        private string receipt1, receipt2, price, BookID, CustomerID, deliveryFee = "0.00";
        private string newReceiptId = "", newRentId = "";
        private SqlConnection connection;
        public Confirmation()
        {
            InitializeComponent();
            if (sharedData.mediaType == "Educational")
            {
                price = "12.00";
            }
            else if (sharedData.mediaType == "Novels")
            {
                price = "5.00";
            }
            else if (sharedData.mediaType == "Comics")
            {
                price = "7.00";
            }
            else if (sharedData.mediaType == "Blueray")
            {
                price = "15.00";
            }
            else
            {
                price = "10.00";
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FileName = "Receipt.txt";
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
                }
            }
            this.Close();

            // Get CustomerID
            // Initialize the connection object
            // ADD YOUR DB SOURCE HERE
            string connectionString = "";
            connection = new SqlConnection(connectionString);
            string queryName = "SELECT * FROM Renters WHERE Name = @name";
            string queryBook = "SELECT * FROM Books WHERE Title LIKE '%' + @title + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryName, connection);
                dataAdapter.SelectCommand = new SqlCommand(queryName, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@name", sharedData.username);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Renters");

                // Get the table from the dataset
                DataTable renters = dataSet.Tables["Renters"];

                // Check each row to see if the name matches the textbox
                foreach (DataRow row in renters.Rows)
                {
                    string nameInDb = row["Name"].ToString();
                    if (nameInDb.Equals(sharedData.username, StringComparison.OrdinalIgnoreCase))
                    {
                        CustomerID = row["CustomerID"].ToString();
                        break;
                    }
                }

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(queryBook, connection);
                dataAdapter1.SelectCommand = new SqlCommand(queryBook, connection);
                dataAdapter1.SelectCommand.Parameters.AddWithValue("@title", sharedData.selectedItems);

                DataSet dataSet1 = new DataSet();
                dataAdapter1.Fill(dataSet1, "Books");

                // Get the table from the dataset
                DataTable books = dataSet1.Tables["Books"];

                // Search BookID and RentalStatus (Active, Extended, Completed, Overdue)
                foreach (DataRow row in books.Rows)
                {
                    string titleInDb = row["Title"].ToString();
                    if (titleInDb.Equals(sharedData.selectedItems, StringComparison.OrdinalIgnoreCase))
                    {
                        BookID = row["BookID"].ToString();
                        break;
                    }
                }

                // Step 1: Get last CustomerID
                string lastId = null;
                string getLastIdQuery = "SELECT TOP 1 RentID FROM Rental ORDER BY RentID DESC";

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
                newRentId = $"R{nextNumber:D3}"; // R for RentID

                // Step 3: Insert new user
                string insertQuery = "INSERT INTO Rental (RentID, CustomerID, BookID, RentalStatus) VALUES (@RentID, @CustomerID, @BookID, 'Borrowed')";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    // Insert Data
                    insertCmd.Parameters.AddWithValue("@RentID", newRentId);
                    insertCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    insertCmd.Parameters.AddWithValue("@BookID", BookID);
                    connection.Open();
                    insertCmd.ExecuteNonQuery();
                    connection.Close();
                }
                // Books Table, BookStatus -> Borrowed

                // Update BookStatus
                string updateQuery = "UPDATE Books SET BookStatus = @status, CustomerID = @customerid WHERE BookID = @bookID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@status", "Borrowed");
                    command.Parameters.AddWithValue("@customerid", CustomerID);
                    command.Parameters.AddWithValue("@bookId", BookID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
            }

            // 6. Generate and Insert into Receipt
            string getLastReceiptIdQuery = "SELECT TOP 1 ReceiptID FROM Receipt ORDER BY ReceiptID DESC";
            using (var cmd = new SqlCommand(getLastReceiptIdQuery, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar()?.ToString();
                connection.Close();
                int next = (result != null && result.Length > 2) ? int.Parse(result.Substring(2)) + 1 : 1;
                newReceiptId = $"RC{next:D3}";
            }

            string insertReceiptQuery = @"INSERT INTO Receipt 
            (ReceiptID, rentalStart, rentalEnd, bookingMethod, address, paymentMethod, priceBook, deliveryFee, RentID)
            VALUES 
            (@ReceiptID, @rentalStart, @rentalEnd, @bookingMethod, @address, @paymentMethod, @priceBook, @deliveryFee, @RentID)";
            DateTime rentalStart = DateTime.ParseExact(sharedData.rentalStart, "dddd, d MMMM, yyyy", null);
            DateTime rentalEnd = DateTime.ParseExact(sharedData.rentalEnd, "dddd, d MMMM, yyyy", null);

            using (var cmd = new SqlCommand(insertReceiptQuery, connection))
            {
                cmd.Parameters.AddWithValue("@ReceiptID", newReceiptId);
                cmd.Parameters.AddWithValue("@rentalStart", rentalStart);
                cmd.Parameters.AddWithValue("@rentalEnd", rentalEnd);
                cmd.Parameters.AddWithValue("@bookingMethod", sharedData.bookMethod);
                cmd.Parameters.AddWithValue("@address", sharedData.address);
                cmd.Parameters.AddWithValue("@paymentMethod", sharedData.payMethod);
                cmd.Parameters.AddWithValue("@priceBook", "5.00");
                cmd.Parameters.AddWithValue("@deliveryFee", "2.00");
                cmd.Parameters.AddWithValue("@RentID", newRentId);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close(); // optional but recommended
            }

            connection.Close();

            // Save receipt to file
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

            // ✅ Prompt to book again or exit — PLACE THIS HERE
            DialogResult resultLast = MessageBox.Show(
                "Do you want to make another booking?",
                "Book Again?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultLast == DialogResult.Yes)
            {
                Rent rentForm = new Rent(sharedData.username);
                rentForm.Show();
            }
            else
            {
                Application.Exit();
            }

            // Only close this form if Rent is opening separately
            this.Close();

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            // Make Receipt
            listBox1.Items.Clear();
            listBox1.Items.Add("RECEIPT");
            listBox1.Items.Add("");
            listBox1.Items.Add("=========================");
            listBox1.Items.Add("Customer Name: " + sharedData.username);
            listBox1.Items.Add("Media Type: " + sharedData.mediaType);
            listBox1.Items.Add("Genre: " + sharedData.genre);
            listBox1.Items.Add("Title: " + sharedData.selectedItems);
            listBox1.Items.Add("Rental Start: " + sharedData.rentalStart);
            listBox1.Items.Add("Return Date: " + sharedData.rentalEnd);
            listBox1.Items.Add("Booking Method: " + sharedData.bookMethod);
            if (sharedData.address != "")
            {
                listBox1.Items.Add("Address: " + sharedData.address);
            }
            else
            {
                sharedData.address = "PickUp at BookLoop Store\nA3-102 Taman Subang Nogori, 91102, Shah Alam, Selangor\n";
            }
            // Get payment method
            listBox1.Items.Add("Payment Method: " + sharedData.payMethod);
            listBox1.Items.Add("Price Book: RM " + price);
            listBox1.Items.Add("Delivery Fee (If Yes): RM " + deliveryFee);
            listBox1.Items.Add("=========================");
            listBox1.Items.Add("");
            listBox1.Items.Add("THANK YOU FOR YOUR BOOKING!");
            listBox1.Items.Add("MUAH CIKED FROM BOOKLOOP :)");

            receipt1 = "RECEIPT\n" +
                        "=========================" +
                        "Customer Name: " + sharedData.username + "\n" +
                        "Media Type: " + sharedData.mediaType + "\n" +
                        "Genre: " + sharedData.genre + "\n" +
                        "Title: " + sharedData.selectedItems + "\n" +
                        "Rental Start: " + sharedData.rentalStart + "\n" +
                        "Return Date: " + sharedData.rentalEnd + "\n" +
                        "Booking Method: " + sharedData.bookMethod + "\n";

            if (sharedData.bookMethod == "Delivery")
            {
                deliveryFee = "2.00\n"; // Per book for delivery
            }
            else
            {
                deliveryFee = "0.00\n"; // Zero
            }

            receipt2 = "Address: " + sharedData.address + "\n" +
                        "Payment Method: " + sharedData.payMethod + "\n" +
                        "Price Book: RM " + price + "\n" +
                        "Delivery Fee (If Yes): " + deliveryFee + "\n" +
                        "=========================\n" +
                        "THANK YOU FOR YOUR BOOKING!\n" + "MUAH CIKED FROM BOOKLOOP :)";

            receipt1 = receipt1 + receipt2;

        }
    }
}
