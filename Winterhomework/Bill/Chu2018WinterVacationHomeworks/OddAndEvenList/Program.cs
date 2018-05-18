using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenList
{
    /// <summary>
    /// 奇偶數判斷 #2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串逗號分隔的大於零整數字串 :");
            string input = Console.ReadLine();
            string[] array = input.Split(new char[] { ',' });
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            bool ok = true;
            foreach (var item in array)
            {
                int number;
                if (int.TryParse(item, out number) && number > 0)
                {
                    if (Determine(number))
                    {
                        evens.Add(number);
                    }
                    else
                    {
                        odds.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine(string .Format ("有些不能轉為大於零整數 {0}", item));                   
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                DispalyOdds(odds);
                DispalyEvens(evens);
            }


            Console.ReadLine();
        }

        private static void DispalyOdds(List<int> value)
        {

            string result = GetResultString(value);
            Console.WriteLine(string.Format("奇數數列 : {0}", result));
        }

        private static void DispalyEvens(List<int> value)
        {
            string result = GetResultString(value);
            Console.WriteLine(string.Format("偶數數列 : {0}", result));
        }

        private static string GetResultString(List<int> value)
        {
            string result = string.Empty;
            foreach (var v in value.OrderBy((x) => x))
            {
                result += string.Format("{0},", v);
            }

            result = result.Remove(result.Length - 1);
            return result;
        }

        private static bool Determine(int number)
        {
            return (number % 2 == 0);

        }



    }
}
