using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInverted
{
    /// <summary>
    /// 迴圈倒置 #1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串逗號分隔的字串 :");
            string input = Console.ReadLine();
            MethodByReverse(input);
            MethodByLoop(input);
            Console.ReadLine();
        }


        private static void MethodByReverse(string input)
        {
            // var chars = input.ToCharArray();
            var chars = input.ToArray();
            Array.Reverse(chars);
            var result = new string(chars);
            Display(result);
        }


        private static void MethodByLoop(string input)
        {
            string result = string.Empty;
            var chars = input.ToArray();
            for (int i = chars.Length - 1; i > -1; i--)
            {
                result += chars[i].ToString();
            }
            Display(result);
        }


        private static void Display(string value)
        {
            Console.Write("結果為 : ");
            Console.WriteLine(value);
        }
    }
}
