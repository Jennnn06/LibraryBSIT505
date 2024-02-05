namespace LibraryBSIT505
{
    partial class frmLogReport
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
            this.lvLogReport = new System.Windows.Forms.ListView();
            this.LogID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BorrowedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLogReport
            // 
            this.lvLogReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LogID,
            this.LogReport,
            this.Date,
            this.BorrowedBy});
            this.lvLogReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvLogReport.FullRowSelect = true;
            this.lvLogReport.GridLines = true;
            this.lvLogReport.HideSelection = false;
            this.lvLogReport.Location = new System.Drawing.Point(0, 0);
            this.lvLogReport.Name = "lvLogReport";
            this.lvLogReport.Size = new System.Drawing.Size(786, 632);
            this.lvLogReport.TabIndex = 0;
            this.lvLogReport.UseCompatibleStateImageBehavior = false;
            this.lvLogReport.View = System.Windows.Forms.View.Details;
            this.lvLogReport.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LogID
            // 
            this.LogID.Text = "LogID";
            this.LogID.Width = 71;
            // 
            // LogReport
            // 
            this.LogReport.Text = "Log Report";
            this.LogReport.Width = 279;
            // 
            // Date
            // 
            this.Date.DisplayIndex = 3;
            this.Date.Text = "Date";
            this.Date.Width = 187;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(0, 515);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(786, 111);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowedBy
            // 
            this.BorrowedBy.DisplayIndex = 2;
            this.BorrowedBy.Text = "Borrowed By";
            this.BorrowedBy.Width = 198;
            // 
            // frmLogReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(786, 626);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvLogReport);
            this.Name = "frmLogReport";
            this.Text = "Log Report";
            this.Load += new System.EventHandler(this.frmLogReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLogReport;
        private System.Windows.Forms.ColumnHeader LogID;
        private System.Windows.Forms.ColumnHeader LogReport;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader BorrowedBy;
    }
}