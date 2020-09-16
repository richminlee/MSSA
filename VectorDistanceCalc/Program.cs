using System;
using System.Collections.Generic;

namespace VectorDistanceCalc
{
    class Program
    {
        public static Tuple<int, int, int>[] points(int input)
        {
            Random random = new Random();
            Tuple<int, int, int>[] lotsOfPoints = new Tuple<int, int, int>[input];
            for (int i = 0; i < input; i++)
            {
                int x = random.Next(0, input);
                int y = random.Next(0, input);
                int z = random.Next(0, input);
                lotsOfPoints[i] = new Tuple<int, int, int> ( x, y, z );
            }
            return lotsOfPoints;
        }
        public static double distance(Tuple<int, int, int> one, Tuple<int, int, int> two)
        {
            return Math.Sqrt(Math.Pow((one.Item1 - two.Item1), 2) + Math.Pow(one.Item2 - two.Item2, 2) + Math.Pow(one.Item3 - two.Item3, 2));
        }
        public static void smallestDistance()
        {
            Tuple<int, int, int>[] lots = points(1000);
            double zero = 0;
            double smallest = 1/zero;
            int[] idx = new int[2];
            for (int i = 0; i < lots.Length; i++)
            {
                for (int j = 0; j < lots.Length; j++)
                {
                    if (i != j)
                    {
                        double Distance = distance(lots[i], lots[j]);
                        if (Distance < smallest)
                        {
                            smallest = Distance;
                            idx[0] = i;
                            idx[1] = j;

                        }
                    }
                }
            }
            Console.WriteLine($"The closest points are array element{idx[0]} -- {lots[idx[0]].Item1}, {lots[idx[0]].Item2}, {lots[idx[0]].Item3} array element {idx[1]} -- {lots[idx[1]].Item1}, {lots[idx[1]].Item2}, {lots[idx[1]].Item3} having a distance of {smallest}");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                smallestDistance();
                Console.WriteLine();
            }
        }
    }
}
