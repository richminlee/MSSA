using System;

namespace GreaterThanInput
{
    class Program
    {
        static string GreaterThan(int number1, int number2)
        {
            if (number1 > number2)
            {
                return $"{number1} is greater than {number2}";
            }
            else if(number2 > number1)
            {
                return $"{number2} is greater than {number1}";
            }
            else
            {
                return $"{number1} is equal to {number2}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GreaterThan(6,6));
        }
    }
}
