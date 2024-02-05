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
    public partial class frmNewHome : Form
    {
        public frmNewHome()
        {
            InitializeComponent();
        }
        public void ClearText(String cleartext)
        {
            if (cleartext.Equals("clear"))
            {
                txtBookID.Text = String.Empty;
                txtBook.Text = String.Empty;
                txtAuthor.Text = String.Empty;
                cboxAvailability.Text = String.Empty;
                cboxGenre.Text = String.Empty;
                cboxStudent.Text = String.Empty;
            }
        }
        public void LoadBookDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book", con);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String show = "show";
            if (show.Equals("show"))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Book WHERE BookID = '" + txtBookID.Text + "'  OR Book LIKE '" + txtBook.Text + "' OR BookAuthor LIKE '" + txtAuthor.Text + "' OR Genre LIKE '" + cboxGenre.Text + "' OR BorrowedBy LIKE '"+cboxStudent.Text+"' OR Availability LIKE '"+cboxAvailability.Text+"'", con);
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

        private void frmNewHome_Load(object sender, EventArgs e)
        {
            LoadBookDetails();
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
            ClearText("clear");
        }
    }
}
