using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("輸入年份");
            string year = Console.ReadLine();
            x = int.Parse(year);
            y = x % 4;
            if(y == 0)
            {
                Console.WriteLine("今年為閏年");
            }
            else
            {
                Console.WriteLine("今年為一般年");
            }
        }
    }
}
