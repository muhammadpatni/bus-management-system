using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Guna.UI2.WinForms;

namespace bus_management_system
{
    public partial class ucuserprofile : UserControl
    {
        public ucuserprofile()
        {
            InitializeComponent();
            Form_Manager.ucuserprofile_page = this;

        }
        static String con = ConnectionString.getConnectionString;
        SqlConnection conn = new SqlConnection(con);
        byte[] imagebytes;

        private void ucuserprofile_Load(object sender, EventArgs e)
        {
            getcurrentdataofuser();

        }

        public void getcurrentdataofuser()
        {
            string query = "select * from Users where CNIC='" + Form_Manager.login_page.cnic + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtnameprofile.Text = dt.Rows[0]["Name"].ToString();
                txtphoneprofile.Text = dt.Rows[0]["Phone_No"].ToString();
                txtcnicprofile.Text = dt.Rows[0]["CNIC"].ToString();
                txtemailprofile.Text = dt.Rows[0]["Gmail"].ToString();
                txtusername.Text = dt.Rows[0]["Username"].ToString();
                txtpassword.Text = dt.Rows[0]["Password"].ToString();

                using (MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["profile_pic"]))
                {
                    Image img = Image.FromStream(ms);
                    profilepic.Image = img;
                    profilepic.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagebytes = null;
                }

                pbname.Image = Properties.Resources.icons8_edit_30__1_;
                pbemail.Image = Properties.Resources.icons8_edit_30__1_;
                pbphone.Image = Properties.Resources.icons8_edit_30__1_;
            }

        }

        private void profilepicedit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a Picture";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Multiselect = false;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    imagebytes = File.ReadAllBytes(filePath);
                    profilepic.Image = Image.FromFile(filePath);
                    profilepic.SizeMode = PictureBoxSizeMode.StretchImage;

                    string query = "update Users set Profile_pic = @Profile_pic where CNIC=@cnic";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Profile_pic", imagebytes);
                        cmd.Parameters.AddWithValue("@cnic", txtcnicprofile.Text);
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)

                        {
                            Form_Manager.user_dashboard.profilepic.Image = Image.FromFile(filePath);
                        }
                        imagebytes = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtusername.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                txtusername.UseSystemPasswordChar = true;
            }
        }
        private void pbname_Click_1(object sender, EventArgs e)
        {

            if (pbname.Tag.ToString() == "edit")
            {
                pbname.Image = Properties.Resources.icons8_done_30;
                pbname.Tag = "done";
                txtnameprofile.ReadOnly = false;
                pbphone.Image = Properties.Resources.icons8_edit_30__1_;
                pbemail.Image = Properties.Resources.icons8_edit_30__1_;
                txtphoneprofile.ReadOnly = true;
                txtemailprofile.ReadOnly = true;


            }
            else if (pbname.Tag.ToString() == "done")
            {
                string query = "update Users set Name = @value where CNIC=@cnic";
                update(pbname, query, txtcnicprofile.Text, txtnameprofile);
                Form_Manager.user_dashboard.lbusername.Text = txtnameprofile.Text;

            }
        }
        private void pbphone_Click(object sender, EventArgs e)
        {
            if (pbphone.Tag.ToString() == "edit")
            {
                pbphone.Image = Properties.Resources.icons8_done_30;
                pbphone.Tag = "done";
                txtphoneprofile.ReadOnly = false;
                pbname.Image = Properties.Resources.icons8_edit_30__1_;
                pbemail.Image = Properties.Resources.icons8_edit_30__1_;
                txtnameprofile.ReadOnly = true;
                txtemailprofile.ReadOnly = true;
            }
            else if (pbphone.Tag.ToString() == "done")

            {
                string query = "update Users set Phone_No = @value where CNIC=@cnic";
                update(pbphone, query, txtcnicprofile.Text, txtphoneprofile);

            }
        }
        public Boolean isvalidadd()
        {
            if (string.IsNullOrEmpty(txtnameprofile.Text))
            {
                MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (string.IsNullOrEmpty(txtemailprofile.Text))
            {
                MessageBox.Show("Please enter Gmail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (string.IsNullOrEmpty(txtphoneprofile.Text))
            {
                MessageBox.Show("Please enter Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (!double.TryParse(txtphoneprofile.Text, out _))
            {
                MessageBox.Show("phone should be in numeric and without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtphoneprofile.Text.Length != 11)
            {
                MessageBox.Show("Phone No Should be 11 without dashes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }

        private void pbemail_Click(object sender, EventArgs e)
        {
            if (pbemail.Tag.ToString() == "edit")
            {
                pbemail.Image = Properties.Resources.icons8_done_30;
                pbemail.Tag = "done";
                txtemailprofile.ReadOnly = false;
                pbname.Image = Properties.Resources.icons8_edit_30__1_;
                pbphone.Image = Properties.Resources.icons8_edit_30__1_;
                txtnameprofile.ReadOnly = true;
                txtphoneprofile.ReadOnly = true;
            }
            else if (pbemail.Tag.ToString() == "done")
            {
                string query = "update Users set Gmail = @value where CNIC=@cnic";
                update(pbemail, query, txtcnicprofile.Text, txtemailprofile);
            }
        }
        public void update(PictureBox picturebox, string query, string cnic, Guna2TextBox textbox)
        {
            if (isvalidadd())
            {
                picturebox.Image = Properties.Resources.icons8_edit_30__1_;
                picturebox.Tag = "edit";
                textbox.ReadOnly = true;
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@value", textbox.Text);
                        cmd.Parameters.AddWithValue("@cnic", cnic);
                        int rowsaffected = cmd.ExecuteNonQuery();

                    }
                    getcurrentdataofuser();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void interface_adjusment(Boolean is_minimize)
        {
            if (is_minimize)
            {
                lbprofile.Location = new Point(515, 0);
                personalpanel.Size = new Size(1076, 3);
                profilepic.Location = new Point(950, 106);
                profilepicedit.Location = new Point(1005, 269);
                lbprofilepicture.Location = new Point(965, 292);
                loginpanel.Size = new Size(1100, 3);
                showpassword.Location = new Point(962, 481);

            }
            else
            {
                lbprofile.Location = new Point(399, 0);
                personalpanel.Size = new Size(898, 3);
                profilepic.Location = new Point(771, 106);
                profilepicedit.Location = new Point(836, 269);
                lbprofilepicture.Location = new Point(793, 292);
                loginpanel.Size = new Size(922, 3);
                showpassword.Location = new Point(790, 481);
            }

        }

        private void lbprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

