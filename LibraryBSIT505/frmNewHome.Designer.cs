namespace LibraryBSIT505
{
    partial class frmNewHome
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
            this.lvBook = new System.Windows.Forms.ListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxStudent = new System.Windows.Forms.ComboBox();
            this.cboxGenre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxAvailability = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBook
            // 
            this.lvBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.Book,
            this.Author,
            this.Availability,
            this.BorrowedBy,
            this.Genre});
            this.lvBook.GridLines = true;
            this.lvBook.HideSelection = false;
            this.lvBook.Location = new System.Drawing.Point(18, 18);
            this.lvBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvBook.Name = "lvBook";
            this.lvBook.Size = new System.Drawing.Size(971, 219);
            this.lvBook.TabIndex = 1;
            this.lvBook.UseCompatibleStateImageBehavior = false;
            this.lvBook.View = System.Windows.Forms.View.Details;
            // 
            // BookID
            // 
            this.BookID.Text = "BookID";
            this.BookID.Width = 70;
            // 
            // Book
            // 
            this.Book.Text = "Book";
            this.Book.Width = 235;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 97;
            // 
            // Availability
            // 
            this.Availability.Text = "Availability";
            this.Availability.Width = 110;
            // 
            // BorrowedBy
            // 
            this.BorrowedBy.DisplayIndex = 5;
            this.BorrowedBy.Text = "BorrowedBy";
            this.BorrowedBy.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DisplayIndex = 4;
            this.Genre.Text = "Genre / Category";
            this.Genre.Width = 157;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(664, 278);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 60);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(825, 278);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 60);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxStudent);
            this.groupBox1.Controls.Add(this.cboxGenre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxAvailability);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBook);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Location = new System.Drawing.Point(18, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(426, 388);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Checking for Borrowing";
            // 
            // cboxStudent
            // 
            this.cboxStudent.FormattingEnabled = true;
            this.cboxStudent.Location = new System.Drawing.Point(134, 249);
            this.cboxStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxStudent.Name = "cboxStudent";
            this.cboxStudent.Size = new System.Drawing.Size(247, 28);
            this.cboxStudent.TabIndex = 15;
            // 
            // cboxGenre
            // 
            this.cboxGenre.FormattingEnabled = true;
            this.cboxGenre.Items.AddRange(new object[] {
            "Adventure fiction",
            "Biography",
            "Comedy",
            "Informative",
            "Sports"});
            this.cboxGenre.Location = new System.Drawing.Point(134, 198);
            this.cboxGenre.Name = "cboxGenre";
            this.cboxGenre.Size = new System.Drawing.Size(247, 28);
            this.cboxGenre.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre:";
            // 
            // cboxAvailability
            // 
            this.cboxAvailability.FormattingEnabled = true;
            this.cboxAvailability.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboxAvailability.Location = new System.Drawing.Point(134, 295);
            this.cboxAvailability.Name = "cboxAvailability";
            this.cboxAvailability.Size = new System.Drawing.Size(247, 28);
            this.cboxAvailability.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Borrowed By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(134, 146);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(247, 26);
            this.txtAuthor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Availability:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID:";
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(134, 92);
            this.txtBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(247, 26);
            this.txtBook.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(134, 45);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookID.MaxLength = 2;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(247, 26);
            this.txtBookID.TabIndex = 4;
            // 
            // frmNewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 651);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lvBook);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNewHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmNewHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvBook;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Availability;
        private System.Windows.Forms.ColumnHeader BorrowedBy;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxAvailability;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.ComboBox cboxStudent;
    }
}