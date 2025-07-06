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
            this.dgvRenters.AllowUserToAddRows = false;
            this.dgvRenters.AllowUserToDeleteRows = false;
            this.dgvRenters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRenters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenters.Location = new System.Drawing.Point(16, 47);
            this.dgvRenters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRenters.Name = "dgvRenters";
            this.dgvRenters.ReadOnly = true;
            this.dgvRenters.RowHeadersWidth = 51;
            this.dgvRenters.Size = new System.Drawing.Size(768, 277);
            this.dgvRenters.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 342);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(617, 340);
            this.btnBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(100, 28);
            this.btnBan.TabIndex = 8;
            this.btnBan.Text = "Blacklist";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // txtBxDetails
            // 
            this.txtBxDetails.Location = new System.Drawing.Point(389, 340);
            this.txtBxDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxDetails.Multiline = true;
            this.txtBxDetails.Name = "txtBxDetails";
            this.txtBxDetails.Size = new System.Drawing.Size(219, 123);
            this.txtBxDetails.TabIndex = 9;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(181, 374);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(100, 28);
            this.btnFetch.TabIndex = 10;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnUnban
            // 
            this.btnUnban.Location = new System.Drawing.Point(617, 375);
            this.btnUnban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnban.Name = "btnUnban";
            this.btnUnban.Size = new System.Drawing.Size(100, 28);
            this.btnUnban.TabIndex = 11;
            this.btnUnban.Text = "Unban";
            this.btnUnban.UseVisualStyleBackColor = true;
            this.btnUnban.Click += new System.EventHandler(this.btnUnban_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(329, 346);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(49, 16);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Details";
            // 
            // Renters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnUnban);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtBxDetails);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRenters);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Renters";
            this.Text = "Renters";
            this.Load += new System.EventHandler(this.Renters_Load);
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