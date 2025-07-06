using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ComicRentalSystem
{
    public partial class Rent : Form
    {
        public SqlConnection connection;
        public string selectedGenre;
        public string connectionString;
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
            public static string customerID = "";
            // Extend Form
            //public static string extendDate = "";
            public static string extendFee = "7.00"; // Fee extend
        }

        public Rent(string username)
        {
            InitializeComponent();
            sharedData.username = username;
            welcomeText.Text = "Welcome, " + sharedData.username;

            // ADD YOUR DB SOURCE HERE
            connectionString = "";
            connection = new SqlConnection(connectionString);

            string banCheck = "SELECT Status FROM Renters WHERE Name = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(banCheck, connection))
            {
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string status = (string)result;
                    if (status == "Banned    ")
                    {

                        MessageBox.Show("You are banned from using this system. Please ask for admin to unban your account.");
                        Application.Exit();
                    }
                }
            }



            // Fetch CustomerID based on the provided username
            string query = "SELECT CustomerID FROM Renters WHERE Name = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    sharedData.customerID = result.ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialize the connection object
            // ADD YOUR DB SOURCE HERE
            string connectionString = "";
            //connection = new SqlConnection(connectionString);
            //string query = "SELECT * FROM Books WHERE Title = @title AND BookStatus = 'Available'";
            string query = "SELECT * FROM Books WHERE Title LIKE '%' + @title + '%' AND BookStatus = 'Available'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@title", sharedData.selectedItems);
                //dataAdapter.SelectCommand.Parameters.AddWithValue("@title", "%" + sharedData.selectedItems + "%");

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Books");

                // Get the table from the dataset
                DataTable books = dataSet.Tables["Books"];

                if (books.Rows.Count == 0)
                {
                    MessageBox.Show("Sorry, the book is NOT AVAILABLE.");
                }
                

                string checkRent = "SELECT COUNT(*) FROM Rental r JOIN Renters rs ON r.CustomerID = rs.CustomerID JOIN Books b ON r.BookID = b.BookID WHERE b.Title = @title AND rs.Name = @name";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(checkRent, conn);
                    command.Parameters.AddWithValue("@title", sharedData.selectedItems);
                    command.Parameters.AddWithValue("@name", sharedData.username);

                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    conn.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("This book is already rented by the customer.");
                        return; // Stop the action
                    }
                    else
                    {
                        Payment paymentForm = new Payment();
                        paymentForm.Show();
                        this.Hide();
                    }

                }
            }
        }

           

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                foreach (Control control in groupBox4.Controls) // Control is UI like radio button, checkbox and others
                {
                    // Check if the control is a radio button
                    if (control is System.Windows.Forms.RadioButton radioBtn)
                    {
                        // If it's checked, make it false
                        if (radioBtn.Checked)
                        {
                            //radioBtn.Visible = false;
                            radioBtn.Checked = false;
                        }
                    }
                }


                string mediaType = comboBox1.GetItemText(comboBox1.SelectedItem); // get mediaType
                if (mediaType == "Educational")
                {
                    radioButton1.Text = "Primary"; radioButton1.Visible = true;
                    radioButton2.Text = "Secondary"; radioButton2.Visible = true;
                    radioButton3.Text = "University Research"; radioButton3.Visible = true;
                    radioButton4.Text = "Business"; radioButton4.Visible = true;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                }
                else if (mediaType == "CDs")
                {
                    radioButton1.Text = "Pop"; radioButton1.Visible = true;
                    radioButton2.Text = "Rock"; radioButton2.Visible = true;
                    radioButton3.Text = "HipHop"; radioButton3.Visible = true;
                    radioButton4.Text = "K-Pop"; radioButton4.Visible = true;
                    radioButton5.Text = "Movie OSTs"; radioButton5.Visible = true;
                    radioButton6.Text = "Jazz"; radioButton6.Visible = true;
                }
                else
                {
                    radioButton1.Text = "Fantasy"; radioButton1.Visible = true;
                    radioButton2.Text = "Science Fiction"; radioButton2.Visible = true;
                    radioButton3.Text = "Mystery"; radioButton3.Visible = true;
                    radioButton4.Text = "Historical Fiction"; radioButton4.Visible = true;
                    radioButton5.Text = "Romance"; radioButton5.Visible = true;
                    radioButton6.Text = "Horror"; radioButton6.Visible = true;
                }
                sharedData.mediaType = mediaType;
            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton1.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }
                sharedData.genre = radioButton1.Text; // Set genre from each radio button
            }

            private void radioButton4_CheckedChanged(object sender, EventArgs e)
            {

                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton4.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }

                sharedData.genre = radioButton4.Text; // Set genre from each radio button
            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton2.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }

                sharedData.genre = radioButton2.Text; // Set genre from each radio button
            }

            private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {
                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton3.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }

                sharedData.genre = radioButton3.Text; // Set genre from each radio button
            }

            private void radioButton5_CheckedChanged(object sender, EventArgs e)
            {
                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton5.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }

                sharedData.genre = radioButton5.Text; // Set genre from each radio button
            }

            private void radioButton6_CheckedChanged(object sender, EventArgs e)
            {
                bookComboBox.Items.Clear();
                string query = "SELECT Title FROM Books WHERE Media = @mediaType AND Genre = @genre AND BookStatus = 'Available'";
                selectedGenre = radioButton6.Text; // Set genre from each radio button
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mediaType", sharedData.mediaType);
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookComboBox.Items.Add(reader["Title"].ToString());
                        }
                        conn.Close();
                    }
                }

                sharedData.genre = radioButton5.Text; // Set genre from each radio button
            }

            private void submitBookButton_Click(object sender, EventArgs e)
            {
            // ADD YOUR DB SOURCE HERE
            string connectionString = "";
                connection = new SqlConnection(connectionString);

                // Check all option already choose not blank
                if (sharedData.mediaType == "")
                {
                    MessageBox.Show("Please choose at the media type");
                }
                else if (sharedData.genre == "")
                {
                    MessageBox.Show("Please choose the option at genre");
                    return;
                }
                else if (sharedData.selectedItems == "")
                {
                    MessageBox.Show("Please choose the title of book.");
                }
                //else if(!checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked && !checkBox10.Checked && 
                //        !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked)
                //{
                //    MessageBox.Show("Please choose the option at title");
                //    return;
                //}

                // Check in database whether customer already booked more than 3 items
                int borrowedCount = 0;
                string countQuery = "SELECT COUNT(*) FROM Books WHERE CustomerID = @customerID AND BookStatus = 'Borrowed'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", sharedData.customerID); // Assuming sharedData.customerID is available
                    connection.Open();
                    borrowedCount = (int)command.ExecuteScalar();
                }

                if (borrowedCount >= 3)
                {
                    MessageBox.Show("You cannot book more. You have already made 3 bookings.");
                    return;
                }


                listBox1.Items.Clear(); // Clear first for not error
                listBox1.Items.Add("Media Type: " + sharedData.mediaType);
                listBox1.Items.Add("Genre: " + sharedData.genre);
                listBox1.Items.Add("Title: " + sharedData.selectedItems);
                button1.Enabled = true;


            }

            private void Rent_Load(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Media Type: " + sharedData.mediaType);
                listBox1.Items.Add("Genre: " + sharedData.genre);
                listBox1.Items.Add("Title: " + sharedData.selectedItems);
            }



            private void button2_Click(object sender, EventArgs e)
            {
                new Extend(sharedData.username).Show();
                this.Close();
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                sharedData.selectedItems = bookComboBox.Text;
            }

            private void button3_Click(object sender, EventArgs e)
            {
                Login page = new Login();
                page.Show();
                this.Close();
            }
        }
    }

