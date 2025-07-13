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
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Resize += BusCardControl_Resize;
            SetRoundedRegion(20);
        }

        private void BusCardControl_Resize(object sender, EventArgs e)
        {
            SetRoundedRegion(20); // 20 is the corner radius
        }

        private void SetRoundedRegion(int radius)
        {
            var path = new GraphicsPath();
            int arcSize = radius * 2;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, arcSize, arcSize), 180, 90); // Top-left
            path.AddArc(new Rectangle(this.Width - arcSize, 0, arcSize, arcSize), 270, 90); // Top-right
            path.AddArc(new Rectangle(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize), 0, 90); // Bottom-right
            path.AddArc(new Rectangle(0, this.Height - arcSize, arcSize, arcSize), 90, 90); // Bottom-left
            path.CloseFigure();
            this.Region = new Region(path);
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
