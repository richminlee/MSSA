using System;

namespace Sep172020
{
    class Program
    {
        public static int Sum(int[] intarr)
        {
            int result = 0;

            for (int i = 0; i < intarr.Length; i++)
            {
                result += intarr[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 1,2,3,4,5}));
        }
    }
}
