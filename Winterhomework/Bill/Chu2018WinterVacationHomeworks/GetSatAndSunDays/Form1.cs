using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSatAndSunDays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse (inputTextBox.Text, out year ))
            {

                DateTime firstSat = GetFirstDay(DayOfWeek.Saturday , year);
                DateTime firstSun = GetFirstDay(DayOfWeek.Sunday, year);                                      
                DateTime end = new DateTime(year, 12, 31);             
                satLabel.Text = GetDaysCount(firstSat, end).ToString();
                sunLabel.Text = GetDaysCount(firstSun, end).ToString();
            }
            else
            {
                MessageBox.Show("字串無法轉換為數字"); 
            }
        }

        private static int GetDaysCount(DateTime first, DateTime end)
        {
            DateTime current = first;
            int result = 0;
            do
            {
                result++;
                System.Diagnostics.Debug.WriteLine($"{result} : {current.DayOfWeek}");
                current = current.AddDays(7);
            } while (current <= end);

            return result;
        }

        private DateTime GetFirstDay(DayOfWeek day,int year)
        {
            DateTime begin = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            DateTime current = begin;
            while (current <= end)
            {               
                if (current.DayOfWeek == day)
                {
                    break;
                }
                current = current.AddDays(1); 
            }
            return current;
        }
        

    }
}
