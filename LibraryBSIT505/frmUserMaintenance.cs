using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace LibraryBSIT505
{
    public partial class frmUserMaintenance : Form
    {
        public frmUserMaintenance()
        {
            InitializeComponent();
        }
        String AUD;
        String lockbutton = "lock";
        public void ButtonsEnable(String addupdatedelete)
        {
            if (addupdatedelete.Equals("enable")) //For enabling buttons
            {
                // enable add update delete tas off save cancel
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                btnLock.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                lvUser.FullRowSelect = false;

                btnSearch.Enabled = true;
                btnReset.Enabled = true;

                txtUID.Enabled = true;
            }
            else
            {
                //disable add update delete tas on save cancel
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                btnLock.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                txtUID.Enabled = false;
            }
        }

        public void ClearingTxtBox(String cleartxt)
        {
            if (cleartxt.Equals("clear"))
            {
                txtUID.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                cboxPrivilege.Text = String.Empty;
            }
        }
        public void LoadUserDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Userlogin", con);
                SqlDataReader dr = cmd.ExecuteReader();

                lvUser.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lvUser.Items.Add(lv);
                }
            }
        }
        public void LockButton(String lockme)
        {
            if (lockme.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvUser.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (lockme.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvUser.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }
        private void frmUserMaintenance_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           ButtonsEnable("disabled");
           LockButton("lock");
           AUD = "add";
           btnLock.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disabled");
            LockButton("lock");
            btnLock.Enabled = true;
            AUD = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disabled");
            LockButton("lock");
            AUD = "delete";
            btnLock.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Procedure
            if(AUD == "add" && !String.IsNullOrEmpty(txtUsername.Text))
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Userlogin(Username, Userpass, UserPrivilege) VALUES ('"+txtUsername.Text+"', '"+txtPassword.Text+"', '"+cboxPrivilege.Text+"')", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    //LogReport
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "User named ";
                            String logRep1 = " has been added";

                            String comLog = logRep + txtUsername.Text + logRep1;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();

                        }
                    }
                    //finish logreport
                    MessageBox.Show("Record Inserted Successfully!");
                    con.Close();
                }
                ClearingTxtBox("clear");
                LoadUserDetails();
                LockButton("unlock");
            }
            else if(AUD == "add" && String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(cboxPrivilege.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if(AUD == "update" && !String.IsNullOrEmpty(txtUID.Text))
            {
                ButtonsEnable("enable");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Userlogin set Username = '"+txtUsername.Text+"', Userpass ='"+txtPassword.Text+"', UserPrivilege = '"+cboxPrivilege.Text+"' where UserID = '"+txtUID.Text+"' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    //LogReport
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "User named ";
                            String logRep1 = " has been updated.";

                            String comLog = logRep + txtUsername.Text + logRep1;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();

                        }
                    }
                    //finish logreport
                    MessageBox.Show("Record Updated Successfully!");
                    con.Close();
                }

                ClearingTxtBox("clear");
                LoadUserDetails();
                LockButton("unlock");
            }
            else if (AUD == "update" && String.IsNullOrEmpty(txtUID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
            else if(AUD == "delete" && !String.IsNullOrEmpty(txtUID.Text))
            {
                ButtonsEnable("enable");
                if (MessageBox.Show("Do you want to delete this record?","Remove Record", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Userlogin WHERE UserID= '" + txtUID.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        //LogReport
                        String i = "test";
                        if (i.Equals("test"))
                        {
                            using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                            {
                                conL.Open();
                                String dateNow = DateTime.Now.ToLongDateString();
                                String logRep = "Book named ";
                                String logRep1 = " has been deleted.";

                                String comLog = logRep + txtUsername.Text + logRep1;

                                SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', 'N/A' ,'" + dateNow + "') ", conL);
                                SqlDataReader drlog = cmdLog.ExecuteReader();
                                drlog.Read();
                                conL.Close();

                            }
                        }
                        //finish logreport
                        MessageBox.Show("Record Deleted Successfully!");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Record not removed","Remove Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearingTxtBox("clear");
                LoadUserDetails();
                LockButton("unlock");

            }
            else if (AUD == "delete" && String.IsNullOrEmpty(txtUID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonsEnable("enable");
            LockButton("unlock");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvUser.SelectedItems.Count > 0)
            {
                ListViewItem items = lvUser.SelectedItems[0];
                txtUID.Text = items.SubItems[0].Text;
                txtUsername.Text = items.SubItems[1].Text;
                txtPassword.Text = items.SubItems[2].Text;
                cboxPrivilege.Text= items.SubItems[3].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lockbutton.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvUser.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (lockbutton.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvUser.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadUserDetails();
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
                    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Userlogin WHERE UserID = '"+txtUID.Text+"' OR Username = '"+txtUsername.Text+"' OR Userpass = '"+txtPassword.Text+"' OR UserPrivilege = '"+cboxPrivilege.Text+"' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    lvUser.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv.SubItems.Add(dr[3].ToString());
                        lvUser.Items.Add(lv);
                    }
                }
            }
        }
    }
}
