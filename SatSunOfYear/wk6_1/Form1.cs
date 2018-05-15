using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text.ToString())+1911;
            int Satday = 0;
            int Sunday = 0;
            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(year, month, 1);
                do
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        Satday++;
                    }
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Sunday++;
                    }
                    date = date.AddDays(1);
                }
                while (date.Month == month);
            }
            label1.Text = string.Format("{0}年有{1}个周六", year, Satday);
            label2.Text = string.Format("{0}年有{1}个周日", year, Sunday);
        }
    }
}
