using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Collections
    {
        public static int[] GetScores(int numOfScores)
        {
            Random random = new Random();
            int[] result = new int[numOfScores];
            for (int i = 0; i < numOfScores; i++)
            {
                result[i] = random.Next(1, 100);
            }
            return result;
        }
        public static double AverageScores(int[] arrOfScores)
        {
            double result = 0;
            for (int i = 0; i < arrOfScores.Length; i++)
            {
                result += arrOfScores[i];
            }
            result /= arrOfScores.Length;
            return result /= arrOfScores.Length;
        }
        public static int MaximumValue(int[] arrOfScores)
        {
            int maxValue = arrOfScores[0];
            for (int i = 0; i < arrOfScores.Length; i++)
            {
                if (maxValue < arrOfScores[i])
                {
                    maxValue = arrOfScores[i];
                }
            }
            return maxValue;
        }
        public static int[] SortArray(int[] arrOfScores)
        {
            int idx1 = 0;
            int idx2 = 1;
            bool toggle = false;
            while (idx2 < arrOfScores.Length)
            {
                if(arrOfScores[idx1] > arrOfScores[idx2])
                {
                    int temp = arrOfScores[idx1];
                    arrOfScores[idx1] = arrOfScores[idx2];
                    arrOfScores[idx2] = temp;
                    toggle = true;
                }
                idx1++;
                idx2++;
            }
            if(toggle == true)
            {
                return SortArray(arrOfScores);
            }
            return arrOfScores;
        }
    }
}