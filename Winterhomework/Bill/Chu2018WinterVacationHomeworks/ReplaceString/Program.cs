using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串阿拉伯數字 :");
            var input = Console.ReadLine();
             ReplaceByString(input);
            Console.ReadLine();
        }

     

        private static void ReplaceByString(string input)
        {
            var data = GetDictionary();
            for (int i = 0; i < 10; i++)
            {
                input = input.Replace(i.ToString(), data[i]);
            }
            Display(input);            
        }

        private static void Display(string value)
        {
            Console.WriteLine(value);
        }

        private static Dictionary<int, string> GetDictionary()
        {
            return new Dictionary<int, string>
            {
               {0,"零" },
               {1,"一" },
               {2,"二" },
               {3,"三" },
               {4,"四" },
               {5,"五" },
               {6,"六" },
               {7,"七" },
               {8,"八" },
               {9,"九" }
            };

        }


    }
}
