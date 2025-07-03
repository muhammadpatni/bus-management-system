using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        bool slidebarexpand;
        private void Dashboard_Load(object sender, EventArgs e)
        {

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
                }
            }
            else
            {
                slidebar.Width += 164;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    slidebartimer.Stop();
                }


            }
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }

        private void labellogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnmanagebook_Click(object sender, EventArgs e)
        {

        }

        private void btnliboperation_Click(object sender, EventArgs e)
        {

        }

        private void btnmemmanagement_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
