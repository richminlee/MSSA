using System;

namespace findSumOfDigit
{
    class Program
    {
        public static int SumOfDigits(int input)
        {
            int result = 0;
            while(input > 0)
            {
                result += input % 10;
                input /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigits(-154));
        }
    }
}
