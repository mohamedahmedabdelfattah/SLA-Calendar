using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SLACalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays = 1 + ((endD - startD).TotalDays * 5 - (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if ((int)endD.DayOfWeek == 6) calcBusinessDays--;
            if ((int)startD.DayOfWeek == 0) calcBusinessDays--;

            return calcBusinessDays;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DateTime oldDate = SLAStart.Value.Date;
            DateTime newDate = SLAStart.Value.Date.AddDays(Convert.ToDouble(txtSLA.Text));

            TimeSpan ts = newDate - oldDate;

            int differenceInDays = ts.Days;

            MessageBox.Show(differenceInDays.ToString());

            MessageBox.Show(GetBusinessDays(oldDate, newDate).ToString());
        }
    }
}
