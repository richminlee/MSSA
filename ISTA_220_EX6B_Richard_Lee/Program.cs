using System;

namespace ISTA_220_EX6B_Richard_Lee
{
    public struct Coordinates
    {
        public double x;
        public double y;
        public Coordinates(Random rand)
        {
            this.x = rand.NextDouble();
            this.y = rand.NextDouble();
        }
        public Coordinates(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
    class Program
    {
        static double findHypotenuse(double x, double y) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        static void Main(string[] args)
        {
            double count = 0.0;
            Random rand = new Random();
            Coordinates[] numInput = new Coordinates[int.Parse(Console.ReadLine())];
            for(int i = 0; i < numInput.Length; i++)
            {
                numInput[i] = new Coordinates(rand);
                double hypotenuse = findHypotenuse(numInput[i].x, numInput[i].y);
                if (hypotenuse <= 1) count++;
            }
            double result = (count / numInput.Length) * 4;
            Console.WriteLine($"The calculated pi is {result}");
            double difference = Math.Abs(result - Math.PI);
            Console.WriteLine($"The difference between pi and the caluculated pi is {difference}");
        }
    }
    //1. We are working in the Top right quadrant, so we need to multiply by 4 to get the whole circle.
    //2. The output gets closer to Pi, becoming more accurate.
    //3. No, the output changes because the inputs are random.
    //4. 100,000,000 took a while to run and very accurate.
    //5. Another way to use the Monte-Carlo Method is for probablilities. Given a larger number of samples, the average, minimum and maximum will form a bell curve.
}
