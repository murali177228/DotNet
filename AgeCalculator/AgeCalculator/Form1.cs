using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            lblCurrentAge.Text = calcAge(startDate, endDate).ToString();

            
        }
        public long calcAge(System.DateTime startDate, System.DateTime endDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(endDate.Ticks- startDate.Ticks);
            age = (long)(ts.Days/365);
            return age;
        }
    }
}
