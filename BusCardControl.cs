using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_management_system
{
    public partial class BusCardControl : UserControl
    {
        public BusCardControl()
        {
            InitializeComponent(); 
         
        }

       
        private void BusCardControl_Load(object sender, EventArgs e)
        {

        }

        public void SetBusData(string busName, string registrationNo, string fromCity,string toCity,string travelDate,string travelTime,string busType,string driverName,string seats,string pkr)
        {
            lbbusname.Text = busName;
            lbbusregno.Text = registrationNo;
            lbfromcity.Text = fromCity;
            lbtocity.Text = toCity;
            lbtraveldate.Text = travelDate;
            lbtraveltime.Text = travelTime;
            lbbustype.Text = busType;
            lbbusdrivername.Text = driverName;
            lbNoOfSeat.Text = seats;
            lbpkr.Text = pkr;
        }

       
    }
}
