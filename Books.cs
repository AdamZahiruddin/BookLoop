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
    public partial class Books : Form
    {
        private SqlConnection connection;
        private string connectionString;
        public Books()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Github\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";

        }

        private void Books_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM Books ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Books");

                dgvBooks.DataSource = dataSet.Tables["Books"];
            }
        }

        private void chkBxBorrowed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void chkBxAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBookID_Click(object sender, EventArgs e)
        {
            string idBox = txtBxBookID.Text.Trim();

            string query = "SELECT * FROM Books WHERE BookID = @id ";

            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idBox);

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset, "Books");

                dgvBooks.DataSource = dataset.Tables["Books"];


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string media = reader["Media"].ToString();
                    string genre = reader["Genre"].ToString();
                    string author = reader["Author"].ToString();
                    string publisher = reader["Publisher"].ToString();
                    string publishDate = reader["PublishDate"].ToString();
                    string bookStatus = reader["BookStatus"].ToString();
                    textBox1.Text = title + "\n" + media + "\n" + genre + "\n" + author + "\n" + publisher + "\n" + publishDate + "\n" + bookStatus;
                }
                else
                {
                    textBox1.Text = "No book information.";
                }
                connection.Close();






            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                List<string> selectedGenres = new List<string>();
                List<string> selectedMedias = new List<string>();


                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        selectedGenres.Add(checkBox.Text); // or checkBox.Name if needed
                    }
                }

                foreach (Control control in groupBox3.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        selectedMedias.Add(checkBox.Text); // or checkBox.Name if needed
                    }
                }

                string genre = selectedGenres[0];
                string media = selectedMedias[0];

                // Get the latest ID
                connection = new SqlConnection(connectionString);
                string idquery = "SELECT TOP 1 BookID FROM Books ORDER BY BookID DESC";
                SqlCommand cmd = new SqlCommand(idquery, connection);
                connection.Open();
                string latestId = (string)cmd.ExecuteScalar();

                string newId;
                if (latestId != null)
                {
                    int number = int.Parse(latestId.Substring(1,3)); // get number part
                    newId = "B" + (number + 1).ToString("D3"); // USR004 ➝ USR005
                }
                else
                {
                    newId = "B001";
                }

                string dateOnly = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                // testing purpose
                Console.WriteLine(latestId + " " + newId + " " + dateOnly);



                string query = "INSERT INTO Books (BookID, Title, Media, Genre, Author, Publisher, PublishDate, BookStatus) VALUES (@id, @title, @media, @genre, @author, @publisher, @publishdate, 'Available')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", newId);
                    command.Parameters.AddWithValue("@title", txtBxTitle.Text);
                    command.Parameters.AddWithValue("@media", media);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@author", txtBxAuthor.Text);
                    command.Parameters.AddWithValue("@publisher",txtBxPublisher.Text);
                    command.Parameters.AddWithValue("@publishdate",dateOnly);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                loadData();
                clearText();
            }
        }

        private void clearText()
        {
            textBox1.Text = string.Empty;
            txtBxBookID.Text = string.Empty;
            txtBxTitle.Text = string.Empty;
            txtBxAuthor.Text = string.Empty;
            txtBxPublisher.Text = string.Empty;
            txtBxAuthor.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private bool ValidateInputs() 
        {
            if (string.IsNullOrEmpty(txtBxTitle.Text) || string.IsNullOrEmpty(txtBxAuthor.Text) || string.IsNullOrEmpty(txtBxPublisher.Text)
                || string.IsNullOrEmpty(txtBxAuthor.Text))
            {
                MessageBox.Show("Please fill in all details first.");
                clearText();
                return false;
            }

            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("A book published date should be before today.");
                return false;
            }

            if (!string.IsNullOrEmpty(txtBxBookID.Text))
            {
                string bookId = txtBxBookID.Text.Trim();

                string checkQuery = "SELECT COUNT(*) FROM Books WHERE BookID = @bookId";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Book ID already exists. Please use a unique ID.");
                        return false;
                    }
                }
            }



            return true;

            }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string idBox = txtBxRemoveBookID.Text.Trim();
            string nameBox = txtBxRemoveBookTitle.Text.Trim();

            connection = new SqlConnection(connectionString);

            string query = "DELETE FROM Books WHERE BookID = @id ";
            string query2 = "DELETE FROM Books WHERE Title = @title ";
            connection.Open();


            

                if (!string.IsNullOrEmpty(idBox))
                {
                    using(SqlCommand command =  new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idBox);
                    command.ExecuteNonQuery();


                }


            }

                if (string.IsNullOrEmpty(nameBox))
                {
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@title", nameBox);
                    command2.ExecuteNonQuery();

                }


            }

                connection.Close();
                loadData();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> bookStatus = new List<string>();


            foreach (Control control in grpBx1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    bookStatus.Add(checkBox.Text); // or checkBox.Name if needed
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    bookStatus.Add(checkBox.Text); // or checkBox.Name if needed
                }
            }

            string genre = bookStatus[0];

            connection = new SqlConnection(connectionString);
            string query = "UPDATE Books SET BookStatus = @status WHERE BookID = @id";
            using (SqlCommand  cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@status", genre);
                cmd.Parameters.AddWithValue("@id",txtBxBookID.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                loadData();
            }
        }
    }
}
