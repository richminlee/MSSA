using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;

namespace PrimeNumber
{
    class Program
    {
        static bool isPrime(int input)
        {
            if (input < 2)
            {
                return false;
            }
            else if (input <= 3)
            {
                return true;
            }
            else
            {
                if (input % 2 == 0) return false;
                else if (input % 3 == 0) return false;
                else if (input % 5 == 0) return false;
                return true;

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(3));
        }
    }
}
