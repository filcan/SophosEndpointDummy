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
    public partial class About : UserControl
    {

        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(-12, 12);
            DateTime newDate = DateTime.Now.AddDays(-7);
            DateTime newHour = newDate.AddHours(num);
            DateTime newMins = newHour.AddMinutes(num);
            lbl_Copyright.Text = "Copyright 2014-" + DateTime.Now.Year.ToString() + " Sophos Ltd.";

            if (Properties.Settings.Default.LastUpdate == string.Empty)
                lbl_LastUpdate.Text = "Last update: " + newMins.ToString();
            else
                lbl_LastUpdate.Text = "Last update: " + Properties.Settings.Default.LastUpdate;
        }

        private void btn_UpdateNow_Click(object sender, EventArgs e)
        {
            btn_UpdateNow.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 180, 180);
            btn_UpdateNow.BackColor = Color.FromArgb(180, 180, 180);
            btn_UpdateNow.Text = "Updating";
            pb_Check.Visible = false;
            lbl_LastUpdate.Visible = false;
            timer_Delay.Start();
        }

        private void timer_Delay_Tick(object sender, EventArgs e)
        {
            DateTime newDate = DateTime.Now;

            btn_UpdateNow.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 161, 231);
            btn_UpdateNow.BackColor = Color.FromArgb(25, 135, 203);
            btn_UpdateNow.Text = "Update";
            pb_Check.Visible = true;
            lbl_LastUpdate.Visible = true;
            Properties.Settings.Default.LastUpdate = newDate.ToString();
            Properties.Settings.Default.Save();
            lbl_LastUpdate.Text = "Last update: " + Properties.Settings.Default.LastUpdate;
            timer_Delay.Stop();
        }
    }
}
