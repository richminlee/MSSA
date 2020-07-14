using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MonteCarloMethod
{
    class Program
    {
        static (double, double) randomNumGen(Random random)
        {
            double doubleX = random.NextDouble();
            double doubleY = random.NextDouble();
            return (doubleX, doubleY);
        }

        static double findHypotenuse(double x, double y) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        static void startCalculations(int iterations)
        {
            Random randomNumber = new Random();
            double count = 0;
            for (int i = 0; i < iterations; i++)
            {
                (double randomX, double randomY) = randomNumGen(randomNumber);
                double hypotenuse = findHypotenuse(randomX, randomY);
                if (hypotenuse <= 1)
                {
                    count++;
                }
            }
            double result = (count / iterations) * 4;
            Console.WriteLine($"The calculated pi is {result}");
            double difference = Math.Abs(result - Math.PI);
            Console.WriteLine($"The difference between pi and the caluculated pi is {difference}");
        }

        static void Main()
        {
            Console.WriteLine("How many times do you want to iterate?");
            int numOfIterations = int.Parse(Console.ReadLine());
            startCalculations(numOfIterations);
        }
    }
}
/*
10 = 0.3415926535897933
100 = 0.02159265358979301
1000 = 0.05840734641020706
10000 = 0.018392653589792918

Why do we multiply the value from step 5 above by 4?
    We are doing our calculations from the top right quadrant where x and y are from 0 to 1. So we need to multiply it by 4 to get the whole circle.
What do you observe in the output when running your program with parameters of increasing size?
    It seems to get more accurate with more iterations.
If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
    The output changes everytime you run the program because we are choosing the x and y values at random.
Find a parameter that requires multiple seconds of run time. What is that parameter?
    2147483647, the max value of an integer.
How accurate is the estimated value of pi?
    It would depend on what the user was using pi for and how accurate he needs it to be, but overall it seems really accurate at higher iterations.
Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
    Another way to use the Monte-Carlo Method is for probablilities. 
    Given a larger number of samples, the average, minimum and maximum will form a bell curve. 
*/
