namespace bus_management_system
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.showpassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.lbloginas = new System.Windows.Forms.Label();
            this.txtlogin_as = new Guna.UI2.WinForms.Guna2ComboBox();
            this.linkregisteration = new System.Windows.Forms.LinkLabel();
            this.lbnotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtpassword.BorderRadius = 7;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "Enter Password";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.Enabled = false;
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(12, 395);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(364, 45);
            this.txtpassword.TabIndex = 11;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            this.txtpassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtpassword_MouseClick);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.lbusername.Location = new System.Drawing.Point(12, 280);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(83, 21);
            this.lbusername.TabIndex = 10;
            this.lbusername.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtusername.BorderRadius = 7;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "Enter Username";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.Enabled = false;
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(12, 304);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(364, 45);
            this.txtusername.TabIndex = 9;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusername_KeyDown);
            this.txtusername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtusername_MouseClick);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.lbpassword.Location = new System.Drawing.Point(11, 369);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(79, 21);
            this.lbpassword.TabIndex = 8;
            this.lbpassword.Text = "Password";
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.CheckedState.BorderColor = System.Drawing.Color.White;
            this.showpassword.CheckedState.BorderRadius = 0;
            this.showpassword.CheckedState.BorderThickness = 0;
            this.showpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.showpassword.Enabled = false;
            this.showpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.showpassword.Location = new System.Drawing.Point(254, 446);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(122, 21);
            this.showpassword.TabIndex = 12;
            this.showpassword.Text = "Show Password";
            this.showpassword.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.showpassword.UncheckedState.BorderRadius = 0;
            this.showpassword.UncheckedState.BorderThickness = 0;
            this.showpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Enabled = false;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(12, 498);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(364, 45);
            this.btnlogin.TabIndex = 16;
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbloginas
            // 
            this.lbloginas.AutoSize = true;
            this.lbloginas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.lbloginas.Location = new System.Drawing.Point(12, 200);
            this.lbloginas.Name = "lbloginas";
            this.lbloginas.Size = new System.Drawing.Size(73, 21);
            this.lbloginas.TabIndex = 14;
            this.lbloginas.Text = "Login As";
            // 
            // txtlogin_as
            // 
            this.txtlogin_as.BackColor = System.Drawing.Color.Transparent;
            this.txtlogin_as.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtlogin_as.BorderRadius = 7;
            this.txtlogin_as.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtlogin_as.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtlogin_as.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlogin_as.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlogin_as.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin_as.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtlogin_as.ItemHeight = 30;
            this.txtlogin_as.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.txtlogin_as.Location = new System.Drawing.Point(12, 224);
            this.txtlogin_as.Name = "txtlogin_as";
            this.txtlogin_as.Size = new System.Drawing.Size(364, 36);
            this.txtlogin_as.TabIndex = 15;
            this.txtlogin_as.SelectedIndexChanged += new System.EventHandler(this.txtlogin_as_SelectedIndexChanged);
            this.txtlogin_as.SelectedValueChanged += new System.EventHandler(this.txtlogin_as_SelectedValueChanged);
            // 
            // linkregisteration
            // 
            this.linkregisteration.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.linkregisteration.AutoSize = true;
            this.linkregisteration.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.linkregisteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkregisteration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.linkregisteration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.linkregisteration.Location = new System.Drawing.Point(120, 567);
            this.linkregisteration.Name = "linkregisteration";
            this.linkregisteration.Size = new System.Drawing.Size(139, 16);
            this.linkregisteration.TabIndex = 18;
            this.linkregisteration.TabStop = true;
            this.linkregisteration.Text = "Don\'t have an account";
            this.linkregisteration.Visible = false;
            this.linkregisteration.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.linkregisteration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbnotif
            // 
            this.lbnotif.AutoSize = true;
            this.lbnotif.BackColor = System.Drawing.Color.White;
            this.lbnotif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnotif.ForeColor = System.Drawing.Color.Red;
            this.lbnotif.Location = new System.Drawing.Point(203, 263);
            this.lbnotif.Name = "lbnotif";
            this.lbnotif.Size = new System.Drawing.Size(163, 19);
            this.lbnotif.TabIndex = 19;
            this.lbnotif.Text = "select login option first";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 591);
            this.Controls.Add(this.lbnotif);
            this.Controls.Add(this.linkregisteration);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtlogin_as);
            this.Controls.Add(this.lbloginas);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private System.Windows.Forms.Label lbusername;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private System.Windows.Forms.Label lbpassword;
        private Guna.UI2.WinForms.Guna2CheckBox showpassword;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Label lbloginas;
        private Guna.UI2.WinForms.Guna2ComboBox txtlogin_as;
        private System.Windows.Forms.LinkLabel linkregisteration;
        private System.Windows.Forms.Label lbnotif;
    }
}