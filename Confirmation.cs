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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
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
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, "Receipt details here...");
                    MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
