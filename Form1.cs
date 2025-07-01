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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressbar.Value < 100)
            {
                progressbar.Value += 1;
                label2.Text = progressbar.Value.ToString() + "%";
            }
            else
            {
            timer1.Stop();
                Application.Exit();
            }
        }
    }
}
