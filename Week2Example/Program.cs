using System;

namespace Week2Example
{
    class Program
    {
        static string getName()
        {
                Console.WriteLine("Hello User, What's your name?");
                return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {getName()}");
        }
    }
}