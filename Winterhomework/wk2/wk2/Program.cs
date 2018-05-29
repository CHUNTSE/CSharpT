using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string number = Console.ReadLine();
            string[] nArray = number.Split(',');
            x = nArray.Count();
            while(x>0)
            { 
                Console.Write(nArray[x-1]+",");
                x--;
            }
            /*foreach(string i in nArray)
                Console.WriteLine(i.ToString());*/
        }
    }
}
