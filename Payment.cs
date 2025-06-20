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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rent rentForm = new Rent();
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
    }
}
