using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_management_system
{
    public static class Form_Manager
    {
        public static Login login_page { get; set; }
        public static Registration_page registation_page { get; set; }

        public static Dashboard user_dashboard { get; set; }

        public static ucuserbook ucuserbook_page { get; set; }

        public static ucuserdashboard ucuserdashboard_page { get; set; }

        public static ucusermybookings ucusermybookings_page { get; set; }

        public static ucuserprofile ucuserprofile_page { get; set; }
    }
}
