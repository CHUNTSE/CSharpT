using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopInverted
{
    /// <summary>
    /// 迴圈倒置 #2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於零的整數 :");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number) && number >0)
            {
                Display(number);
            }
            else
            {
                Console.WriteLine("無法轉換為整數");
            }
            Console.ReadLine();
        }

        private static void Display(int number)
        {
            int count = 1;
            while (number > 0 )
            {
                for(int i=0; i < count; i++)
                {
                    Console.Write(number); 
                }
                Console.WriteLine();
                number--;
                count++;
            }
        }
    }
}
