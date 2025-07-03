namespace bus_management_system
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.profilepic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labellogout = new System.Windows.Forms.LinkLabel();
            this.btnmanagebook = new Guna.UI2.WinForms.Guna2Button();
            this.btnliboperation = new Guna.UI2.WinForms.Guna2Button();
            this.btnmemmanagement = new Guna.UI2.WinForms.Guna2Button();
            this.btndashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slidebartimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.Color.Transparent;
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profilepic.FillColor = System.Drawing.Color.DimGray;
            this.profilepic.ImageRotate = 0F;
            this.profilepic.Location = new System.Drawing.Point(44, 35);
            this.profilepic.Name = "profilepic";
            this.profilepic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilepic.Size = new System.Drawing.Size(176, 177);
            this.profilepic.TabIndex = 30;
            this.profilepic.TabStop = false;
            this.profilepic.Click += new System.EventHandler(this.profilepic_Click);
            // 
            // labellogout
            // 
            this.labellogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(46)))), ((int)(((byte)(121)))));
            this.labellogout.AutoSize = true;
            this.labellogout.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogout.LinkColor = System.Drawing.Color.White;
            this.labellogout.Location = new System.Drawing.Point(83, 556);
            this.labellogout.Name = "labellogout";
            this.labellogout.Size = new System.Drawing.Size(109, 37);
            this.labellogout.TabIndex = 4;
            this.labellogout.TabStop = true;
            this.labellogout.Text = "Logout";
            this.labellogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labellogout_LinkClicked);
            // 
            // btnmanagebook
            // 
            this.btnmanagebook.BorderRadius = 15;
            this.btnmanagebook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmanagebook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmanagebook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmanagebook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmanagebook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnmanagebook.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagebook.ForeColor = System.Drawing.Color.White;
            this.btnmanagebook.Location = new System.Drawing.Point(5, 473);
            this.btnmanagebook.Name = "btnmanagebook";
            this.btnmanagebook.Size = new System.Drawing.Size(241, 52);
            this.btnmanagebook.TabIndex = 3;
            this.btnmanagebook.Text = "Manage Books";
            this.btnmanagebook.Click += new System.EventHandler(this.btnmanagebook_Click);
            // 
            // btnliboperation
            // 
            this.btnliboperation.BorderRadius = 15;
            this.btnliboperation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnliboperation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnliboperation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnliboperation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnliboperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnliboperation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliboperation.ForeColor = System.Drawing.Color.White;
            this.btnliboperation.Location = new System.Drawing.Point(5, 353);
            this.btnliboperation.Name = "btnliboperation";
            this.btnliboperation.Size = new System.Drawing.Size(241, 52);
            this.btnliboperation.TabIndex = 2;
            this.btnliboperation.Text = "History";
            this.btnliboperation.Click += new System.EventHandler(this.btnliboperation_Click);
            // 
            // btnmemmanagement
            // 
            this.btnmemmanagement.BorderRadius = 15;
            this.btnmemmanagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmemmanagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmemmanagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmemmanagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmemmanagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnmemmanagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmemmanagement.ForeColor = System.Drawing.Color.White;
            this.btnmemmanagement.Location = new System.Drawing.Point(5, 413);
            this.btnmemmanagement.Name = "btnmemmanagement";
            this.btnmemmanagement.Size = new System.Drawing.Size(241, 52);
            this.btnmemmanagement.TabIndex = 1;
            this.btnmemmanagement.Text = "Member Management";
            this.btnmemmanagement.Click += new System.EventHandler(this.btnmemmanagement_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BorderRadius = 15;
            this.btndashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndashboard.FillColor = System.Drawing.Color.White;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btndashboard.Location = new System.Drawing.Point(5, 293);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(241, 52);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(252, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(4, 700);
            this.guna2Panel3.TabIndex = 3;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.guna2Panel1.Controls.Add(this.btnclose);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(256, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1044, 60);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnclose
            // 
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(986, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(62, 51);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MZ LIBRARY SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.panelmain.FillColor = System.Drawing.Color.LightGray;
            this.panelmain.Location = new System.Drawing.Point(256, 60);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1044, 640);
            this.panelmain.TabIndex = 5;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // btnmenu
            // 
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(20, 20);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(30, 30);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 31;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // slidebartimer
            // 
            this.slidebartimer.Interval = 1;
            this.slidebartimer.Tick += new System.EventHandler(this.slidebartime_Tick);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Controls.Add(this.btnmenu);
            this.guna2Panel4.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(248, 70);
            this.guna2Panel4.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.sidebar.Controls.Add(this.guna2Panel4);
            this.sidebar.Controls.Add(this.guna2Panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(252, 700);
            this.sidebar.MinimumSize = new System.Drawing.Size(252, 700);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(252, 700);
            this.sidebar.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.btnliboperation);
            this.guna2Panel2.Controls.Add(this.profilepic);
            this.guna2Panel2.Controls.Add(this.btndashboard);
            this.guna2Panel2.Controls.Add(this.btnmanagebook);
            this.guna2Panel2.Controls.Add(this.labellogout);
            this.guna2Panel2.Controls.Add(this.btnmemmanagement);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 79);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(248, 609);
            this.guna2Panel2.TabIndex = 2;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint_2);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel labellogout;
        private Guna.UI2.WinForms.Guna2Button btnmanagebook;
        private Guna.UI2.WinForms.Guna2Button btnliboperation;
        private Guna.UI2.WinForms.Guna2Button btnmemmanagement;
        private Guna.UI2.WinForms.Guna2Button btndashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelmain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilepic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer slidebartimer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}