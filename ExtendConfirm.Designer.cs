namespace ComicRentalSystem
{
    partial class ExtendConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Once Receipt is saved to your device, program wil exit.\r\n\r\n                     T" +
    "hank you for renting with us.";
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.Location = new System.Drawing.Point(299, 380);
            this.btnSaveReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(173, 66);
            this.btnSaveReceipt.TabIndex = 4;
            this.btnSaveReceipt.Text = "Save Receipt";
            this.btnSaveReceipt.UseVisualStyleBackColor = true;
            this.btnSaveReceipt.Click += new System.EventHandler(this.btnSaveReceipt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(238, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 308);
            this.listBox1.TabIndex = 3;
            // 
            // ExtendConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveReceipt);
            this.Controls.Add(this.listBox1);
            this.Name = "ExtendConfirm";
            this.Text = "ExtendConfirm";
            this.Load += new System.EventHandler(this.ExtendConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.ListBox listBox1;
    }
}