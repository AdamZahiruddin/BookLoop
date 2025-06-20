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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renters renters = new Renters();
            renters.MdiParent = this;
            renters.Dock = DockStyle.Fill;
            renters.Show();
        }

        private void viewDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.MdiParent = this;
            books.Dock = DockStyle.Fill;
            books.Show();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addmin addmin = new Addmin();
            addmin.MdiParent = this;
            addmin.Dock = DockStyle.Fill;
            addmin.Show();
        }
    }
}
