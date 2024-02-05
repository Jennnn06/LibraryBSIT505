using System;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        base.FormBorderStyle = FormBorderStyle.None;
        BackColor = System.Drawing.Color.Yellow;

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
}