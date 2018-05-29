using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("輸入一個數字 : ");
            string input = Console.ReadLine();
            a = int.Parse(input);
            if (a != 0)
            {
                b = a % 2;
                switch (b)
                {
                    case 0:
                        Console.WriteLine("這是個偶數");
                        break;
                    case 1:
                        Console.WriteLine("這是個奇數");
                        break;
                }
            }
            else
            {
                Console.WriteLine("這不是奇數也不是偶數");
            }
        }
    }
}
