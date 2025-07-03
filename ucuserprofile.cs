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
        }
        static string con = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(con);

        public void load_data()
        {
            
        }
        private void ucuserprofile_Load(object sender, EventArgs e)
        {

        }
        byte[] imagebytes;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {

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

                    string query = "update Users set Profile_pic = @Profile_pic";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Profile_pic", imagebytes);
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
                MessageBox.Show("Something went wrong", "Errorx", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
