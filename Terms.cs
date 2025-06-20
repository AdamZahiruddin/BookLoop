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
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Confirmation confirmationForm = new Confirmation();
                confirmationForm.Show();
                this.Hide();
            }
        }
    }
}
