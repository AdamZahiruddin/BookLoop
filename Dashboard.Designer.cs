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
            this.txtBxCustID = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fetched Info";
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.Location = new System.Drawing.Point(400, 319);
            this.txtBxInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxInfo.Multiline = true;
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(132, 116);
            this.txtBxInfo.TabIndex = 23;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(559, 299);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(107, 16);
            this.lb4.TabIndex = 22;
            this.lb4.Text = "Borrowed Books";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(36, 338);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(80, 16);
            this.lb3.TabIndex = 21;
            this.lb3.Text = "Customer ID";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(76, 306);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(44, 16);
            this.lb2.TabIndex = 20;
            this.lb2.Text = "Name";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(164, 367);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(100, 28);
            this.btnFetch.TabIndex = 19;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtBxCustID
            // 
            this.txtBxCustID.Location = new System.Drawing.Point(131, 335);
            this.txtBxCustID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxCustID.Name = "txtBxCustID";
            this.txtBxCustID.Size = new System.Drawing.Size(132, 22);
            this.txtBxCustID.TabIndex = 17;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(131, 303);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(132, 22);
            this.txtBxName.TabIndex = 16;
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(61, 68);
            this.dgvRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.RowHeadersWidth = 51;
            this.dgvRent.Size = new System.Drawing.Size(661, 217);
            this.dgvRent.TabIndex = 15;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(57, 28);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(111, 16);
            this.lb1.TabIndex = 14;
            this.lb1.Text = "Welcome : Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(563, 319);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 26;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxInfo);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtBxCustID);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.dgvRent);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
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
        private System.Windows.Forms.TextBox txtBxCustID;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}