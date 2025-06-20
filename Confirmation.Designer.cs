namespace ComicRentalSystem
{
    partial class Confirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(187, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.Location = new System.Drawing.Point(238, 296);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(130, 54);
            this.btnSaveReceipt.TabIndex = 1;
            this.btnSaveReceipt.Text = "Save Receipt";
            this.btnSaveReceipt.UseVisualStyleBackColor = true;
            this.btnSaveReceipt.Click += new System.EventHandler(this.btnSaveReceipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Once Receipt is saved to your device, program wil exit.\r\n\r\n                     T" +
    "hank you for renting with us.";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveReceipt);
            this.Controls.Add(this.listBox1);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.Label label1;
    }
}