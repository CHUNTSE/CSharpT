using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 千元買百雞
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickboy, chickgril, chick;

            for (int x = 1; x <= 16; x++)
            {
                if ((900 - (59 * x)) % 29 == 0)
                {

                    chickgril = (900 - (59 * x)) / 29;
                    chickboy = (900 - (chickgril * 29)) / 59;
                    chick = 100 - chickboy - chickgril;
                    Console.WriteLine($"公雞有:{chickboy} 母雞有:{chickgril} 小雞有:{chick}");
                }
            }
        }
    }
}
