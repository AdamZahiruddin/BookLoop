namespace ComicRentalSystem
{
    partial class Dashboard
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
            this.txtBxInfo = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.lsBxBooks = new System.Windows.Forms.ListBox();
            this.txtBxCustID = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fetched Info";
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.Location = new System.Drawing.Point(300, 259);
            this.txtBxInfo.Multiline = true;
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(100, 95);
            this.txtBxInfo.TabIndex = 23;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(419, 243);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(85, 13);
            this.lb4.TabIndex = 22;
            this.lb4.Text = "Borrowed Books";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(27, 275);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(65, 13);
            this.lb3.TabIndex = 21;
            this.lb3.Text = "Customer ID";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(57, 249);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 20;
            this.lb2.Text = "Name";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(123, 298);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 19;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            // 
            // lsBxBooks
            // 
            this.lsBxBooks.FormattingEnabled = true;
            this.lsBxBooks.Location = new System.Drawing.Point(422, 259);
            this.lsBxBooks.Name = "lsBxBooks";
            this.lsBxBooks.Size = new System.Drawing.Size(120, 95);
            this.lsBxBooks.TabIndex = 18;
            // 
            // txtBxCustID
            // 
            this.txtBxCustID.Location = new System.Drawing.Point(98, 272);
            this.txtBxCustID.Name = "txtBxCustID";
            this.txtBxCustID.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustID.TabIndex = 17;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(98, 246);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 16;
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(46, 55);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.Size = new System.Drawing.Size(496, 176);
            this.dgvRent.TabIndex = 15;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(43, 23);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(89, 13);
            this.lb1.TabIndex = 14;
            this.lb1.Text = "Welcome : Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxInfo);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lsBxBooks);
            this.Controls.Add(this.txtBxCustID);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.dgvRent);
            this.Controls.Add(this.lb1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxInfo;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ListBox lsBxBooks;
        private System.Windows.Forms.TextBox txtBxCustID;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Label lb1;
    }
}