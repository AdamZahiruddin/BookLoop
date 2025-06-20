namespace ComicRentalSystem
{
    partial class Addmin
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBxAdminName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 27);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(424, 225);
            this.dgvBooks.TabIndex = 7;
            // 
            // txtBxAdminName
            // 
            this.txtBxAdminName.Location = new System.Drawing.Point(185, 258);
            this.txtBxAdminName.Name = "txtBxAdminName";
            this.txtBxAdminName.Size = new System.Drawing.Size(100, 20);
            this.txtBxAdminName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin Name";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(185, 294);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 39);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Add New";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // Addmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(450, 368);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxAdminName);
            this.Controls.Add(this.dgvBooks);
            this.Name = "Addmin";
            this.Text = "Addmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBxAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
    }
}