using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace bus_management_system
{
    public partial class Login : Form
    {
        private string Adminusername1="Muhammad",Adminpassword1= "bse23f098";
        private string Adminusername2 = "Haram pagal", Adminpassword2 = "bse23f137";

       public string name;
        public string phone_no;
        public string cnic;
         public string gmail;
         public byte[] profile_pic;

        public Boolean checkloginforadmin(string username, string password)
        {
            if (Adminusername1 == username && Adminpassword1 == password)
            {
                return true;
            }
            else if (Adminusername2 == username && Adminpassword2 == password)
            {
                return true;
            }
            return false;

        }
        public Login()
        {
            InitializeComponent();
        }
       static String Constring = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        SqlConnection con = new SqlConnection(Constring);

        public void perform_login()
        {
            string role = txtlogin_as.Text;
            if (role == "admin")
            {
                if (checkloginforadmin(txtusername.Text, txtpassword.Text))
                {
                    MessageBox.Show("Admin login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else {
                string query = "SELECT Name,Phone_No,CNIC,Gmail,Profile_pic FROM Users WHERE Username = '" + txtusername.Text + "' AND Password = '" + txtpassword.Text + "'";
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        // Save data to globally accessible login_page
                        Form_Manager.login_page = new Login(); // or: new UserSession(); if you use a separate class

                        Form_Manager.login_page.name = dt.Rows[0]["Name"].ToString();
                        Form_Manager.login_page.phone_no = dt.Rows[0]["Phone_No"].ToString();
                        Form_Manager.login_page.cnic = dt.Rows[0]["CNIC"].ToString();
                        Form_Manager.login_page.gmail = dt.Rows[0]["Gmail"].ToString();
                        Form_Manager.login_page.profile_pic = dt.Rows[0]["profile_pic"] != DBNull.Value
                            ? (byte[])dt.Rows[0]["profile_pic"]
                            : null;


                        MessageBox.Show("User login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong ", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            perform_login();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            txtusername.Select(0, 0);
            txtpassword.Select(0, 0);
        }
         

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            txtusername.Text = "";
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.Text = "";
            txtpassword.UseSystemPasswordChar = true;
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                perform_login();
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlogin_as_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnotif.Visible = false;
            txtpassword.Enabled = true;
            txtusername.Enabled = true;
            btnlogin.Enabled=true;
            showpassword.Enabled = true;
         

            if (txtlogin_as.Text == "admin")
            {
                
                linkregisteration.Visible = false;
            }
            else
            {
               
                linkregisteration.Visible = true;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_page registration_Page= new Registration_page();
            registration_Page.Show();
            this.Hide();
        }

        private void txtlogin_as_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
