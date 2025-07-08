using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_management_system
{ 
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Form_Manager.user_dashboard = this;
        }

        bool slidebarexpand;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(Form_Manager.login_page.profile_pic))
            {
                Image img = Image.FromStream(ms);
                profilepic.Image = img;
                profilepic.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            lbusername.Text = Form_Manager.login_page.name;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slidebartime_Tick(object sender, EventArgs e)
        {
            if (slidebarexpand)
            {
                slidebar.Width -= 58;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarexpand = false;
                    slidebartimer.Stop();
                    lbtitle.Location = new Point(401, 7);
                    profilepic.Location = new Point(6, 38);
                    profilepic.Size = new Size(55, 55);
                    lbusername.Visible = false;
                    if(Form_Manager.ucuserprofile_page != null)
                    {
                        Form_Manager.ucuserprofile_page.interface_adjusment(true);
                    }
                }

            }
            else
            {
                slidebar.Width += 164;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    slidebartimer.Stop();
                    lbtitle.Location = new Point(309, 6);
                    profilepic.Location = new Point(44, 2);
                    profilepic.Size = new Size(177, 177);
                    lbusername.Visible = true;
                    if (Form_Manager.ucuserprofile_page != null)
                    {
                        Form_Manager.ucuserprofile_page.interface_adjusment(false);
                    }
                }


            }
        }

        public void loadform(UserControl uc)
        {
            if (this.panelmain.Controls.Count > 0)
            {
                this.panelmain.Controls.RemoveAt(0);
            }
            uc.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(uc);
            this.panelmain.Tag = uc;
        }



        private void btndashboard_Click(object sender, EventArgs e)
        {
            btndashboarduser.FillColor = System.Drawing.Color.MediumSeaGreen;
            btnmybookinguser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnbookuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnprofileuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            loadform(new ucuserdashboard());
        
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnmenu_Click(object sender, EventArgs e)
        {
            slidebartimer.Start();
        }

        private void btnmybookinguser_Click(object sender, EventArgs e)
        {
            btnmybookinguser.FillColor = System.Drawing.Color.MediumSeaGreen;
            btndashboarduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnbookuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnprofileuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            loadform(new ucusermybookings());

        }

        private void btnbookuser_Click(object sender, EventArgs e)
        {
            btnbookuser.FillColor = System.Drawing.Color.MediumSeaGreen;
            btnmybookinguser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btndashboarduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnprofileuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            loadform(new ucuserbook());
        }

        


        private void btnprofileuser_Click(object sender, EventArgs e)
        {
            btnprofileuser.FillColor = System.Drawing.Color.MediumSeaGreen;
            btnmybookinguser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnbookuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btndashboarduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            loadform(new ucuserprofile());

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            btnlogout.FillColor = System.Drawing.Color.MediumSeaGreen;
            btnmybookinguser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnbookuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btnprofileuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            btndashboarduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));

            Login login=new Login();
            login.Show();
            this.Hide();
        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
