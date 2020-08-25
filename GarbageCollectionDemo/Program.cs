using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120/0 = {calculator.Divide(120,0)}");
            };
            Console.WriteLine("Program finishing");
        }
    }
}
