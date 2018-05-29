using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            string number = Console.ReadLine();
            var nArray = number.Split(',');
            foreach(var i in nArray)
            {
                //Console.WriteLine(i);
                if(int.Parse(i)%2 == 0)
                {
                    list1.Add(int.Parse(i));
                }
                else
                {
                    list2.Add(int.Parse(i));
                }
            }
            list1.Sort();
            list2.Sort();
            Console.WriteLine("偶數有: ");
            foreach (var x in list1)
            Console.Write(x + " ");
            Console.WriteLine();
            Console.WriteLine("奇數有: ");
            foreach (var y in list2)
            Console.Write(y + " ");
            //x = nArray.Count();
            /* while (x > 0)
             {
                 y = int.Parse(nArray[x - 1]) % 2;
                 //z = int.Parse(nArray[x - 1]);
                 switch (y)
                 {
                     case 0:
                         list1.Add(nArray[x - 1]);
                         break;
                     case 1:
                         list2.Add(nArray[x - 1]);
                         break;
                 }
                 x--;
             }*/

            //Console.Write($"{list1.Add(nArray[])}");


            /*  foreach(var total in nArray)
              {
                  Console.WriteLine(total);
              }*/
        }
    }
}
/*            x = nArray.Count();
            while(x>0)
            {
                y = int.Parse(nArray[x - 1]) % 2;
                z = int.Parse(nArray[x - 1]);
                switch (y)
                {
                    case 0:
                        string[] a = z;
                        break;
                }
                x--;
            }
            Console.WriteLine(x);*/