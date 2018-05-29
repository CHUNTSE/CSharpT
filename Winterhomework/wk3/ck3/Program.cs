using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,n=1;
            Console.WriteLine("請輸入一個整數數字");
            string input = Console.ReadLine();
            Console.WriteLine();
            a = int.Parse(input);
            for (int x = a; x > 1; x--)
            {
                for(int y = 0; y < a; y++)
                {
                    for(int z=0;z<n;z++)
                    Console.Write(a);
                    Console.WriteLine();
                    a--;
                    n++;
                }
            }
            Console.ReadLine();
        }
    }
}
