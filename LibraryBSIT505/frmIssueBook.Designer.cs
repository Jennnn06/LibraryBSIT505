namespace LibraryBSIT505
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.lvIssueBook = new System.Windows.Forms.ListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.cboxGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvIssueBook
            // 
            this.lvIssueBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.Book,
            this.Author,
            this.Genre});
            this.lvIssueBook.FullRowSelect = true;
            this.lvIssueBook.GridLines = true;
            this.lvIssueBook.HideSelection = false;
            this.lvIssueBook.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvIssueBook.Items")))});
            resources.ApplyResources(this.lvIssueBook, "lvIssueBook");
            this.lvIssueBook.Name = "lvIssueBook";
            this.lvIssueBook.UseCompatibleStateImageBehavior = false;
            this.lvIssueBook.View = System.Windows.Forms.View.Details;
            this.lvIssueBook.SelectedIndexChanged += new System.EventHandler(this.lvIssueBook_SelectedIndexChanged);
            // 
            // BookID
            // 
            resources.ApplyResources(this.BookID, "BookID");
            // 
            // Book
            // 
            resources.ApplyResources(this.Book, "Book");
            // 
            // Author
            // 
            resources.ApplyResources(this.Author, "Author");
            // 
            // Genre
            // 
            resources.ApplyResources(this.Genre, "Genre");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBookID
            // 
            resources.ApplyResources(this.txtBookID, "txtBookID");
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.cboxGenre);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.txtAuthor);
            this.grpBox.Controls.Add(this.txtBook);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.txtBookID);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.label3);
            resources.ApplyResources(this.grpBox, "grpBox");
            this.grpBox.Name = "grpBox";
            this.grpBox.TabStop = false;
            this.grpBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxGenre
            // 
            this.cboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenre.FormattingEnabled = true;
            this.cboxGenre.Items.AddRange(new object[] {
            resources.GetString("cboxGenre.Items"),
            resources.GetString("cboxGenre.Items1"),
            resources.GetString("cboxGenre.Items2"),
            resources.GetString("cboxGenre.Items3"),
            resources.GetString("cboxGenre.Items4")});
            resources.ApplyResources(this.cboxGenre, "cboxGenre");
            this.cboxGenre.Name = "cboxGenre";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtAuthor
            // 
            resources.ApplyResources(this.txtAuthor, "txtAuthor");
            this.txtAuthor.Name = "txtAuthor";
            // 
            // txtBook
            // 
            resources.ApplyResources(this.txtBook, "txtBook");
            this.txtBook.Name = "txtBook";
            this.txtBook.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLock
            // 
            resources.ApplyResources(this.btnLock, "btnLock");
            this.btnLock.Name = "btnLock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmIssueBook
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lvIssueBook);
            this.Name = "frmIssueBook";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvIssueBook;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
    }
}