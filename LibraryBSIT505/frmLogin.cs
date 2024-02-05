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
using System.Configuration;
using System.Drawing.Drawing2D;

namespace LibraryBSIT505
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            base.FormBorderStyle = FormBorderStyle.None;

            using (Graphics gr = Graphics.FromHwnd(Handle))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                using (System.Drawing.Drawing2D.GraphicsPath gp = CreatePath(new Rectangle(System.Drawing.Point.Empty, base.Size), 45))
                {
                    gr.FillPath(SystemBrushes.Window, gp);
                    Region region = new Region(gp);
                    base.Region = region;
                }
            }
        }

        public static System.Drawing.Drawing2D.GraphicsPath CreatePath(Rectangle rect, int nRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, nRadius, nRadius, 180f, 90f);
            path.AddArc((rect.Right - nRadius), rect.Y, nRadius, nRadius, 270f, 90f);
            path.AddArc((rect.Right - nRadius), (rect.Bottom - nRadius), nRadius, nRadius, 0f, 90f);
            path.AddArc(rect.X, (rect.Bottom - nRadius), nRadius, nRadius, 90f, 90f);
            path.CloseFigure();
            return path;
        }

        public const int WM_NCHITTEST = 0x0084;
        public const int WM_NCRBUTTONDOWN = 0x00A4;
        public const int WM_NCRBUTTONUP = 0x00A5;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_RBUTTONUP = 0x0205;

        public const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = new IntPtr(HTCAPTION);
                return;
            }
            if (m.Msg == WM_NCRBUTTONDOWN)
            {
                m.Result = (IntPtr)0;
                System.Threading.Thread.Sleep(200);
                this.Close();
                return;
            }
            else
                base.WndProc(ref m);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FJ2G8F9M;Initial Catalog=Library;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tbl_Userlogin WHERE Username = '"+txtUser.Text+"' and Userpass = '"+txtPass.Text+"'" ,con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows && dr["UserPrivilege"].Equals("3"))
                {
                    MessageBox.Show("Login Succesfully!");
                    con.Close();

                    //show dashboard
                    this.Hide();
                    frmDashboard db = new frmDashboard();
                    db.Show();
                }
                else if (dr.HasRows && dr["UserPrivilege"].Equals("2"))
                {
                    MessageBox.Show("Login Succesfully!");
                    con.Close();

                    //show dashboard
                    this.Hide();
                    frmDashboardManager dbm = new frmDashboardManager();
                    dbm.Show();
                }
                else if (dr.HasRows && dr["UserPrivilege"].Equals("1"))
                {
                    MessageBox.Show("Login Succesfully!");
                    con.Close();

                    //show dashboard
                    this.Hide();
                    frmDashboardEmployee dbe = new frmDashboardEmployee();
                    dbe.Show();
                }
                else if (dr.HasRows && dr["UserPrivilege"].Equals("0"))
                {
                    MessageBox.Show("Login Succesfully!");
                    con.Close();

                    //show dashboard
                    this.Hide();
                    frmDashboardStudent dbs = new frmDashboardStudent();
                    dbs.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials!");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Password"))
            {
                txtPass.Text= "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Username"))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void info_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by:\nJenron Condestable\nJ Vince Divina\n\nDesigned by:\nJohn Capistrano\nJohn Humphrey Bueza\nChristian Jay Malinao", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
