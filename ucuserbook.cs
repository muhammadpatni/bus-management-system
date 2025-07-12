using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_management_system
{
    public partial class ucuserbook : UserControl
    {

        public ucuserbook()
        {

            InitializeComponent();
            Form_Manager.ucuserbook_page = this;

        }
        static String con = ConnectionString.getConnectionString;
        SqlConnection conn = new SqlConnection(con);
        public void Clear()
        {
            combofromcity.SelectedIndex = -1;
            combotocity.SelectedIndex = -1;
            combobustype.SelectedIndex = -1;
            datesearchbus.Value = DateTime.Now;

        }
        private void btnsearchclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnsearchbus_Click(object sender, EventArgs e)
        {
            string selectedDate = datesearchbus.Value.ToString("yyyy-MM-dd");

            string query = @"SELECT RegistrationNo, BusName, DriverName, FromCity, ToCity, TravelDate, TravelTime, NumberOfSeats, BusType, Fare 
                     FROM Bus WHERE FromCity = @fromcity AND ToCity = @tocity AND BusType = @bustype AND TravelDate = @traveldate";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@fromcity", combofromcity.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@tocity", combotocity.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@bustype", combobustype.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@traveldate", selectedDate);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No buses found for selected criteria.");
                return;
            }
            datashowpanel.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                BusCardControl card = new BusCardControl();
                card.SetBusData(
                    row["BusName"].ToString(),
                    row["RegistrationNo"].ToString(),
                    row["FromCity"].ToString(),
                    row["ToCity"].ToString(),
                    Convert.ToDateTime(row["TravelDate"]).ToString("dd-MM-yyyy"),
                    row["TravelTime"].ToString(),
                    row["BusType"].ToString(),
                    row["DriverName"].ToString(),
                    row["NumberOfSeats"].ToString(),
                    row["Fare"].ToString() + " PKR"
                );
                datashowpanel.Controls.Add(card);
            }
            panelsearcching.Visible = false;

            datashowpanel.Visible = true;
            datashowpanel.BringToFront();
            datashowpanel.Dock = DockStyle.Fill;

        }


        private void tittlebarpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucuserbook_Load(object sender, EventArgs e)
        {
            panelsearcching.Visible = true;
            panelsearcching.Dock = DockStyle.Fill;

            datashowpanel.Visible = false;
            datashowpanel.Dock = DockStyle.Fill;
        }
    }
}
