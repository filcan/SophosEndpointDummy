namespace Sophos
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Topbar = new System.Windows.Forms.Panel();
            this.pb_Event = new System.Windows.Forms.PictureBox();
            this.pb_triangle = new System.Windows.Forms.PictureBox();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.pb_Status = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_SophosText = new System.Windows.Forms.PictureBox();
            this.notifyIcon_SophosEndpoint = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_toChange = new System.Windows.Forms.Panel();
            this.panel_BottomBar = new System.Windows.Forms.Panel();
            this.link_About = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.link_Help = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Status = new Sophos.Status();
            this.tab_About = new Sophos.About();
            this.tab_Events = new Sophos.Events();
            this.tab_AdminLogin = new Sophos.AdminLogin();
            this.panel_Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SophosText)).BeginInit();
            this.panel_toChange.SuspendLayout();
            this.panel_BottomBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Topbar
            // 
            this.panel_Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel_Topbar.Controls.Add(this.pb_Event);
            this.panel_Topbar.Controls.Add(this.pb_triangle);
            this.panel_Topbar.Controls.Add(this.btn_AdminLogin);
            this.panel_Topbar.Controls.Add(this.pb_Status);
            this.panel_Topbar.Controls.Add(this.btn_Minimize);
            this.panel_Topbar.Controls.Add(this.btn_Close);
            this.panel_Topbar.Controls.Add(this.panel3);
            this.panel_Topbar.Controls.Add(this.pb_SophosText);
            this.panel_Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Topbar.Location = new System.Drawing.Point(0, 0);
            this.panel_Topbar.Name = "panel_Topbar";
            this.panel_Topbar.Size = new System.Drawing.Size(700, 50);
            this.panel_Topbar.TabIndex = 0;
            this.panel_Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_SophosText_MouseDown);
            // 
            // pb_Event
            // 
            this.pb_Event.Image = global::Sophos.Properties.Resources.ic_events_inactive;
            this.pb_Event.Location = new System.Drawing.Point(214, 20);
            this.pb_Event.Name = "pb_Event";
            this.pb_Event.Size = new System.Drawing.Size(43, 11);
            this.pb_Event.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Event.TabIndex = 7;
            this.pb_Event.TabStop = false;
            this.pb_Event.Click += new System.EventHandler(this.pb_Event_Click);
            this.pb_Event.MouseEnter += new System.EventHandler(this.pb_Event_MouseHover);
            this.pb_Event.MouseLeave += new System.EventHandler(this.pb_Event_MouseLeave);
            this.pb_Event.MouseHover += new System.EventHandler(this.pb_Event_MouseHover);
            // 
            // pb_triangle
            // 
            this.pb_triangle.Image = global::Sophos.Properties.Resources.ic_triangle;
            this.pb_triangle.Location = new System.Drawing.Point(155, 41);
            this.pb_triangle.Name = "pb_triangle";
            this.pb_triangle.Size = new System.Drawing.Size(15, 9);
            this.pb_triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_triangle.TabIndex = 8;
            this.pb_triangle.TabStop = false;
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_AdminLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(169)))));
            this.btn_AdminLogin.Location = new System.Drawing.Point(467, 13);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(156, 24);
            this.btn_AdminLogin.TabIndex = 7;
            this.btn_AdminLogin.TabStop = false;
            this.btn_AdminLogin.Text = "Admin login";
            this.btn_AdminLogin.UseVisualStyleBackColor = false;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            this.btn_AdminLogin.MouseEnter += new System.EventHandler(this.btn_AdminLogin_MouseHover);
            this.btn_AdminLogin.MouseLeave += new System.EventHandler(this.btn_AdminLogin_MouseLeave);
            this.btn_AdminLogin.MouseHover += new System.EventHandler(this.btn_AdminLogin_MouseHover);
            // 
            // pb_Status
            // 
            this.pb_Status.Image = global::Sophos.Properties.Resources.ic_status_active;
            this.pb_Status.Location = new System.Drawing.Point(141, 20);
            this.pb_Status.Name = "pb_Status";
            this.pb_Status.Size = new System.Drawing.Size(43, 11);
            this.pb_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Status.TabIndex = 6;
            this.pb_Status.TabStop = false;
            this.pb_Status.Click += new System.EventHandler(this.pb_Status_Click);
            this.pb_Status.MouseEnter += new System.EventHandler(this.pb_Status_MouseHover);
            this.pb_Status.MouseLeave += new System.EventHandler(this.pb_Status_MouseLeave);
            this.pb_Status.MouseHover += new System.EventHandler(this.pb_Status_MouseHover);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Silver;
            this.btn_Minimize.BackgroundImage = global::Sophos.Properties.Resources.ic_topbar_minimize;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(637, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(27, 50);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Silver;
            this.btn_Close.BackgroundImage = global::Sophos.Properties.Resources.ic_topbar_close;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(664, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(27, 50);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(691, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 50);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_SophosText_MouseDown);
            // 
            // pb_SophosText
            // 
            this.pb_SophosText.Image = global::Sophos.Properties.Resources.ic_sophos_text;
            this.pb_SophosText.Location = new System.Drawing.Point(16, 14);
            this.pb_SophosText.Name = "pb_SophosText";
            this.pb_SophosText.Size = new System.Drawing.Size(64, 14);
            this.pb_SophosText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_SophosText.TabIndex = 2;
            this.pb_SophosText.TabStop = false;
            this.pb_SophosText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_SophosText_MouseDown);
            // 
            // notifyIcon_SophosEndpoint
            // 
            this.notifyIcon_SophosEndpoint.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_SophosEndpoint.Icon")));
            this.notifyIcon_SophosEndpoint.Text = "Sophos Endpoint";
            this.notifyIcon_SophosEndpoint.Visible = true;
            this.notifyIcon_SophosEndpoint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_SophosEndpoint_MouseDoubleClick);
            // 
            // panel_toChange
            // 
            this.panel_toChange.Controls.Add(this.tab_Status);
            this.panel_toChange.Controls.Add(this.tab_About);
            this.panel_toChange.Controls.Add(this.tab_Events);
            this.panel_toChange.Controls.Add(this.tab_AdminLogin);
            this.panel_toChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_toChange.Location = new System.Drawing.Point(0, 50);
            this.panel_toChange.Name = "panel_toChange";
            this.panel_toChange.Size = new System.Drawing.Size(700, 413);
            this.panel_toChange.TabIndex = 1;
            // 
            // panel_BottomBar
            // 
            this.panel_BottomBar.Controls.Add(this.link_About);
            this.panel_BottomBar.Controls.Add(this.label2);
            this.panel_BottomBar.Controls.Add(this.link_Help);
            this.panel_BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BottomBar.Location = new System.Drawing.Point(0, 463);
            this.panel_BottomBar.Name = "panel_BottomBar";
            this.panel_BottomBar.Size = new System.Drawing.Size(700, 37);
            this.panel_BottomBar.TabIndex = 2;
            // 
            // link_About
            // 
            this.link_About.AutoSize = true;
            this.link_About.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_About.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(203)))));
            this.link_About.Location = new System.Drawing.Point(652, 12);
            this.link_About.Name = "link_About";
            this.link_About.Size = new System.Drawing.Size(35, 13);
            this.link_About.TabIndex = 14;
            this.link_About.TabStop = true;
            this.link_About.Text = "About";
            this.link_About.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_About_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "|";
            // 
            // link_Help
            // 
            this.link_Help.AutoSize = true;
            this.link_Help.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_Help.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(203)))));
            this.link_Help.Location = new System.Drawing.Point(608, 12);
            this.link_Help.Name = "link_Help";
            this.link_Help.Size = new System.Drawing.Size(29, 13);
            this.link_Help.TabIndex = 12;
            this.link_Help.TabStop = true;
            this.link_Help.Text = "Help";
            this.link_Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Help_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tab_Status
            // 
            this.tab_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.tab_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Status.Location = new System.Drawing.Point(0, 0);
            this.tab_Status.Name = "tab_Status";
            this.tab_Status.Size = new System.Drawing.Size(700, 413);
            this.tab_Status.TabIndex = 0;
            // 
            // tab_About
            // 
            this.tab_About.BackColor = System.Drawing.Color.White;
            this.tab_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_About.Location = new System.Drawing.Point(0, 0);
            this.tab_About.Name = "tab_About";
            this.tab_About.Size = new System.Drawing.Size(700, 413);
            this.tab_About.TabIndex = 2;
            // 
            // tab_Events
            // 
            this.tab_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Events.Location = new System.Drawing.Point(0, 0);
            this.tab_Events.Name = "tab_Events";
            this.tab_Events.Size = new System.Drawing.Size(700, 413);
            this.tab_Events.TabIndex = 1;
            // 
            // tab_AdminLogin
            // 
            this.tab_AdminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_AdminLogin.Location = new System.Drawing.Point(0, 0);
            this.tab_AdminLogin.Name = "tab_AdminLogin";
            this.tab_AdminLogin.Size = new System.Drawing.Size(700, 413);
            this.tab_AdminLogin.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel_toChange);
            this.Controls.Add(this.panel_Topbar);
            this.Controls.Add(this.panel_BottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sophos Endpoint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel_Topbar.ResumeLayout(false);
            this.panel_Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SophosText)).EndInit();
            this.panel_toChange.ResumeLayout(false);
            this.panel_BottomBar.ResumeLayout(false);
            this.panel_BottomBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Topbar;
        private System.Windows.Forms.PictureBox pb_SophosText;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.PictureBox pb_Status;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.PictureBox pb_triangle;
        private System.Windows.Forms.NotifyIcon notifyIcon_SophosEndpoint;
        private System.Windows.Forms.PictureBox pb_Event;
        private System.Windows.Forms.Panel panel_toChange;
        private System.Windows.Forms.Panel panel_BottomBar;
        private System.Windows.Forms.LinkLabel link_About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_Help;
        private Status tab_Status;
        private About tab_About;
        private Events tab_Events;
        private AdminLogin tab_AdminLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

