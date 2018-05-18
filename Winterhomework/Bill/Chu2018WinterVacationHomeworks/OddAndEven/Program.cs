using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEven
{
    /// <summary>
    /// 奇偶數判斷 #1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於零數字 :");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number) && number > 0)
            {
                Dispaly(input, number);
            }
            else
            {
                Console.WriteLine("無法轉換為大於1的整數");
            }
            Console.ReadLine();
        }

        private static void Dispaly(string input, int number)
        {
            if (Determine(number))
            {
                Console.WriteLine($"{input} 為偶數");
            }
            else
            {
                Console.WriteLine($"{input} 為奇數");
            }
        }

        private static bool Determine(int number)
        {
            return (number % 2 == 0);

        }
    }
}
