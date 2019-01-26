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
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancel_MouseHover(object sender, EventArgs e)
        {
            btn_Cancel.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancel.ForeColor = Color.FromArgb(25, 135, 203);
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Tamper Protection Password")
            {
                txt_Password.PasswordChar = '•';
                txt_Password.Text = string.Empty;
                txt_Password.ForeColor = Color.Black;
            }
            //else if (txt_Password.Text == "")
            //{
            //    txt_Password.PasswordChar = '\0';
            //    txt_Password.Text = "Tamper Protection Password";
            //    txt_Password.ForeColor = Color.FromArgb(64, 64, 64);
            //}
        }
    }
}
