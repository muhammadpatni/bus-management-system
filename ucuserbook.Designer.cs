namespace bus_management_system
{
    partial class ucuserbook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbprofile = new System.Windows.Forms.LinkLabel();
            this.tittlebarpanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelsearcching = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.datashowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.seachmainpanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnsearchclear = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combofromcity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combobustype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnsearchbus = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combotocity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datesearchbus = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tittlebarpanel.SuspendLayout();
            this.panelsearcching.SuspendLayout();
            this.seachmainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbprofile
            // 
            this.lbprofile.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.lbprofile.AutoSize = true;
            this.lbprofile.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.lbprofile.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprofile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.lbprofile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.lbprofile.Location = new System.Drawing.Point(342, 0);
            this.lbprofile.Name = "lbprofile";
            this.lbprofile.Size = new System.Drawing.Size(345, 65);
            this.lbprofile.TabIndex = 60;
            this.lbprofile.TabStop = true;
            this.lbprofile.Text = "Searching Bus";
            this.lbprofile.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            // 
            // tittlebarpanel
            // 
            this.tittlebarpanel.Controls.Add(this.lbprofile);
            this.tittlebarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tittlebarpanel.Location = new System.Drawing.Point(0, 0);
            this.tittlebarpanel.Name = "tittlebarpanel";
            this.tittlebarpanel.Size = new System.Drawing.Size(1042, 63);
            this.tittlebarpanel.TabIndex = 62;
            this.tittlebarpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tittlebarpanel_Paint);
            // 
            // panelsearcching
            // 
            this.panelsearcching.Controls.Add(this.seachmainpanel);
            this.panelsearcching.Location = new System.Drawing.Point(218, 199);
            this.panelsearcching.Name = "panelsearcching";
            this.panelsearcching.ShadowDecoration.BorderRadius = 0;
            this.panelsearcching.Size = new System.Drawing.Size(164, 184);
            this.panelsearcching.TabIndex = 63;
            // 
            // datashowpanel
            // 
            this.datashowpanel.AutoScroll = true;
            this.datashowpanel.BackColor = System.Drawing.Color.White;
            this.datashowpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.datashowpanel.Location = new System.Drawing.Point(493, 251);
            this.datashowpanel.Name = "datashowpanel";
            this.datashowpanel.Padding = new System.Windows.Forms.Padding(5);
            this.datashowpanel.Size = new System.Drawing.Size(97, 44);
            this.datashowpanel.TabIndex = 63;
            this.datashowpanel.WrapContents = false;
            // 
            // seachmainpanel
            // 
            this.seachmainpanel.BackColor = System.Drawing.Color.Transparent;
            this.seachmainpanel.Controls.Add(this.btnsearchclear);
            this.seachmainpanel.Controls.Add(this.label3);
            this.seachmainpanel.Controls.Add(this.combofromcity);
            this.seachmainpanel.Controls.Add(this.combobustype);
            this.seachmainpanel.Controls.Add(this.btnsearchbus);
            this.seachmainpanel.Controls.Add(this.label1);
            this.seachmainpanel.Controls.Add(this.combotocity);
            this.seachmainpanel.Controls.Add(this.label2);
            this.seachmainpanel.Controls.Add(this.datesearchbus);
            this.seachmainpanel.Controls.Add(this.label8);
            this.seachmainpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(194)))), ((int)(((byte)(155)))));
            this.seachmainpanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(39)))));
            this.seachmainpanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(36)))));
            this.seachmainpanel.FillColor4 = System.Drawing.Color.MediumSeaGreen;
            this.seachmainpanel.Location = new System.Drawing.Point(314, 114);
            this.seachmainpanel.Name = "seachmainpanel";
            this.seachmainpanel.ShadowDecoration.BorderRadius = 30;
            this.seachmainpanel.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.seachmainpanel.ShadowDecoration.Depth = 50;
            this.seachmainpanel.ShadowDecoration.Enabled = true;
            this.seachmainpanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 15, 13);
            this.seachmainpanel.Size = new System.Drawing.Size(395, 418);
            this.seachmainpanel.TabIndex = 57;
            // 
            // btnsearchclear
            // 
            this.btnsearchclear.BorderRadius = 15;
            this.btnsearchclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearchclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearchclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnsearchclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsearchclear.ForeColor = System.Drawing.Color.White;
            this.btnsearchclear.Location = new System.Drawing.Point(209, 363);
            this.btnsearchclear.Name = "btnsearchclear";
            this.btnsearchclear.Size = new System.Drawing.Size(158, 45);
            this.btnsearchclear.TabIndex = 58;
            this.btnsearchclear.Text = "Clear";
            this.btnsearchclear.Click += new System.EventHandler(this.btnsearchclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(14, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Date";
            // 
            // combofromcity
            // 
            this.combofromcity.BackColor = System.Drawing.Color.Transparent;
            this.combofromcity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.combofromcity.BorderRadius = 7;
            this.combofromcity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combofromcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofromcity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combofromcity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combofromcity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.combofromcity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.combofromcity.ItemHeight = 30;
            this.combofromcity.Items.AddRange(new object[] {
            "Bahawalpur",
            "Faisalabad",
            "Hyderabad",
            "Islamabad",
            "Karachi",
            "Lahore",
            "Multan",
            "Peshawar",
            "Quetta",
            "Sialkot"});
            this.combofromcity.Location = new System.Drawing.Point(105, 22);
            this.combofromcity.Name = "combofromcity";
            this.combofromcity.Size = new System.Drawing.Size(264, 36);
            this.combofromcity.TabIndex = 48;
            // 
            // combobustype
            // 
            this.combobustype.BackColor = System.Drawing.Color.Transparent;
            this.combobustype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.combobustype.BorderRadius = 7;
            this.combobustype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobustype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobustype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobustype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobustype.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.combobustype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.combobustype.ItemHeight = 30;
            this.combobustype.Items.AddRange(new object[] {
            "AC",
            "Non-AC",
            "Sleeper"});
            this.combobustype.Location = new System.Drawing.Point(105, 162);
            this.combobustype.Name = "combobustype";
            this.combobustype.Size = new System.Drawing.Size(264, 36);
            this.combobustype.TabIndex = 49;
            // 
            // btnsearchbus
            // 
            this.btnsearchbus.BorderRadius = 15;
            this.btnsearchbus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchbus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearchbus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearchbus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearchbus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.btnsearchbus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsearchbus.ForeColor = System.Drawing.Color.White;
            this.btnsearchbus.Location = new System.Drawing.Point(40, 363);
            this.btnsearchbus.Name = "btnsearchbus";
            this.btnsearchbus.Size = new System.Drawing.Size(158, 45);
            this.btnsearchbus.TabIndex = 57;
            this.btnsearchbus.Text = "Search";
            this.btnsearchbus.Click += new System.EventHandler(this.btnsearchbus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "To City";
            // 
            // combotocity
            // 
            this.combotocity.BackColor = System.Drawing.Color.Transparent;
            this.combotocity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.combotocity.BorderRadius = 7;
            this.combotocity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combotocity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotocity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combotocity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combotocity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.combotocity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.combotocity.ItemHeight = 30;
            this.combotocity.Items.AddRange(new object[] {
            "Bahawalpur",
            "Faisalabad",
            "Hyderabad",
            "Islamabad",
            "Karachi",
            "Lahore",
            "Multan",
            "Peshawar",
            "Quetta",
            "Sialkot"});
            this.combotocity.Location = new System.Drawing.Point(105, 92);
            this.combotocity.Name = "combotocity";
            this.combotocity.Size = new System.Drawing.Size(264, 36);
            this.combotocity.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Bus Type";
            // 
            // datesearchbus
            // 
            this.datesearchbus.BackColor = System.Drawing.Color.Transparent;
            this.datesearchbus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.datesearchbus.BorderRadius = 10;
            this.datesearchbus.BorderThickness = 1;
            this.datesearchbus.Checked = true;
            this.datesearchbus.CustomFormat = "dd-MM-yyyy";
            this.datesearchbus.FillColor = System.Drawing.Color.White;
            this.datesearchbus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datesearchbus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.datesearchbus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datesearchbus.Location = new System.Drawing.Point(105, 232);
            this.datesearchbus.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datesearchbus.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datesearchbus.Name = "datesearchbus";
            this.datesearchbus.Size = new System.Drawing.Size(264, 36);
            this.datesearchbus.TabIndex = 51;
            this.datesearchbus.Value = new System.DateTime(2025, 7, 9, 20, 23, 24, 823);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label8.Location = new System.Drawing.Point(14, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "From City";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this.seachmainpanel;
            // 
            // ucuserbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.datashowpanel);
            this.Controls.Add(this.panelsearcching);
            this.Controls.Add(this.tittlebarpanel);
            this.Name = "ucuserbook";
            this.Size = new System.Drawing.Size(1042, 644);
            this.Load += new System.EventHandler(this.ucuserbook_Load);
            this.tittlebarpanel.ResumeLayout(false);
            this.tittlebarpanel.PerformLayout();
            this.panelsearcching.ResumeLayout(false);
            this.seachmainpanel.ResumeLayout(false);
            this.seachmainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbprofile;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel tittlebarpanel;
        private Guna.UI2.WinForms.Guna2Button btnsearchclear;
        private Guna.UI2.WinForms.Guna2Button btnsearchbus;
        private Guna.UI2.WinForms.Guna2ComboBox combotocity;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox combofromcity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox combobustype;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datesearchbus;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel seachmainpanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelsearcching;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel datashowpanel;
    }
}
