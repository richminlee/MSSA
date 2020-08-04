using System;

namespace ISTA_220_EX6A_Richard_Lee
{
    class Program
    {
        static double AverageArray(int[] inputArray)
        {
            double count = 0;
            double total = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                count++;
                total += inputArray[i];
            }
            return total / count;
        }

        static int[] ReverseArray(int[] inputArray)
        {
            int[] reversedArray = new int[inputArray.Length];
            int j = 0;
            for(int i = inputArray.Length-1; i >= 0; i--)
            {
                reversedArray[j] = inputArray[i];
                j++;
            }
            return reversedArray;
        }

        static int[] RotateArray(string direction, int numberOfPlaces, int[] inputArray)
        {
            int[] rotatedArray = new int[inputArray.Length];
            int index = 0;
            if(direction == "left")
            {
                for (int i = inputArray.Length - numberOfPlaces; i < inputArray.Length; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
                for (int i = 0; i < inputArray.Length - numberOfPlaces; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
            }
            else // direction == "right"
            {
                for (int i = numberOfPlaces; i < inputArray.Length; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
                for (int i = 0; i < numberOfPlaces; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
            }
            return rotatedArray;
        }

        static int[] BubbleSort(int[] inputArray)
        {
            int temp;
            int count = 0;

            for(int i = 0; i < inputArray.Length - 1; i++)
            {
                if(inputArray[i] > inputArray[i + 1])
                {
                    temp = inputArray[i];
                    inputArray[i] = inputArray[i + 1];
                    inputArray[i + 1] = temp;
                    count++;
                }
            }
            if (count != 0)
            {
                BubbleSort(inputArray);
            }
            return inputArray;
        }

        static void Main(string[] args)
        {
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            // 1. 
            // Console.WriteLine(AverageArray(arrayA));

            // 2.
            //int[] resultReverseArray = ReverseArray(arrayA); // uncomment these one at a time to check the input results.
            //int[] resultReverseArray = ReverseArray(arrayB); // uncomment these one at a time to check the input results.
            //int[] resultReverseArray = ReverseArray(arrayC); // uncomment these one at a time to check the input results.

            //for (int i = 0; i < resultReverseArray.Length; i++)
            //{
            //    Console.Write($"{resultReverseArray[i]}, ");

            //}

            // 3.
            //int[] resultRotatedArray = RotateArray("left", 2, arrayA); // uncomment these one at a time to check the input results.
            //int[] resultRotatedArray = RotateArray("right", 2, arrayB); // uncomment these one at a time to check the input results.
            //int[] resultRotatedArray = RotateArray("left", 4, arrayC); // uncomment these one at a time to check the input results.
            //for (int i = 0; i < resultRotatedArray.Length; i++)
            //{
            //    Console.Write($"{resultRotatedArray[i]}, ");

            //}

            // 4. arrayC's arrangement of int is similar to Pi.
            //int[] resultSortedArray = BubbleSort(arrayC);
            //for (int i = 0; i < resultSortedArray.Length; i++)
            //{
            //    Console.Write($"{resultSortedArray[i]}, ");

            //}
        }
    }
}
