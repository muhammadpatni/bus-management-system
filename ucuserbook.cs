using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void ucuserbook_Load(object sender, EventArgs e)
        {

        }
    }
}
