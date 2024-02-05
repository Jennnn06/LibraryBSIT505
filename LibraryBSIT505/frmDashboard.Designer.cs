
using System;

namespace LibraryBSIT505
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewHome = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnUserMaintenance = new System.Windows.Forms.Button();
            this.btnLReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoScroll = true;
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Location = new System.Drawing.Point(298, 112);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1232, 826);
            this.pnlSettings.TabIndex = 4;
            this.pnlSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSettings_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.flowLayoutPanel1.Controls.Add(this.panelLogo);
            this.flowLayoutPanel1.Controls.Add(this.btnNewHome);
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnReturnBook);
            this.flowLayoutPanel1.Controls.Add(this.btnAddStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnIssueBook);
            this.flowLayoutPanel1.Controls.Add(this.btnUserMaintenance);
            this.flowLayoutPanel1.Controls.Add(this.btnLReport);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 923);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.labelDate);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(298, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(4, 34);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 29);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 721);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 82);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(298, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 105);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "RHS Library System";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LibraryBSIT505.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(278, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewHome
            // 
            this.btnNewHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.btnNewHome.FlatAppearance.BorderSize = 0;
            this.btnNewHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewHome.ForeColor = System.Drawing.Color.White;
            this.btnNewHome.Image = global::LibraryBSIT505.Properties.Resources.house;
            this.btnNewHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewHome.Location = new System.Drawing.Point(4, 113);
            this.btnNewHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewHome.Name = "btnNewHome";
            this.btnNewHome.Size = new System.Drawing.Size(298, 82);
            this.btnNewHome.TabIndex = 9;
            this.btnNewHome.Text = "Home";
            this.btnNewHome.UseVisualStyleBackColor = false;
            this.btnNewHome.Click += new System.EventHandler(this.btnNewHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::LibraryBSIT505.Properties.Resources.borrow;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 205);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(298, 82);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Borrow Book";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Image = global::LibraryBSIT505.Properties.Resources.back;
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(3, 295);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(298, 78);
            this.btnReturnBook.TabIndex = 8;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = global::LibraryBSIT505.Properties.Resources.graduated;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 379);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(298, 77);
            this.btnAddStudent.TabIndex = 13;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Image = global::LibraryBSIT505.Properties.Resources.book_stack1;
            this.btnIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.Location = new System.Drawing.Point(4, 464);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(298, 78);
            this.btnIssueBook.TabIndex = 7;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnUserMaintenance
            // 
            this.btnUserMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.btnUserMaintenance.FlatAppearance.BorderSize = 0;
            this.btnUserMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnUserMaintenance.Image = global::LibraryBSIT505.Properties.Resources.software_engineer1;
            this.btnUserMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMaintenance.Location = new System.Drawing.Point(4, 552);
            this.btnUserMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUserMaintenance.Name = "btnUserMaintenance";
            this.btnUserMaintenance.Size = new System.Drawing.Size(298, 75);
            this.btnUserMaintenance.TabIndex = 2;
            this.btnUserMaintenance.Text = "User Maintenance";
            this.btnUserMaintenance.UseVisualStyleBackColor = false;
            this.btnUserMaintenance.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLReport
            // 
            this.btnLReport.FlatAppearance.BorderSize = 0;
            this.btnLReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLReport.ForeColor = System.Drawing.Color.White;
            this.btnLReport.Image = global::LibraryBSIT505.Properties.Resources.backlog1;
            this.btnLReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLReport.Location = new System.Drawing.Point(3, 635);
            this.btnLReport.Name = "btnLReport";
            this.btnLReport.Size = new System.Drawing.Size(298, 78);
            this.btnLReport.TabIndex = 6;
            this.btnLReport.Text = "Log Report";
            this.btnLReport.UseVisualStyleBackColor = true;
            this.btnLReport.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::LibraryBSIT505.Properties.Resources.logout1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 811);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(298, 77);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 923);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUserMaintenance;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnNewHome;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Panel panel2;
    }
}