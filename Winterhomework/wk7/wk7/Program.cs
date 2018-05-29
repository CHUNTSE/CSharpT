using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c, d;
            Console.WriteLine("輸入四位數");
            string number = Console.ReadLine();
            x = int.Parse(number);
                d = x % 10;
                x = x / 10;
                c = x % 10;
                x = x / 10;
                b = x % 10;
                x = x / 10;
                a = x;

            switch(a)
            {
                case 1:
                    Console.Write("一");
                    break;
                case 2:
                    Console.Write("二");
                    break;
                case 3:
                    Console.Write("三");
                    break;
                case 4:
                    Console.Write("四");
                    break;
                case 5:
                    Console.Write("五");
                    break;
                case 6:
                    Console.Write("六");
                    break;
                case 7:
                    Console.Write("七");
                    break;
                case 8:
                    Console.Write("八");
                    break;
                case 9:
                    Console.Write("九");
                    break;
                case 0:
                    Console.Write("零");
                    break;
            }
            switch (b)
            {
                case 1:
                    Console.Write("一");
                    break;
                case 2:
                    Console.Write("二");
                    break;
                case 3:
                    Console.Write("三");
                    break;
                case 4:
                    Console.Write("四");
                    break;
                case 5:
                    Console.Write("五");
                    break;
                case 6:
                    Console.Write("六");
                    break;
                case 7:
                    Console.Write("七");
                    break;
                case 8:
                    Console.Write("八");
                    break;
                case 9:
                    Console.Write("九");
                    break;
                case 0:
                    Console.Write("零");
                    break;
            }
            switch (c)
            {
                case 1:
                    Console.Write("一");
                    break;
                case 2:
                    Console.Write("二");
                    break;
                case 3:
                    Console.Write("三");
                    break;
                case 4:
                    Console.Write("四");
                    break;
                case 5:
                    Console.Write("五");
                    break;
                case 6:
                    Console.Write("六");
                    break;
                case 7:
                    Console.Write("七");
                    break;
                case 8:
                    Console.Write("八");
                    break;
                case 9:
                    Console.Write("九");
                    break;
                case 0:
                    Console.Write("零");
                    break;
            }
            switch (d)
            {
                case 1:
                    Console.Write("一");
                    break;
                case 2:
                    Console.Write("二");
                    break;
                case 3:
                    Console.Write("三");
                    break;
                case 4:
                    Console.Write("四");
                    break;
                case 5:
                    Console.Write("五");
                    break;
                case 6:
                    Console.Write("六");
                    break;
                case 7:
                    Console.Write("七");
                    break;
                case 8:
                    Console.Write("八");
                    break;
                case 9:
                    Console.Write("九");
                    break;
                case 0:
                    Console.Write("零");
                    break;
            }

        }
    }
}
