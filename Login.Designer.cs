namespace ComicRentalSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLoginNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to BookLoop!";
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(18, 102);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(208, 241);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(286, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name/Alias: ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnLoginNext
            // 
            this.btnLoginNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginNext.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginNext.Location = new System.Drawing.Point(393, 204);
            this.btnLoginNext.Name = "btnLoginNext";
            this.btnLoginNext.Size = new System.Drawing.Size(144, 51);
            this.btnLoginNext.TabIndex = 4;
            this.btnLoginNext.Text = "NEXT>";
            this.btnLoginNext.UseVisualStyleBackColor = true;
            this.btnLoginNext.Click += new System.EventHandler(this.btnLoginNext_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.btnLoginNext);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Welcome !";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLoginNext;
    }
}

