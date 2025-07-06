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
            // ADD YOUR DB SOURCE HERE
            connectionString = "";

        }

        private void Books_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM Books Order By BookID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Books");

                dgvBooks.DataSource = dataSet.Tables["Books"];
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBookID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxBookID.Text))
            {
                MessageBox.Show("Please fill in the field");
                return;
            }
            string idBox = txtBxBookID.Text.Trim();

            // new
            string query = "SELECT * FROM Books WHERE BookID LIKE @text OR Title LIKE @text ";

            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // new
                command.Parameters.AddWithValue("@text","%" + idBox + "%");

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset, "Books");

                dgvBooks.DataSource = dataset.Tables["Books"];

            }
        }

        // new
        private int checkGenreLimit(string genre)
        {
            // ADD YOUR DB SOURCE HERE
            connectionString = "";
            int genreCount = 0;
            string query = "SELECT COUNT(Genre) FROM BOOKS WHERE Genre = @genre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@genre", genre);

                connection.Open ();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    genreCount = Convert.ToInt32 (result); 
                }
            }

            return genreCount;
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
                        selectedMedias.Add(checkBox.Text); // or checkBox.Name if needed
                    }
                }

                foreach (Control control in groupBox3.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        selectedGenres.Add(checkBox.Text); // or checkBox.Name if needed
                    }
                }

               

                string genre = selectedGenres[0];
                string media = selectedMedias[0];

                // new
                int genreCount = checkGenreLimit(genre);

                if (genreCount >= 7)
                {
                    MessageBox.Show("This genre has reached maximum of 7 books!");
                    loadData();
                    return;
                }

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
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@media", media);
                    command.Parameters.AddWithValue("@author", txtBxAuthor.Text);
                    command.Parameters.AddWithValue("@publisher",txtBxPublisher.Text);
                    command.Parameters.AddWithValue("@publishdate",dateOnly);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                loadData();
            }
        }

        private void clearText()
        {
            txtBxBookID.Text = string.Empty;
            txtBxTitle.Text = string.Empty;
            txtBxAuthor.Text = string.Empty;
            txtBxPublisher.Text = string.Empty;
            txtBxAuthor.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            foreach (Control control in groupBox1.Controls)
            {
                // Check if the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                // Check if the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
            foreach (Control control in groupBox3.Controls)
            {
                // Check if the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
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

            int mediaChecks = groupBox1.Controls.OfType<CheckBox>().Count(cb => cb.Checked);
            int genreChecks = groupBox3.Controls.OfType<CheckBox>().Count( cb => cb.Checked);

            if ( mediaChecks != 1)
            {
                MessageBox.Show("Only one media can be selected.");
                return false;
            }

            if (genreChecks != 1)
            {
                MessageBox.Show("Only one genre can be selected.");
                return false;
            }

            return true;

            }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxRemoveBookID.Text))
            {
               
                    MessageBox.Show("Please fill in the field.");
                    return;
                
            }
            string idBox = txtBxRemoveBookID.Text.Trim();

            connection = new SqlConnection(connectionString);

            string query = "DELETE FROM Books WHERE BookID = @id ";
            connection.Open();
                if (!string.IsNullOrEmpty(idBox))
                {
                    using(SqlCommand command =  new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idBox);
                    command.ExecuteNonQuery();


                }


                }

                connection.Close();
            // new
            MessageBox.Show("Book successfully deleted"); 
            clearText();
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

            if(grpBx1.Controls.OfType<CheckBox>().Count(cb => cb.Checked) > 1)
            {
                MessageBox.Show("You can only add one status to the book!");
                return;
            }

            string genre = bookStatus[0];

            connection = new SqlConnection(connectionString);
            string query = "UPDATE Books SET BookStatus = @status WHERE BookID LIKE @id OR Title LIKE @id";
            using (SqlCommand  cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@status", genre);
                cmd.Parameters.AddWithValue("@id","%" + txtBxBookID.Text + "%");
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                loadData();
            }
        }

        // new
        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
            loadData();
        }

        // new
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxRemoveBookTitle.Text))
            {
                MessageBox.Show("Please fill in the field.");
                return;
            }
            string query = "SELECT * FROM Books WHERE BookID LIKE @text OR Title LIKE @text ";

            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@text", "%" + txtBxRemoveBookTitle.Text.Trim() + "%");

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                dataadapter.Fill(dataset, "Books");

                dgvBooks.DataSource = dataset.Tables["Books"];


                clearText();






            }
        }

        // new
        private void button3_Click(object sender, EventArgs e)
        {
            clearText();
            loadData();
        }
    }
}
