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

namespace LibraryBSIT505
{
    public partial class frmHome : Form
    {
        //updating
        String Update;
        String lockbutton = "lock";
        public frmHome()
        {
            InitializeComponent();
        }

        //load Book Table
        public void LoadBookDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book WHERE Availability = 'Available'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                lvBook.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lvBook.Items.Add(lv);
                }
            }
        }
        //enabling buttons
        public void ButtonsEnable(String updateSaveCancel)
        {
            if (updateSaveCancel.Equals("enableUpdate"))
            {
                //kapag pede magsearch update
                //btnSearch.Enabled = true;
                //btnUpdate.Enabled = true;
                btnReset.Enabled = true;
                btnUpdate.Enabled = true;
                //d pede pumindot pag sesearch ka

                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                cboxStudent.Enabled = false;
                //cboxGenre.Enabled = false;
                txtBookID.Enabled = true;
                txtBook.Enabled = true;
                txtAuthor.Enabled = true;

            }
            else
            {
                //kapag magupdate ka
                //btnSearch.Enabled = false;
                //btnReset.Enabled = false;
                // eto ung pede ka pumindot
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                cboxStudent.Enabled = true;
                //cboxGenre.Enabled = false;
                //txtBookID.Enabled = false;
                //txtBook.Enabled = false;
                //txtAuthor.Enabled = false;
            }
        }

        //clearing text
        public void ClearText(String cleartext)
        {
            if (cleartext.Equals("clear"))
            {
                txtBookID.Text = String.Empty;
                txtBook.Text = String.Empty;
                txtAuthor.Text = String.Empty;
                cboxGenre.Text = String.Empty;
                cboxStudent.Text = String.Empty;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadBookDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ButtonsEnable("disableUpdate");
            btnLock.Enabled = true;
            LockButton("lock");
            Update = "yes";

            //load student data 
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * FROM tbl_Student", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tbl1 = new DataTable();
            da.Fill(tbl1);
            cboxStudent.DataSource = tbl1;
            cboxStudent.DisplayMember = "Student";
            cboxStudent.ValueMember = "StudentID";
        }
        public void LockButton(String lockme)
        {
            if (lockme.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvBook.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;

                txtBookID.Enabled = false;
                txtBook.Enabled= false;
                txtAuthor.Enabled= false;
                cboxGenre.Enabled= false;
                cboxStudent.Enabled= true;
            }
            else if (lockme.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvBook.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
                
                txtBookID.Enabled = true;
                txtBook.Enabled= true;
                txtAuthor.Enabled= true;
                cboxGenre.Enabled= true;
                cboxStudent.Enabled= false;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Update.Equals("yes") && !String.IsNullOrEmpty(txtBookID.Text))
            {
                ButtonsEnable("enableUpdate");
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Book set Availability = 'Unavailable', BorrowedBy ='" + cboxStudent.Text + "' where BookID = '" + txtBookID.Text + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    //LogReport
                    String i = "test";
                    if (i.Equals("test"))
                    {
                        using (SqlConnection conL = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                        {
                            conL.Open();
                            String dateNow = DateTime.Now.ToLongDateString();
                            String logRep = "Book named ";
                            String logRep1 = " has been borrowed by ";

                            String comLog = logRep + txtBook.Text + logRep1;

                            SqlCommand cmdLog = new SqlCommand("INSERT INTO tbl_LogReport (LogReport, BorrowedBy, Date) VALUES ('" + comLog + "', '"+cboxStudent.Text+"' ,'" + dateNow + "') ", conL);
                            SqlDataReader drlog = cmdLog.ExecuteReader();
                            drlog.Read();
                            conL.Close();

                        }
                    }
                    //finish logreport
                    dr.Read();
                    MessageBox.Show("Record Updated Successfully!");
                    ClearText("clear");
                    con.Close();
                }
                LoadBookDetails();
                LockButton("unlock");
                btnLock.Enabled = false;/*
                cboxStudent.Enabled = false;
                cboxAvailability.Enabled = false;*/
            }
            else if(Update.Equals("yes") && String.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Please input any data on the textboxes to continue.", "Warning!", MessageBoxButtons.OK);
                ButtonsEnable("disableUpdate");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonsEnable("enableUpdate");
            LockButton("unlock");
            btnSearch.Enabled = true;
            btnLock.Enabled= false;
            cboxStudent.Enabled = false;
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            //bawal magenter ng text dapat num lang, assignment
            if (txtBookID.Text.Length > 0)
            {
                try
                {
                    Convert.ToDecimal(txtBookID.Text);
                }
                catch (Exception exception)
                {
                    txtBookID.Text = txtBookID.Text.Remove(txtBookID.TextLength - 1, 1);
                    txtBookID.SelectionStart = txtBookID.Text.Length;
                    txtBookID.SelectionLength = 0;
                }
            }
        }

        private void txtBook_TextChanged(object sender, EventArgs e)
        {
            //autoload sana ung data kapag nagtype ka palang kaso d ko magawa
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String show = "show";
            if (show.Equals("show"))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book WHERE (BookID = '"+txtBookID.Text+ "' AND Availability = 'Available') OR (Book LIKE '" + txtBook.Text+ "' AND Availability = 'Available') OR (BookAuthor LIKE '" + txtAuthor.Text+ "' AND Availability = 'Available') OR (Genre LIKE '" + cboxGenre.Text+"' AND Availability = 'Available')", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    lvBook.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lv.SubItems.Add(dr[2].ToString());
                        lv.SubItems.Add(dr[3].ToString());
                        lv.SubItems.Add(dr[4].ToString());
                        lv.SubItems.Add(dr[5].ToString());
                        lvBook.Items.Add(lv);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadBookDetails();
            ClearText("clear");
        }

        //pag pinindot list view lalabas sa textbox data
        private void lvBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBook.SelectedItems.Count > 0)
            {
                ListViewItem items = lvBook.SelectedItems[0];
                txtBookID.Text = items.SubItems[0].Text;
                txtBook.Text = items.SubItems[1].Text;
                txtAuthor.Text = items.SubItems[2].Text;
                cboxStudent.Text = items.SubItems[4].Text;
                cboxGenre.Text= items.SubItems[5].Text;
            }
        }

        private void cboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (lockbutton.Equals("lock"))
            {
                btnLock.Text = "UNLOCK";
                lockbutton = "unlock";
                lvBook.FullRowSelect = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;

                txtBookID.Enabled = false;
                txtBook.Enabled = false;
                txtAuthor.Enabled = false;
                cboxGenre.Enabled = false;
                cboxStudent.Enabled = true;
            }
            else if (lockbutton.Equals("unlock"))
            {
                btnLock.Text = "LOCK";
                lockbutton = "lock";
                lvBook.FullRowSelect = true;
                btnSearch.Enabled = true;
                btnReset.Enabled = true;
                
                txtBookID.Enabled = true;
                txtBook.Enabled = true;
                txtAuthor.Enabled = true;
                cboxGenre.Enabled = true;
                cboxStudent.Enabled = false;
            }
        }
    }
}
