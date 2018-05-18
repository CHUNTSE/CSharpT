using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwanLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入民國年 :");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number) && number > 0)
            {
                TaiwanCalendar tw = new TaiwanCalendar();
                Console.WriteLine(tw.IsLeapYear(number));
            }
            else
            {
                Console.WriteLine("無法轉換為整數");
            }

            Console.ReadLine();
        }
    }
}
