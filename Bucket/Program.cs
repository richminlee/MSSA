using System;

namespace Bucket
{
    public static class Buckets
    {
        static Random r = new Random();
        public static int[] GetBucketOfInts(int size = 10)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(0,100);
            }
            return numbers;
        }
        public static int[] SortBucketOfInts(int[] inputArray)
        {
            int temp;
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] > inputArray[i + 1])
                {
                    temp = inputArray[i];
                    inputArray[i] = inputArray[i + 1];
                    inputArray[i + 1] = temp;
                    count++;
                }
            }
            if (count != 0)
            {
                SortBucketOfInts(inputArray);
            }
            return inputArray;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Buckets.GetBucketOfInts();
            numbers = Buckets.SortBucketOfInts(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]},");
            }
        }
    }
}
