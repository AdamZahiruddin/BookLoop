using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComicRentalSystem.Rent;

namespace ComicRentalSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Make rental start today
            dateTimePicker1.Value = DateTime.Now;

            // Make return date +7 days
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
            sharedData.bookMethod = radioButton4.Text;

            // Make textbox disable
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if click already fill or not
            if (!radioButton4.Checked && (!radioButton5.Checked || textBox1.Text == ""))
            {
                MessageBox.Show("Please fill in the details");
                return;
            }

            // Add items to listbox
            listBox1.Items.Clear();
            listBox1.Items.Add("Media Type: " + sharedData.mediaType);
            listBox1.Items.Add("Genre: " + sharedData.genre);
            listBox1.Items.Add("Title: ");
            // Add the items of checkbox to the listBox
            listBox1.Items.Add(sharedData.selectedItems);

            sharedData.rentalStart = dateTimePicker1.Text;
            listBox1.Items.Add("Rental Start: " + sharedData.rentalStart);
            sharedData.rentalEnd = dateTimePicker2.Text;
            listBox1.Items.Add("Return Date: " + sharedData.rentalEnd);
            listBox1.Items.Add("Booking Method: " + sharedData.bookMethod);
            sharedData.address = textBox1.Text;
            if (sharedData.address != "")
            {
                listBox1.Items.Add("Address: " + sharedData.address);
            }

            // Get payment method
            foreach (Control control in groupBox1.Controls)
            {
                // Check if the control is a CheckBox & If it's checked, add its text to the ListBox
                if (control is System.Windows.Forms.RadioButton radioBtn && radioBtn.Checked)
                {
                    listBox1.Items.Add("Payment Method: " + radioBtn.Text);
                    sharedData.payMethod = radioBtn.Text;
                }
            }
            buttonNext.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rent rentForm = new Rent(sharedData.username);
            rentForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tambah condition sini


            Terms termsForm = new Terms();
            termsForm.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // Make rental start tomorrow because of delivery
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);

            // Make return date +7 days
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
            sharedData.bookMethod = radioButton5.Text;

            // Make textBox1 enable
            textBox1.Enabled = true;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Media Type: " + sharedData.mediaType);
            listBox1.Items.Add("Genre: " + sharedData.genre);
            listBox1.Items.Add("Title: ");
            // Add the items to the listBox
            listBox1.Items.Add(sharedData.selectedItems);

            listBox1.Items.Add("Rental Start: " + sharedData.rentalStart);
            listBox1.Items.Add("Return Date: " + sharedData.rentalEnd);
            listBox1.Items.Add("Booking Method: " + sharedData.bookMethod);
            if (sharedData.address != "")
            {
                listBox1.Items.Add("Address: " + sharedData.address);
            }

            // Get payment method
            listBox1.Items.Add("Payment Method: " + sharedData.payMethod);
        }
    }
}
