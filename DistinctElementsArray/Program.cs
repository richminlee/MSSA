using System;
using System.Collections.Generic;

namespace DistinctElementsArray
{
    class Program
    {
        static int findDistinct(int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    if (j == input.Length - 1) count++;
                    if (input[i] == input[j]) break;
                }
            }
            return count;
        }


        static int findDistinctNumbers(int[] inputArray)
        {
            int count = 0;
            List<int> distinctnumber = new List<int>();
            for(int i = 0; i < inputArray.Length; i++)
            {
                if (!(distinctnumber.Contains(inputArray[i])))
                {
                    distinctnumber.Add(inputArray[i]);
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 3, 4, 6, 3, 4, 4, 4, 5 };
            int[] array1 = {};
            Console.WriteLine(findDistinct(array));
        }
    }
}
