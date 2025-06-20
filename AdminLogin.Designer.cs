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
            this.SuspendLayout();
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(99, 33);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(40, 36);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // btnAdminSubmit
            // 
            this.btnAdminSubmit.Location = new System.Drawing.Point(111, 59);
            this.btnAdminSubmit.Name = "btnAdminSubmit";
            this.btnAdminSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSubmit.TabIndex = 2;
            this.btnAdminSubmit.Text = "Submit";
            this.btnAdminSubmit.UseVisualStyleBackColor = true;
            this.btnAdminSubmit.Click += new System.EventHandler(this.btnAdminSubmit_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 134);
            this.Controls.Add(this.btnAdminSubmit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtBxPassword);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnAdminSubmit;
    }
}