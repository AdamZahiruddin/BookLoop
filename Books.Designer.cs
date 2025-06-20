namespace ComicRentalSystem
{
    partial class Books
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBx1 = new System.Windows.Forms.GroupBox();
            this.chkBxDamaged = new System.Windows.Forms.CheckBox();
            this.chkBxOverdue = new System.Windows.Forms.CheckBox();
            this.chkBxExtendedBorrow = new System.Windows.Forms.CheckBox();
            this.chkBxPending = new System.Windows.Forms.CheckBox();
            this.chkBxBorrowed = new System.Windows.Forms.CheckBox();
            this.chkBxAvailable = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtBxBookID = new System.Windows.Forms.TextBox();
            this.btnBookID = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAuthor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxRemoveBookTitle = new System.Windows.Forms.TextBox();
            this.txtBxRemoveBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBx1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(18, 27);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(708, 225);
            this.dgvBooks.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(34, 258);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 256);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBx1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.lb1);
            this.tabPage1.Controls.Add(this.lb2);
            this.tabPage1.Controls.Add(this.txtBxBookID);
            this.tabPage1.Controls.Add(this.btnBookID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fetch Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBx1
            // 
            this.grpBx1.Controls.Add(this.chkBxDamaged);
            this.grpBx1.Controls.Add(this.chkBxOverdue);
            this.grpBx1.Controls.Add(this.chkBxExtendedBorrow);
            this.grpBx1.Controls.Add(this.chkBxPending);
            this.grpBx1.Controls.Add(this.chkBxBorrowed);
            this.grpBx1.Controls.Add(this.chkBxAvailable);
            this.grpBx1.Location = new System.Drawing.Point(250, 100);
            this.grpBx1.Name = "grpBx1";
            this.grpBx1.Size = new System.Drawing.Size(219, 100);
            this.grpBx1.TabIndex = 25;
            this.grpBx1.TabStop = false;
            this.grpBx1.Text = "Update Status";
            // 
            // chkBxDamaged
            // 
            this.chkBxDamaged.AutoSize = true;
            this.chkBxDamaged.Location = new System.Drawing.Point(117, 65);
            this.chkBxDamaged.Name = "chkBxDamaged";
            this.chkBxDamaged.Size = new System.Drawing.Size(72, 17);
            this.chkBxDamaged.TabIndex = 21;
            this.chkBxDamaged.Text = "Damaged";
            this.chkBxDamaged.UseVisualStyleBackColor = true;
            // 
            // chkBxOverdue
            // 
            this.chkBxOverdue.AutoSize = true;
            this.chkBxOverdue.Location = new System.Drawing.Point(117, 42);
            this.chkBxOverdue.Name = "chkBxOverdue";
            this.chkBxOverdue.Size = new System.Drawing.Size(67, 17);
            this.chkBxOverdue.TabIndex = 20;
            this.chkBxOverdue.Text = "Overdue";
            this.chkBxOverdue.UseVisualStyleBackColor = true;
            // 
            // chkBxExtendedBorrow
            // 
            this.chkBxExtendedBorrow.AutoSize = true;
            this.chkBxExtendedBorrow.Location = new System.Drawing.Point(117, 19);
            this.chkBxExtendedBorrow.Name = "chkBxExtendedBorrow";
            this.chkBxExtendedBorrow.Size = new System.Drawing.Size(71, 17);
            this.chkBxExtendedBorrow.TabIndex = 19;
            this.chkBxExtendedBorrow.Text = "Extended";
            this.chkBxExtendedBorrow.UseVisualStyleBackColor = true;
            // 
            // chkBxPending
            // 
            this.chkBxPending.AutoSize = true;
            this.chkBxPending.Location = new System.Drawing.Point(6, 65);
            this.chkBxPending.Name = "chkBxPending";
            this.chkBxPending.Size = new System.Drawing.Size(96, 17);
            this.chkBxPending.TabIndex = 18;
            this.chkBxPending.Text = "Pending Stock";
            this.chkBxPending.UseVisualStyleBackColor = true;
            // 
            // chkBxBorrowed
            // 
            this.chkBxBorrowed.AutoSize = true;
            this.chkBxBorrowed.Location = new System.Drawing.Point(6, 42);
            this.chkBxBorrowed.Name = "chkBxBorrowed";
            this.chkBxBorrowed.Size = new System.Drawing.Size(71, 17);
            this.chkBxBorrowed.TabIndex = 17;
            this.chkBxBorrowed.Text = "Borrowed";
            this.chkBxBorrowed.UseVisualStyleBackColor = true;
            // 
            // chkBxAvailable
            // 
            this.chkBxAvailable.AutoSize = true;
            this.chkBxAvailable.Location = new System.Drawing.Point(6, 19);
            this.chkBxAvailable.Name = "chkBxAvailable";
            this.chkBxAvailable.Size = new System.Drawing.Size(69, 17);
            this.chkBxAvailable.TabIndex = 16;
            this.chkBxAvailable.Text = "Available";
            this.chkBxAvailable.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 71);
            this.textBox1.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(503, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 46);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(38, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 13);
            this.lb1.TabIndex = 19;
            this.lb1.Text = "Book ID";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(238, 5);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(67, 13);
            this.lb2.TabIndex = 23;
            this.lb2.Text = "Book Details";
            // 
            // txtBxBookID
            // 
            this.txtBxBookID.Location = new System.Drawing.Point(90, 21);
            this.txtBxBookID.Name = "txtBxBookID";
            this.txtBxBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBxBookID.TabIndex = 20;
            // 
            // btnBookID
            // 
            this.btnBookID.Location = new System.Drawing.Point(115, 47);
            this.btnBookID.Name = "btnBookID";
            this.btnBookID.Size = new System.Drawing.Size(75, 23);
            this.btnBookID.TabIndex = 21;
            this.btnBookID.Text = "Fetch";
            this.btnBookID.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtBxPublisher);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBxAuthor);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnAddBook);
            this.tabPage2.Controls.Add(this.txtBxTitle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(294, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 100);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genre";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(118, 67);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(86, 17);
            this.checkBox11.TabIndex = 33;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(118, 44);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(86, 17);
            this.checkBox10.TabIndex = 32;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(118, 20);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(80, 17);
            this.checkBox9.TabIndex = 31;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 68);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 30;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(7, 44);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 29;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 28;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(39, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Genre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Publish Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Publisher";
            // 
            // txtBxPublisher
            // 
            this.txtBxPublisher.Location = new System.Drawing.Point(87, 61);
            this.txtBxPublisher.Name = "txtBxPublisher";
            this.txtBxPublisher.Size = new System.Drawing.Size(137, 20);
            this.txtBxPublisher.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Author";
            // 
            // txtBxAuthor
            // 
            this.txtBxAuthor.Location = new System.Drawing.Point(87, 35);
            this.txtBxAuthor.Name = "txtBxAuthor";
            this.txtBxAuthor.Size = new System.Drawing.Size(137, 20);
            this.txtBxAuthor.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(34, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(110, 44);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(110, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 31;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(39, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genre";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(539, 147);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(88, 46);
            this.btnAddBook.TabIndex = 24;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(87, 9);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(137, 20);
            this.txtBxTitle.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRemoveBook);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtBxRemoveBookTitle);
            this.tabPage3.Controls.Add(this.txtBxRemoveBookID);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(662, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(311, 90);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(88, 46);
            this.btnRemoveBook.TabIndex = 34;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Book ID";
            // 
            // txtBxRemoveBookTitle
            // 
            this.txtBxRemoveBookTitle.Location = new System.Drawing.Point(295, 47);
            this.txtBxRemoveBookTitle.Name = "txtBxRemoveBookTitle";
            this.txtBxRemoveBookTitle.Size = new System.Drawing.Size(137, 20);
            this.txtBxRemoveBookTitle.TabIndex = 32;
            // 
            // txtBxRemoveBookID
            // 
            this.txtBxRemoveBookID.Location = new System.Drawing.Point(295, 21);
            this.txtBxRemoveBookID.Name = "txtBxRemoveBookID";
            this.txtBxRemoveBookID.Size = new System.Drawing.Size(137, 20);
            this.txtBxRemoveBookID.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Book Title";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(738, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvBooks);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpBx1.ResumeLayout(false);
            this.grpBx1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBx1;
        private System.Windows.Forms.CheckBox chkBxDamaged;
        private System.Windows.Forms.CheckBox chkBxOverdue;
        private System.Windows.Forms.CheckBox chkBxExtendedBorrow;
        private System.Windows.Forms.CheckBox chkBxPending;
        private System.Windows.Forms.CheckBox chkBxBorrowed;
        private System.Windows.Forms.CheckBox chkBxAvailable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtBxBookID;
        private System.Windows.Forms.Button btnBookID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAuthor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxRemoveBookTitle;
        private System.Windows.Forms.TextBox txtBxRemoveBookID;
        private System.Windows.Forms.Label label6;
    }
}