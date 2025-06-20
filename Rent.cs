using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicRentalSystem
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void bookSummaryText_Click(object sender, EventArgs e)
        {

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();
            paymentForm.Show();
            this.Hide();
        }
    }
}
