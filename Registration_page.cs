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
using System.Data.SqlClient;
using System.IO;

namespace bus_management_system
{
    public partial class Registration_page : Form
    {
        byte[] imagebytes;

        public Registration_page()
        {
            InitializeComponent();
        }
        static string con = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(con);
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
                string filePath = openFileDialog.FileName;
                imagebytes=File.ReadAllBytes(filePath);
                profilepic.Image = Image.FromFile(filePath);
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

        public Boolean checkuniquepassword(string password)
        {
            string query = "select Password from Users where Password='" + password + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        void clear()
        {
            txtusernamereg.Clear();
            txtpasswordreg.Clear();
            txtcnicreg.Clear();
            txtphonereg.Clear();
            txtnamereg.Clear();
            txtemailreg.Clear();
            profilepic.Image = null;

        }
        private void btnregisteration_Click(object sender, EventArgs e)
        {
            if (isvalidadd())
            {
                if (checkuniquepassword(txtpasswordreg.Text))
                {
                    MessageBox.Show("Password already taken,please enter unique password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string query = "insert into Users (Name,Phone_No,Gmail,CNIC,Profile_pic,Username,Password) values(@Name,@Phone_no,@Gmail,@CNIC,@Profile_pic,@Username,@Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Name", txtnamereg.Text);
                        cmd.Parameters.AddWithValue("@Phone_no", txtphonereg.Text);
                        cmd.Parameters.AddWithValue("@Gmail", txtemailreg.Text);
                        cmd.Parameters.AddWithValue("@CNIC", txtcnicreg.Text);
                        cmd.Parameters.AddWithValue("@Profile_pic", imagebytes);
                        cmd.Parameters.AddWithValue("@Username", txtusernamereg.Text);
                        cmd.Parameters.AddWithValue("@Password", txtpasswordreg.Text);


                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Registered successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            Login login = new Login();
                            login.Show();
                            this.Hide();


                        }
                        imagebytes = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong\n" + ex.Message, "Errorx", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
