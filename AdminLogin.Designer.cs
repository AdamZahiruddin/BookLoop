namespace ComicRentalSystem
{
    partial class AdminLogin
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
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btnAdminSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(136, 43);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(132, 22);
            this.txtBxPassword.TabIndex = 0;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(43, 46);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // btnAdminSubmit
            // 
            this.btnAdminSubmit.Location = new System.Drawing.Point(148, 82);
            this.btnAdminSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminSubmit.Name = "btnAdminSubmit";
            this.btnAdminSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnAdminSubmit.TabIndex = 2;
            this.btnAdminSubmit.Text = "Submit";
            this.btnAdminSubmit.UseVisualStyleBackColor = true;
            this.btnAdminSubmit.Click += new System.EventHandler(this.btnAdminSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Name";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(136, 13);
            this.txtBxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(132, 22);
            this.txtBxUsername.TabIndex = 3;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.btnAdminSubmit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtBxPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnAdminSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxUsername;
    }
}