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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        String AUD;
        String lockbutton = "lock";

        public void LoadStudentDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Student", con);
                SqlDataReader dr = cmd.ExecuteReader();

                lvStudent.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lvStudent.Items.Add(lv);
                }
            }
        }

        public void FullRowSelect(String fs)
        {
            if (fs.Equals("enable"))
            {
                lvStudent.FullRowSelect = true;
            }
            else
            {
                lvStudent.FullRowSelect = false;
            }
        }

        public void ButtonsEnable(String addupdatedelete)
        {
            if (addupdatedelete.Equals("enable")) //For enabling buttons
            {
                //enabling and disabling addupdatedelete
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                //save, lock and cancel disabled
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnLock.Enabled = false;

                //txtbox and combobox disabled
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
                txtStudentID.Enabled = true;
                //txtStudent.Enabled = false;
                //cboxCourse.Enabled = false;
                //cboxYear.Enabled = false;
                //cboxSection.Enabled = false;
            }
            else
            {
                //disable addupdatedelete
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                //enable save, lock and cancel
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnLock.Enabled = true;

                //txtbox and combobox enable
                txtStudentID.Enabled = false;
                //txtStudent.Enabled = true;
                //cboxCourse.Enabled = true;
                //cboxYear.Enabled = true;
                //cboxSection.Enabled = true;
            }
        }
        public void ClearingTxtBox(String cleartxt)
        {
            if (cleartxt.Equals("clear"))
            {
                txtStudentID.Clear();
                txtStudent.Clear();
                cboxCourse.Text = String.Empty;
                cboxYear.Text = String.Empty;
                cboxSection.Text = String.Empty;
            }
        }
        public void LockButton(String lockme)
        {
            if (lockme.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvStudent.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (lockme.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvStudent.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
;       }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem items = lvStudent.SelectedItems[0];
                txtStudentID.Text = items.SubItems[0].Text;
                txtStudent.Text = items.SubItems[1].Text;
                cboxCourse.Text = items.SubItems[2].Text;
                cboxYear.Text = items.SubItems[3].Text;
                cboxSection.Text = items.SubItems[4].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AUD == "add" && !String.IsNullOrEmpty(txtStudent.Text))
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Student(Student, Course, Year, Section) VALUES ('" + txtStudent.Text + "', '" + cboxCourse.Text + "', '" + cboxYear.Text + "', '" + cboxSection.Text + "')", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //logreport of add
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "Student named ";
                            String logRep2 = " has been added to the list.";

                            String comLog = logRep + txtStudent.Text + logRep2;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();
                        }
                    }
                    //end of logreport
                    dr.Read();
                    MessageBox.Show("Student Inserted Successfully!");
                    con.Close();
                }
                ClearingTxtBox("clear");
                btnLock.Enabled = false;
                LockButton("unlock");
                LoadStudentDetails();
            }
            else if (AUD == "add" && String.IsNullOrEmpty(txtStudent.Text) || String.IsNullOrEmpty(cboxCourse.Text) || String.IsNullOrEmpty(cboxYear.Text) || String.IsNullOrEmpty(cboxSection.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if (AUD == "update" && !String.IsNullOrEmpty(txtStudentID.Text))
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Student set Student = '" + txtStudent.Text + "', Course ='" + cboxCourse.Text + "', Year = '" + cboxYear.Text + "', Section = '"+cboxSection.Text+"' where StudentID = '" + txtStudentID.Text + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //log report of updated
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "Student named ";
                            String updated = " have been updated.";

                            String comLog = logRep + txtStudent.Text + updated;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();
                        }
                    }
                    //end of log report
                    dr.Read();
                    MessageBox.Show("Student record has been updated successfully!");
                    con.Close();
                }
                ClearingTxtBox("clear");
                btnLock.Enabled = false;
                LockButton("unlock");
                LoadStudentDetails();
            }
            else if (AUD == "update" && String.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if (AUD == "delete" && !String.IsNullOrEmpty(txtStudentID.Text))
            {
                ButtonsEnable("enable");
                if (MessageBox.Show("Do you want to delete this student record?", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Student WHERE StudentID= '" + txtStudentID.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        //log report of delete
                        String i = "test";
                        if (i.Equals("test"))
                        {
                            using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                            {
                                conL.Open();
                                String dateNow = DateTime.Now.ToLongDateString();
                                String logRep = "Student named ";
                                String logRep2 = " has been deleted.";

                                String comLog = logRep + txtStudent.Text + logRep2;

                                SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                                SqlDataReader drlog = cmdLog.ExecuteReader();
                                drlog.Read();
                                conL.Close();
                            }
                        }
                        //end of logreport
                        dr.Read();
                        MessageBox.Show("Student record has been deleted successfully!");
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
                LoadStudentDetails();

            }
            else if (AUD == "delete" && String.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
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
                lvStudent.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (lockbutton.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvStudent.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadStudentDetails();
            ClearingTxtBox("clear");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String show = "show";
            if (show.Equals("show"))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Student WHERE StudentID = '"+txtStudentID.Text+"' OR Student LIKE '"+txtStudent.Text+"' OR Course LIKE '"+cboxCourse.Text+"' OR Year LIKE '"+cboxYear.Text+"' OR Section LIKE '"+cboxSection.Text+"'", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    lvStudent.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv.SubItems.Add(dr[3].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        lvStudent.Items.Add(lv);
                    }
                }
            }
        }
    }
}
