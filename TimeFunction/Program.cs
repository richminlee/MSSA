using System;

namespace TimeFunction
{
    class Program
    {
        public static int TimeBetween(int hr1, int min1, int hr2, int min2)
        {
            int hour = Math.Abs(hr1 - hr2);
            int minute = Math.Abs((min2 - min1));
            int totalMinutes = 0;
            if (hr2 > hr1)
            {
                totalMinutes += (hr2 - hr1) * 60;
                if (min2 >= min1)
                {
                    totalMinutes += min2 - min1;
                }
                else
                {
                    totalMinutes -= min1;
                }
                
            }
            else if(hr2 == hr1)
            {
                if (min2 >= min1)
                {
                    totalMinutes += min2 - min1;
                }
                else
                {
                    totalMinutes -= min1;
                }
            }
            else
            {
            
            }
            return totalMinutes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
