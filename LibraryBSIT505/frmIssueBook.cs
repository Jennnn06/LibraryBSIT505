using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBSIT505
{
    public partial class frmIssueBook : Form
    {
        public frmIssueBook()
        {
            InitializeComponent();
        }
        String AUD;
        String lockbutton = "lock";
        public void LoadBookDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book", con);
                SqlDataReader dr = cmd.ExecuteReader();

                lvIssueBook.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lvIssueBook.Items.Add(lv);
                }
            }
        }

        //Pangenable ng fullrowselect 
        //d ko na paganahin to
        public void FullRowSelect(String fs)
        {
            if (fs.Equals("enable"))
            {
                lvIssueBook.FullRowSelect = true;
            }
            else
            {
                lvIssueBook.FullRowSelect = false;
            }
        }
        public void ButtonsEnable(String addupdatedelete)
        {
            if (addupdatedelete.Equals("enable")) //For enabling buttons
            {
                //enabling and disabling txtbox
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                //save, lock and cancel disabled
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnLock.Enabled = false;

                //Textbox
                txtBookID.Enabled = true;

                //search and reset
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
            else
            {
                //open lock, save and cancel when clicking add, update delete
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                //
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                //
                txtBookID.Enabled = false;
            }
        }

        //pangclear ng textbox
        public void ClearingTxtBox(String cleartxt)
        {
            if (cleartxt.Equals("clear"))
            {
                txtBookID.Clear();
                txtBook.Clear();
                txtAuthor.Clear();
                cboxGenre.Text = String.Empty;
            }
        }
        public void LockButton(String lockme)
        {
            if (lockme.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvIssueBook.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (lockme.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvIssueBook.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }
        private void lvIssueBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIssueBook.SelectedItems.Count > 0)
            {
                ListViewItem items = lvIssueBook.SelectedItems[0];
                txtBookID.Text = items.SubItems[0].Text;
                txtBook.Text = items.SubItems[1].Text;
                txtAuthor.Text = items.SubItems[2].Text;
                cboxGenre.Text = items.SubItems[3].Text;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Save btn
        private void Button4_Click(object sender, EventArgs e)
        {
            if(AUD == "add" && !String.IsNullOrEmpty(txtBook.Text))
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Book(Book, BookAuthor, Availability, BorrowedBy, Genre) VALUES ('" + txtBook.Text + "', '" + txtAuthor.Text + "', 'Available', 'N/A', '"+cboxGenre.Text+"')", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //logreport of add
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "Book named ";
                            String logRep1 = " and its author ";
                            String logRep2 = " has been added to the list.";

                            String comLog = logRep + txtBook.Text + logRep1 + txtAuthor.Text + logRep2;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();
                        }
                    }
                    //end of logreport
                    dr.Read();
                    MessageBox.Show("Book Inserted Successfully!");
                    con.Close();
                }
                ClearingTxtBox("clear");
                btnLock.Enabled = false;
                LockButton("unlock");
                LoadBookDetails();
            }
            else if (AUD == "add" && String.IsNullOrEmpty(txtBook.Text) || String.IsNullOrEmpty(txtAuthor.Text) || String.IsNullOrEmpty(cboxGenre.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if (AUD == "update" && !String.IsNullOrEmpty(txtBookID.Text)) 
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Book set Book = '" + txtBook.Text + "', BookAuthor ='" + txtAuthor.Text + "', Genre = '"+cboxGenre.Text+"' where BookID = '" + txtBookID.Text + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //log report of updated
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "Book named ";
                            String author = " have changed its Author to ";
                            String genre = " and its Genre to ";
                            String logRep2 = ".";

                            String comLog = logRep + txtBook.Text + author + txtAuthor.Text + genre +cboxGenre.Text+ logRep2;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();
                        }
                    }
                    //end of log report
                    dr.Read();
                    MessageBox.Show("Record Updated Successfully!");
                    con.Close();
                }
                ClearingTxtBox("clear");
                btnLock.Enabled = false;
                LockButton("unlock");
                LoadBookDetails();
            }
            else if (AUD == "update" && String.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if (AUD == "delete" && !String.IsNullOrEmpty(txtBookID.Text))
            {
                ButtonsEnable("enable");
                if (MessageBox.Show("Do you want to delete this record?", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Book WHERE BookID= '" + txtBookID.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        //log report of delete
                        String i = "test";
                        if (i.Equals("test"))
                        {
                            using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                            {
                                conL.Open();
                                String dateNow = DateTime.Now.ToLongDateString();
                                String logRep = "Book named ";
                                String logRep2 = " has been deleted.";

                                String comLog = logRep + txtBook.Text + logRep2;

                                SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', ''N/A ,'" + dateNow + "') ", conL);
                                SqlDataReader drlog = cmdLog.ExecuteReader();
                                drlog.Read();
                                conL.Close();
                            }
                        }
                        //end of logreport
                        dr.Read();
                        MessageBox.Show("Record Deleted Successfully!");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Record not removed", "Remove Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearingTxtBox("clear");
                btnLock.Enabled = false;
                LockButton("unlock");
                LoadBookDetails();

            }
            else if(AUD == "delete" && !String.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            
        }

        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            LoadBookDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disable");
            LockButton("lock");
            btnLock.Enabled = true;
            AUD = "add";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disable");
            LockButton("lock");
            btnLock.Enabled = true;
            AUD = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disable");
            LockButton("lock");
            btnLock.Enabled = true;
            AUD = "delete";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonsEnable("enable");
            LockButton("unlock");
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (lockbutton.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvIssueBook.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if(lockbutton.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvIssueBook.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String show = "show";
            if (show.Equals("show"))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book WHERE BookID = '" + txtBookID.Text + "' OR Book LIKE '" + txtBook.Text + "' OR BookAuthor LIKE '" + txtAuthor.Text + "' OR Genre LIKE '" + cboxGenre.Text + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    lvIssueBook.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv.SubItems.Add(dr[3].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        lv.SubItems.Add(dr[5].ToString());
                        lvIssueBook.Items.Add(lv);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadBookDetails();
            ClearingTxtBox("clear");
        }
    }
}
