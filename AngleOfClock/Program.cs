using System;

namespace AngleOfClock
{
    class Program
    {
        static double CalculateAngle(double hour, double minute)
        {
            double resultAngle = (Math.Abs(hour * (360 / 12) - minute * ((360/12)/5))) + (0.5 * minute);
            if (resultAngle > 180) resultAngle = 360 - resultAngle;
            return resultAngle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAngle(3,00));
            Console.WriteLine(CalculateAngle(6,32));
            Console.WriteLine(CalculateAngle(12,20));
        }
    }
}
