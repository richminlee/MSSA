using System;

namespace IntegerSwap
{
    class Program
    {
        public static void IntSwap()
        {
            int x = 5;
            int y = 17;
            Console.WriteLine($"x = {x}, y = {y}");
            x += y;//22
            y = x - y;//5
            x = x - y;// 17
            Console.WriteLine("Swap");
            Console.WriteLine($"x = {x}, y = {y}");
        }
        static void Main(string[] args)
        {
            IntSwap();
        }
    }
}
