using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數101到200
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        if (count > 1)
                            break;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
