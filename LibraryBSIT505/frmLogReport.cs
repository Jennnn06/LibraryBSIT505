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
    public partial class frmLogReport : Form
    {
        public frmLogReport()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadLogReport()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_LogReport", con);
                SqlDataReader dr = cmd.ExecuteReader();

                lvLogReport.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lvLogReport.Items.Add(lv);
                }
            }
        }

        private void frmLogReport_Load(object sender, EventArgs e)
        {
            LoadLogReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogReport();
        }
    }
}
