namespace ComicRentalSystem
{
    partial class Renters
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
            this.dgvRenters = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBan = new System.Windows.Forms.Button();
            this.txtBxDetails = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnUnban = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRenters
            // 
            this.dgvRenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenters.Location = new System.Drawing.Point(12, 38);
            this.dgvRenters.Name = "dgvRenters";
            this.dgvRenters.Size = new System.Drawing.Size(576, 225);
            this.dgvRenters.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CustomerID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(463, 276);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(75, 23);
            this.btnBan.TabIndex = 8;
            this.btnBan.Text = "Blacklist";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // txtBxDetails
            // 
            this.txtBxDetails.Location = new System.Drawing.Point(292, 276);
            this.txtBxDetails.Multiline = true;
            this.txtBxDetails.Name = "txtBxDetails";
            this.txtBxDetails.Size = new System.Drawing.Size(165, 101);
            this.txtBxDetails.TabIndex = 9;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(136, 304);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 10;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            // 
            // btnUnban
            // 
            this.btnUnban.Location = new System.Drawing.Point(463, 305);
            this.btnUnban.Name = "btnUnban";
            this.btnUnban.Size = new System.Drawing.Size(75, 23);
            this.btnUnban.TabIndex = 11;
            this.btnUnban.Text = "Unban";
            this.btnUnban.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(247, 281);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(39, 13);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Details";
            // 
            // Renters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnUnban);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtBxDetails);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRenters);
            this.Name = "Renters";
            this.Text = "Renters";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRenters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.TextBox txtBxDetails;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnUnban;
        private System.Windows.Forms.Label lb2;
    }
}