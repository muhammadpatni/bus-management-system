using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static String Constring = "Data Source=DESKTOP-PQ222BO\\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
        SqlConnection con = new SqlConnection(Constring);

        public void perform_login()
        { 
            string query = "SELECT * FROM login WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "' AND login_as ='"+txtlogin_as.Text+"' ";
            DataTable dt = new DataTable(); 
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["login_as"].ToString().ToLower();

                    if (role == "admin")
                    {
                        MessageBox.Show("Admin login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "user")
                    {
                        MessageBox.Show("User login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    
                    else
                    {
                        MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        }
    }
}
