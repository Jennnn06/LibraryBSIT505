using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBSIT505
{
    public partial class frmDashboardManager : Form
    {
        frmHome fuh = new frmHome();
        frmIssueBook fui = new frmIssueBook();
        frmLogReport flr = new frmLogReport();
        frmReturnBook frb = new frmReturnBook();
        frmNewHome fnh = new frmNewHome();
        frmStudent frs = new frmStudent();

        // movable border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDashboardManager()
        {
            InitializeComponent();
        }

        private void frmDashboardManager_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //home
            fnh.Dock = DockStyle.Fill;
            fnh.AutoScroll = true;
            fnh.TopLevel = false;
            fnh.TopMost = true;
            fnh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(fnh);

            fnh.Show();

            //border
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
            //border
        }
        //start of rounded border
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

        private void btnNewHome_Click(object sender, EventArgs e)
        {
            fnh.Dock = DockStyle.Fill;
            fnh.TopLevel = false;
            fnh.TopMost = true;
            fnh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.pnlDM.Controls.Add(fnh);

            fnh.Show();
            frb.Hide();
            fuh.Hide();
            flr.Hide();
            fui.Hide();
            frs.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            fuh.Dock = DockStyle.Fill;
            fuh.TopLevel = false;
            fuh.TopMost = true;
            fuh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(fuh);

            fnh.Hide();
            frb.Hide();
            fui.Hide();
            frs.Hide();
            flr.Hide();
            fuh.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            frb.Dock = DockStyle.Fill;
            frb.TopLevel = false;
            frb.TopMost = true;
            frb.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(frb);

            fnh.Hide();
            frb.Show();
            fuh.Hide();
            flr.Hide();
            fui.Hide();
            frs.Hide();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            fui.Dock = DockStyle.Fill;
            fui.TopLevel = false;
            fui.TopMost = true;
            fui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(fui);

            fnh.Hide();
            frb.Hide();
            fuh.Hide();
            flr.Hide();
            frs.Hide();
            fui.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frs.Dock = DockStyle.Fill;
            frs.TopLevel = false;
            frs.TopMost = true;
            frs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(frs);

            fnh.Hide();
            frb.Hide();
            fuh.Hide();
            flr.Hide();
            fui.Hide();
            frs.Show();
        }

        private void btnLReport_Click(object sender, EventArgs e)
        {
            flr.Dock = DockStyle.Fill;
            flr.TopLevel = false;
            flr.TopMost = true;
            flr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDM.Controls.Add(flr);

            fnh.Hide();
            frb.Hide();
            frs.Hide();
            fui.Hide();
            flr.Show();
            fuh.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labelDate.Text = datetime.ToString();
        }
        //end of rounded border
    }
}
