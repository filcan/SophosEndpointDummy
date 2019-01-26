using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sophos
{
    public partial class MainForm : Form
    {
        // Mouse Movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            //notifyIcon_SophosEndpoint.ContextMenuStrip = contextMenuStrip1;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            tab_AdminLogin.BringToFront();
            pb_triangle.Hide();
        }

        private void btn_AdminLogin_MouseHover(object sender, EventArgs e)
        {
            btn_AdminLogin.ForeColor = Color.FromArgb(21, 47, 60);
        }

        private void btn_AdminLogin_MouseLeave(object sender, EventArgs e)
        {
            btn_AdminLogin.ForeColor = Color.FromArgb(153, 163, 169);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pb_SophosText;
            Hide();
            notifyIcon_SophosEndpoint.Visible = true;
        }

        private void pb_SophosText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon_SophosEndpoint.Visible = true;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon_SophosEndpoint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon_SophosEndpoint.Visible = false;
        }

        private void pb_Status_Click(object sender, EventArgs e)
        {
            pb_triangle.Visible = true;
            pb_Status.Image = Sophos.Properties.Resources.ic_status_active;
            pb_Event.Image = Sophos.Properties.Resources.ic_events_inactive;
            pb_triangle.Location = new Point(155, 41);
            tab_Status.BringToFront();
        }

        private void pb_Event_Click(object sender, EventArgs e)
        {
            pb_triangle.Visible = true;
            pb_Event.Image = Sophos.Properties.Resources.ic_events_active;
            pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
            pb_triangle.Location = new Point(228, 41);
            tab_Events.BringToFront();
        }

        private void pb_Status_MouseHover(object sender, EventArgs e)
        {
            //pb_Status.Image = Sophos.Properties.Resources.ic_status_active;
            //if (pb_triangle.Location.X == 155 && pb_triangle.Location.Y == 41)
            //    pb_Status.Image = Sophos.Properties.Resources.ic_status_active;
            //else
            //    pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
        }

        private void pb_Status_MouseLeave(object sender, EventArgs e)
        {
            //pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
            //if (pb_triangle.Location.X == 155 && pb_triangle.Location.Y == 41)
            //    pb_Status.Image = Sophos.Properties.Resources.ic_status_active;
            //else
            //    pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
        }

        private void pb_Event_MouseHover(object sender, EventArgs e)
        {
            //pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
            //if (pb_triangle.Location.X == 228 && pb_triangle.Location.Y == 41)
            //    pb_Event.Image = Sophos.Properties.Resources.ic_events_active;
            //else
            //    pb_Event.Image = Sophos.Properties.Resources.ic_events_inactive;
        }

        private void pb_Event_MouseLeave(object sender, EventArgs e)
        {
            //pb_Status.Image = Sophos.Properties.Resources.ic_status_inactive;
            //if (pb_triangle.Location.X == 228 && pb_triangle.Location.Y == 41)
            //    pb_Event.Image = Sophos.Properties.Resources.ic_events_active;
            //else
            //    pb_Event.Image = Sophos.Properties.Resources.ic_events_inactive;
        }

        private void link_About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb_triangle.Visible = false;
            tab_About.BringToFront();
        }

        private void link_Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.sophos.com/esg/Sophos-Endpoint-Windows/help/en-us/index.html");  
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
            notifyIcon_SophosEndpoint.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
