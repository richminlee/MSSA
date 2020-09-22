using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = Collections.SortArray(new int[] { 5, 3, 7, 1, 2 });
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
