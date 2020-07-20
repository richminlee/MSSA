using System;
using System.Security.Cryptography.X509Certificates;

namespace MathematicalFormulas
{
    class Program
    {
        static int checkInput()
        {
            try
            {
                int checkedInput = int.Parse(Console.ReadLine());
                if (checkedInput > 0)
                {
                    return checkedInput;
                }
                else
                {
                    Console.WriteLine("Input must be greater than 0.");
                    return checkInput();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be a number." + ex.Message);
                return checkInput();
            }
        }
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            int intradius = checkInput();
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            try
            {
                double area = Math.PI * (intradius * intradius);
                Console.WriteLine($"The area is {area}");

            }
            catch (OverflowException oEx)
            {
                Console.WriteLine(oEx.Message);
            }

            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            intradius = checkInput();
            float fraction = 4 / 3f;
            double volume = (fraction * Math.PI * (Math.Pow(intradius, 3))) / 2;
            Console.WriteLine($"The volume is {volume}");

            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for the first side of the triangle: ");
            double firstInput = checkInput();
            Console.Write("Enter an integer for the second side of the triangle: ");
            double secondInput = checkInput();
            Console.Write("Enter an integer for the third side of the triangle: ");
            double thirdInput = checkInput();
            static double AreaTriangle(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return result;

            }
            Console.WriteLine($"The area is {AreaTriangle(firstInput, secondInput, thirdInput)}");

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.Write("Enter an integer for the first part of the quadratic formula: ");
            firstInput = checkInput();
            Console.Write("Enter an integer for the second part of the quadratic formula: ");
            secondInput = checkInput();
            Console.Write("Enter an integer for the third part of the quadratic formula: ");
            thirdInput = checkInput();
            static string Quadratic(double a, double b, double c)
            {
                double denominator = 2 * a;
                string errorMessage = "This is not a valid equation.";
                if(denominator < 0)
                {
                    return errorMessage;
                }
                double negative_num = (-b + Math.Sqrt(Math.Pow(b , 2) - 4 * a * c))/denominator;
                double positive_num = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/denominator;
                if (((a * Math.Pow(negative_num , 2)) + b * negative_num + c) != 0)
                {
                    return errorMessage;
                }
                if (((a * Math.Pow(positive_num , 2)) + b * positive_num + c) != 0)
                {
                    return errorMessage;
                }
                return $"The positive solution is {positive_num} \r The negative solution is {negative_num}";
            }
            Console.WriteLine(Quadratic(firstInput, secondInput, thirdInput));
            try
            {

            }
            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }
        }
    }
}
