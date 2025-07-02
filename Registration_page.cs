using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bus_management_system
{
    public partial class Registration_page : Form
    {
        public Registration_page()
        {
            InitializeComponent();
        }

        private void Registration_page_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        public Boolean isvalidadd()
        {
            if (string.IsNullOrEmpty(txtusernamereg.Text))
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtpasswordreg.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtnamereg.Text))
            {
                MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtcnicreg.Text))
            {
                MessageBox.Show("Please enter   CNIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtcnicreg.Text.Length != 13)
            {
                MessageBox.Show("CNIC No Should be 13 without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (string.IsNullOrEmpty(txtemailreg.Text))
            {
                MessageBox.Show("Please enter Gmail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!double.TryParse(txtphonereg.Text, out _))
            {
                MessageBox.Show("phone should be in numeric and without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtphonereg.Text))
            {
                MessageBox.Show("Please enter Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtphonereg.Text.Length != 11)
            {
                MessageBox.Show("Phone No Should be 11 without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (!double.TryParse(txtcnicreg.Text, out _))
            {
                MessageBox.Show("cnic should be in numeric and without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (profilepic.Image == null)
            {
                MessageBox.Show("Please upload your profile picture first.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void upload_profile_pic()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a Picture";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Load image in PictureBox
                profilepic.Image = Image.FromFile(openFileDialog.FileName);
                profilepic.SizeMode = PictureBoxSizeMode.StretchImage;
                label13.Visible = false;

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
           upload_profile_pic();

        }

        private void profilepic_Click(object sender, EventArgs e)
        {
            upload_profile_pic();
        }
    }
}
