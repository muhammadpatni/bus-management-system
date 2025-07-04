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

namespace bus_management_system
{
    public partial class ucuserprofile : UserControl
    {
        public ucuserprofile()
        {
            InitializeComponent();
            Form_Manager.ucuserprofile_page = this;

        }
        static string con = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(con);
        byte[] imagebytes;

        private void ucuserprofile_Load(object sender, EventArgs e)
        {
            getcurrentdataofuser();

        }     

        public void getcurrentdataofuser()
        {
            string query = "select * from Users where CNIC='"+Form_Manager.login_page.cnic+"'";
            DataTable dt = new DataTable();
               SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                  txtnameprofile.Text = dt.Rows[0]["Name"].ToString();
                   txtphoneprofile.Text = dt.Rows[0]["Phone_No"].ToString();
                   txtcnicprofile.Text = dt.Rows[0]["CNIC"].ToString();
                 txtemailprofile.Text= dt.Rows[0]["Gmail"].ToString();
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
                pbcnic.Image = Properties.Resources.icons8_edit_30__1_;
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
                        cmd.Parameters.AddWithValue("@cnic",txtcnicprofile.Text);
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)

                        {
                            Form_Manager.user_dashboard.profilepic.Image = Image.FromFile(filePath);
                        }
                        imagebytes = null;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtusername.UseSystemPasswordChar=false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                txtusername.UseSystemPasswordChar = true;
            }
        }

        private void pbname_Click(object sender, EventArgs e)
        {
            
        }

        private void pbname_Click_1(object sender, EventArgs e)
        {
            if (pbname.Image == Properties.Resources.icons8_edit_30__1_)
            {
                pbname.Image = Properties.Resources.icons8_done_30;
                txtnameprofile.ReadOnly = false;
            }
            else if (pbname.Image == Properties.Resources.icons8_done_30)
            {
                pbname.Image = Properties.Resources.icons8_edit_30__1_;
                txtnameprofile.ReadOnly = true;
               try  {
                        string query = "update Users set Name = @name where CNIC=@cnic";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@name", txtnameprofile);
                            cmd.Parameters.AddWithValue("@cnic", txtcnicprofile.Text);
                            int rowsaffected = cmd.ExecuteNonQuery();
                            if (rowsaffected > 0)

                            {
                            }getcurrentdataofuser();
                        }
                    }
                
            catch(Exception ex)
            {
                    MessageBox.Show("Something went wrong" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

