using System;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字: ");
            string number = Console.ReadLine();
            for(int i =0;i<number.Length;i++)
            {
                if(number[i].ToString() =="1")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "2")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "3")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "4")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "5")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "6")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "7")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "8")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "9")
                {
                    Console.Write(" __ ");
                }
                if (number[i].ToString() == "0")
                {
                    Console.Write(" __ ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString() == "1")
                {
                    Console.Write("  | ");
                }
                if (number[i].ToString() == "2")
                {
                    Console.Write("   |");
                }
                if (number[i].ToString() == "3")
                {
                    Console.Write("   |");
                }
                if (number[i].ToString() == "4")
                {
                    Console.Write("|  |");
                }
                if (number[i].ToString() == "5")
                {
                    Console.Write("|   ");
                }
                if (number[i].ToString() == "6")
                {
                    Console.Write("|   ");
                }
                if (number[i].ToString() == "7")
                {
                    Console.Write("|  |");
                }
                if (number[i].ToString() == "8")
                {
                    Console.Write("|  |");
                }
                if (number[i].ToString() == "9")
                {
                    Console.Write("|  |");
                }
                if (number[i].ToString() == "0")
                {
                    Console.Write("|  |");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString() == "1")
                {
                    Console.Write("  | ");
                }
                if (number[i].ToString() == "2")
                {
                    Console.Write("|￣ ");
                }
                if (number[i].ToString() == "3")
                {
                    Console.Write(" ￣|");
                }
                if (number[i].ToString() == "4")
                {
                    Console.Write(" ￣|");
                }
                if (number[i].ToString() == "5")
                {
                    Console.Write(" ￣|");
                }
                if (number[i].ToString() == "6")
                {
                    Console.Write("|￣|");
                }
                if (number[i].ToString() == "7")
                {
                    Console.Write("   |");
                }
                if (number[i].ToString() == "8")
                {
                    Console.Write("|￣|");
                }
                if (number[i].ToString() == "9")
                {
                    Console.Write(" ￣|");
                }
                if (number[i].ToString() == "0")
                {
                    Console.Write("|  |");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString() == "1")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "2")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "3")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "4")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "5")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "6")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "7")
                {
                    Console.Write("    ");
                }
                if (number[i].ToString() == "8")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "9")
                {
                    Console.Write(" ￣ ");
                }
                if (number[i].ToString() == "0")
                {
                    Console.Write(" ￣ ");
                }
            }
            Console.ReadLine();
        }
    }
}
