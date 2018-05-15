using System;

namespace 回文測試
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("輸入一串字串");
            var x = Console.ReadLine();
            ReverseArray array = new ReverseArray();
            if(array.Rever(x))
            {
                Console.WriteLine("這是回文");
            }
            else
            {
                Console.WriteLine("這不是回文");
            }
        }
    }
}
