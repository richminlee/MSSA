using System;

namespace AngleOfClock
{
    class Program
    {
        static double CalculateAngle(double hour, double minute)
        {
            double resultAngle = (Math.Abs(hour * 30 - minute * 6)) + (0.5 * minute);
            if (resultAngle > 180) resultAngle = 360 - resultAngle;
            return resultAngle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAngle(6,30));
            Console.WriteLine(CalculateAngle(12,20));
        }
    }
}
