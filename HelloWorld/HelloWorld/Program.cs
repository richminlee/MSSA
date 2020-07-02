using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            string Name;
            double HieghtInInches = 72.5;
            string nameOfMyNewRockBand;
            Name = "John";
            nameOfMyNewRockBand = "The New Fiery Dvelopers";

            Console.WriteLine("{0} is the number {1} member of {2}", Name, x, nameOfMyNewRockBand);
            Console.WriteLine($"{Name} is the number {x} member of {nameOfMyNewRockBand}");
            Console.Beep();
        }
    }
}
