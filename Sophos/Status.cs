using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sophos
{
    public partial class Status : UserControl
    {

        public Status()
        {
            InitializeComponent();
        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            btn_Scan.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 180, 180);
            btn_Scan.BackColor = Color.FromArgb(180, 180, 180);
            lbl_LastScanned.Visible = false;
            btn_Scan.Text = "Scan in progress";
            timer_Delay.Start();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(-12, 12);
            DateTime newDate = DateTime.Now.AddDays(-3);
            DateTime newHour = newDate.AddHours(num - num);
            DateTime newMins = newHour.AddMinutes(num - num);

            if (Properties.Settings.Default.LastScan == string.Empty)
                lbl_LastScanned.Text = "Last scanned: " + newMins.ToString();
            
            else
                lbl_LastScanned.Text = "Last scanned: " + Properties.Settings.Default.LastScan;
        }

        private void timer_Delay_Tick(object sender, EventArgs e)
        {
            DateTime newDate = DateTime.Now;

            btn_Scan.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 161, 231);
            btn_Scan.BackColor = Color.FromArgb(25, 135, 203);
            lbl_LastScanned.Visible = true;
            btn_Scan.Text = "Scan";
            Properties.Settings.Default.LastScan = newDate.ToString();
            Properties.Settings.Default.Save();
            lbl_LastScanned.Text = "Last scanned: " + Properties.Settings.Default.LastScan;
            timer_Delay.Stop();
        }
    }
}
