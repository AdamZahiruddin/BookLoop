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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ComicRentalSystem
{
    public partial class Rent : Form
    {
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

        public Rent(string username)
        {
            InitializeComponent();
            sharedData.username = username;
            welcomeText.Text = "Welcome, " + sharedData.username;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialize the connection object
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohda\\source\\repos\\BookLoop\\BookLoopDB.mdf;Integrated Security=True";
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

                if (books.Rows.Count > 0)
                {
                    Payment paymentForm = new Payment();
                    paymentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry, the book is NOT AVAILABLE.");
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
                        radioBtn.Visible = false;
                    }
                }
            }
            foreach (Control control in groupBox1.Controls) // Control is UI like radio button, checkbox and others
            {
                // Check if the control is a checkbox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    // If it's visible, make it false
                    if (checkBox.Visible)
                    {
                        checkBox.Visible = false;
                    }
                }
            }

            string mediaType = comboBox1.GetItemText(comboBox1.SelectedItem); // get mediaType
            if(mediaType == "Educational")
            {
                radioButton1.Text = "Primary";              radioButton1.Visible = true;
                radioButton2.Text = "Secondary";            radioButton2.Visible = true;
                radioButton3.Text = "University Research";  radioButton3.Visible = true;
                radioButton4.Text = "Business";             radioButton4.Visible = true;
                                                            radioButton5.Visible = false;
                                                            radioButton6.Visible = false;
            }
            else if (mediaType == "CDs")
            {
                radioButton1.Text = "Pop";          radioButton1.Visible = true;
                radioButton2.Text = "Rock";         radioButton2.Visible = true;
                radioButton3.Text = "HipHop";       radioButton3.Visible = true;
                radioButton4.Text = "K-Pop";        radioButton4.Visible = true;
                radioButton5.Text = "Movie OSTs";   radioButton5.Visible = true;
                radioButton6.Text = "Jazz";         radioButton6.Visible = true;
            }
            else
            {
                radioButton1.Text = "Fantasy";              radioButton1.Visible = true;
                radioButton2.Text = "Science Fiction";      radioButton2.Visible = true;
                radioButton3.Text = "Mystery";        radioButton3.Visible = true;
                radioButton4.Text = "Historical Fiction";   radioButton4.Visible = true;
                radioButton5.Text = "Romance";              radioButton5.Visible = true;
                radioButton6.Text = "Horror";               radioButton6.Visible = true;
            }
            sharedData.mediaType = mediaType;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(sharedData.mediaType == "Educational")
            {
                checkBox7.Text = "The Magic School Bus Inside the Human Body"; checkBox7.Visible = true;
                checkBox8.Text = "National Geographic Kids Almanac";           checkBox8.Visible = true;
                checkBox9.Text = "Charlotte’s Web";                            checkBox9.Visible = true;
                checkBox10.Text = "The Boy Who Harnessed the Wind";            checkBox10.Visible = true;
                checkBox11.Text = "Brain Games for Kids";                      checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "The Name of the Wind"; checkBox7.Visible = true;
                checkBox8.Text = "The Hobbit"; checkBox8.Visible = true;
                checkBox9.Text = "The Night Circus"; checkBox9.Visible = true;
                checkBox10.Text = "A Wizard of Earthsea"; checkBox10.Visible = true;
                checkBox11.Text = "Six of Crows"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "Sandman"; checkBox7.Visible = true;
                checkBox8.Text = "Saga"; checkBox8.Visible = true;
                checkBox9.Text = "Monstress"; checkBox9.Visible = true;
                checkBox10.Text = "Fables"; checkBox10.Visible = true;
                checkBox11.Text = "Bone"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Pan’s Labyrinth"; checkBox7.Visible = true;
                checkBox8.Text = "Harry Potter: 8-Film Collection"; checkBox8.Visible = true;
                checkBox9.Text = "The NeverEnding Story"; checkBox9.Visible = true;
                checkBox10.Text = "Avatar: The Way of Water"; checkBox10.Visible = true;
                checkBox11.Text = "The Lord of the Rings Trilogy"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "Backstreet Boys (Millennium)"; checkBox7.Visible = true;
                checkBox8.Text = "Westlife (Coast to Coast)"; checkBox8.Visible = true;
                checkBox9.Text = "Michael Jackson (Thriller)"; checkBox9.Visible = true;
                checkBox10.Text = "Taylor Swift (1989 Taylor’s Version)"; checkBox10.Visible = true;
                checkBox11.Text = "Lady Gaga (Born This Way)"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton1.Text; // Set genre from each radio button
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (sharedData.mediaType == "Educational")
            {
                checkBox7.Text = "The Making of a Manager"; checkBox7.Visible = true;
                checkBox8.Text = "You Owe You"; checkBox8.Visible = true;
                checkBox9.Text = "Crossing the Chasm"; checkBox9.Visible = true;
                checkBox10.Text = "The Lean Startup"; checkBox10.Visible = true;
                checkBox11.Text = "The Founder's Dilemmas"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "Wolf Hall"; checkBox7.Visible = true;
                checkBox8.Text = "The Book Thief"; checkBox8.Visible = true;
                checkBox9.Text = "The Pillars of the Earth"; checkBox9.Visible = true;
                checkBox10.Text = "The Water Dancer"; checkBox10.Visible = true;
                checkBox11.Text = "Memoirs of a Geisha"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "Maus"; checkBox7.Visible = true;
                checkBox8.Text = "Persepolis"; checkBox8.Visible = true;
                checkBox9.Text = "March"; checkBox9.Visible = true;
                checkBox10.Text = "No Passarán"; checkBox10.Visible = true;
                checkBox11.Text = "Pyongyang: A Journey in North Korea"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Schindler’s List"; checkBox7.Visible = true;
                checkBox8.Text = "12 Years a Slave"; checkBox8.Visible = true;
                checkBox9.Text = "The King’s Speech"; checkBox9.Visible = true;
                checkBox10.Text = "The Last Samurai"; checkBox10.Visible = true;
                checkBox11.Text = "The Imitation Game"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "Love Me Back"; checkBox7.Visible = true;
                checkBox8.Text = "Kill Ma Bo$$"; checkBox8.Visible = true;
                checkBox9.Text = "Ziller"; checkBox9.Visible = true;
                checkBox10.Text = "fromm"; checkBox10.Visible = true;
                checkBox11.Text = "Stay This Way"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton4.Text; // Set genre from each radio button
        }

        private void submitBookButton_Click(object sender, EventArgs e)
        {
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
            else if(!checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked && !checkBox10.Checked && 
                    !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked)
            {
                MessageBox.Show("Please choose the option at title");
                return;
            }

            listBox1.Items.Clear(); // Clear first for not error
            
            listBox1.Items.Add("Media Type: " + sharedData.mediaType);
            listBox1.Items.Add("Genre: " + sharedData.genre);

            int checkCount = 0; // Just for check wether more than 3 or not
            foreach (Control control in groupBox1.Controls)
            {
                // Check if the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    // If it's checked, increment checkCount
                    if (checkBox.Checked)
                    {
                        checkCount++;
                        if (checkCount > 1)
                        {
                            MessageBox.Show("You can only book 1");
                            return; // Without returning anything
                        }
                    }
                }
            }

            foreach (Control control in groupBox1.Controls)
            {
                // Check if the control is a CheckBox
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    // If it's checked, add its text to the ListBox
                    if (checkBox.Checked)
                    {
                        listBox1.Items.Add("Title: " + checkBox.Text);
                        sharedData.selectedItems = checkBox.Text; // For send to next form
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Media Type: " + sharedData.mediaType);
            listBox1.Items.Add("Genre: " + sharedData.genre);
            listBox1.Items.Add("Title: " + sharedData.selectedItems);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sharedData.mediaType == "Educational")
            {
                checkBox7.Text = "The Giver"; checkBox7.Visible = true;
                checkBox8.Text = "Of Mice and Men"; checkBox8.Visible = true;
                checkBox9.Text = "Sapiens: A Graphic History"; checkBox9.Visible = true;
                checkBox10.Text = "I Am Malala"; checkBox10.Visible = true;
                checkBox11.Text = "Atomic Habits"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "Dune"; checkBox7.Visible = true;
                checkBox8.Text = "Ender’s Game"; checkBox8.Visible = true;
                checkBox9.Text = "The Hitchhiker’s Guide to the Galaxy"; checkBox9.Visible = true;
                checkBox10.Text = "1984"; checkBox10.Visible = true;
                checkBox11.Text = "Fahrenheit 451"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "Watchmen"; checkBox7.Visible = true;
                checkBox8.Text = "V for Vendetta"; checkBox8.Visible = true;
                checkBox9.Text = "Akira"; checkBox9.Visible = true;
                checkBox10.Text = "The Incal"; checkBox10.Visible = true;
                checkBox11.Text = "Paper Girl"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Blade Runner"; checkBox7.Visible = true;
                checkBox8.Text = "The Matrix"; checkBox8.Visible = true;
                checkBox9.Text = "Godzilla Minus One"; checkBox9.Visible = true;
                checkBox10.Text = "Starship Troopers"; checkBox10.Visible = true;
                checkBox11.Text = "The Girl Who Leapt Through Time"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "Nirvana (Nevermind)"; checkBox7.Visible = true;
                checkBox8.Text = "Linkin Park (Hybrid Theory)"; checkBox8.Visible = true;
                checkBox9.Text = "Metallica (Master of Puppets)"; checkBox9.Visible = true;
                checkBox10.Text = "Queen (Greatest Hits)"; checkBox10.Visible = true;
                checkBox11.Text = "The Rolling Stones (Hot Rocks 1964–1971)"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton2.Text; // Set genre from each radio button
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (sharedData.mediaType == "Educational")
            {
                checkBox7.Text = "Research Design: Qualitative, Quantitative, and Mixed Methods Approaches"; checkBox7.Visible = true;
                checkBox8.Text = "The Craft of Research"; checkBox8.Visible = true;
                checkBox9.Text = "Naturalistic Inquiry"; checkBox9.Visible = true;
                checkBox10.Text = "Improving How Universities Teach Science"; checkBox10.Visible = true;
                checkBox11.Text = "Learning Engineering Toolkit"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "Murder on the Orient Express"; checkBox7.Visible = true;
                checkBox8.Text = "The Hound of the Baskervilles"; checkBox8.Visible = true;
                checkBox9.Text = "Gone Girl"; checkBox9.Visible = true;
                checkBox10.Text = "The Girl with the Dragon Tattoo"; checkBox10.Visible = true;
                checkBox11.Text = "The Big Sleep"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "Criminal"; checkBox7.Visible = true;
                checkBox8.Text = "Sin City"; checkBox8.Visible = true;
                checkBox9.Text = "Stray Bullets"; checkBox9.Visible = true;
                checkBox10.Text = "100 Bullets"; checkBox10.Visible = true;
                checkBox11.Text = "Kill or Be Killed"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Se7en"; checkBox7.Visible = true;
                checkBox8.Text = "Zodiac"; checkBox8.Visible = true;
                checkBox9.Text = "Gone Girl"; checkBox9.Visible = true;
                checkBox10.Text = "Prisoners"; checkBox10.Visible = true;
                checkBox11.Text = "Sherlock Holmes"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "Illmatic"; checkBox7.Visible = true;
                checkBox8.Text = "To Pimp a Butterfly"; checkBox8.Visible = true;
                checkBox9.Text = "Ready to Die"; checkBox9.Visible = true;
                checkBox10.Text = "Stankonia"; checkBox10.Visible = true;
                checkBox11.Text = "The Miseducation of Lauryn Hill"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton3.Text; // Set genre from each radio button
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "Pride and Prejudice"; checkBox7.Visible = true;
                checkBox8.Text = "The Love Hypothesis"; checkBox8.Visible = true;
                checkBox9.Text = "The Kiss Quotient"; checkBox9.Visible = true;
                checkBox10.Text = "Book Lovers"; checkBox10.Visible = true;
                checkBox11.Text = "The Unhoneymooners"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "Lore Olympus"; checkBox7.Visible = true;
                checkBox8.Text = "Heartstopper"; checkBox8.Visible = true;
                checkBox9.Text = "Bloom"; checkBox9.Visible = true;
                checkBox10.Text = "Daytime Shooting Star"; checkBox10.Visible = true;
                checkBox11.Text = "Your Name."; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Pride & Prejudice"; checkBox7.Visible = true;
                checkBox8.Text = "La La Land"; checkBox8.Visible = true;
                checkBox9.Text = "Before Sunrise"; checkBox9.Visible = true;
                checkBox10.Text = "Titanic"; checkBox10.Visible = true;
                checkBox11.Text = "Call Me by Your Name"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "The Greatest Showman (Original Soundtrack)"; checkBox7.Visible = true;
                checkBox8.Text = "La La Land (Original Motion Picture Soundtrack)"; checkBox8.Visible = true;
                checkBox9.Text = "Titanic (Music from the Motion Picture)"; checkBox9.Visible = true;
                checkBox10.Text = "Interstellar (Original Score)"; checkBox10.Visible = true;
                checkBox11.Text = "Your Name. (Original Soundtrack)"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton5.Text; // Set genre from each radio button
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (sharedData.mediaType == "Novels")
            {
                checkBox7.Text = "It"; checkBox7.Visible = true;
                checkBox8.Text = "The Haunting of Hill House"; checkBox8.Visible = true;
                checkBox9.Text = "The Exorcist"; checkBox9.Visible = true;
                checkBox10.Text = "Something Wicked This Way Comes"; checkBox10.Visible = true;
                checkBox11.Text = "Rebecca"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Comics")
            {
                checkBox7.Text = "From Hell"; checkBox7.Visible = true;
                checkBox8.Text = "Locke & Key"; checkBox8.Visible = true;
                checkBox9.Text = "Basketful of Heads"; checkBox9.Visible = true;
                checkBox10.Text = "Bitter Root"; checkBox10.Visible = true;
                checkBox11.Text = "Nailbiter"; checkBox11.Visible = true;
            }
            else if (sharedData.mediaType == "Blueray")
            {
                checkBox7.Text = "Hereditary"; checkBox7.Visible = true;
                checkBox8.Text = "The Witch"; checkBox8.Visible = true;
                checkBox9.Text = "The Thing"; checkBox9.Visible = true;
                checkBox10.Text = "It Follows"; checkBox10.Visible = true;
                checkBox11.Text = "The Babadook"; checkBox11.Visible = true;
            }
            else
            {
                checkBox7.Text = "Kind of Blue"; checkBox7.Visible = true;
                checkBox8.Text = "A Love Supreme"; checkBox8.Visible = true;
                checkBox9.Text = "Time Out"; checkBox9.Visible = true;
                checkBox10.Text = "Head Hunters"; checkBox10.Visible = true;
                checkBox11.Text = "Getz/Gilberto"; checkBox11.Visible = true;
            }
            sharedData.genre = radioButton5.Text; // Set genre from each radio button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Extend(sharedData.username).Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
