using System;

namespace CalculatingAverages
{
    class Program
    {
        static int sumOfNumbers(int inputs)
        {
            int i = 0;
            
            int amountOfInputs = inputs;
            int total = 0;

            while (i < amountOfInputs)
            {
                Console.WriteLine("Please enter a number from 0-100.");
                int input = int.Parse(Console.ReadLine());
                if (input >= 0 && input <= 100)
                {
                    total += input;
                    i++;
                }
                else
                {
                    Console.WriteLine("The number entered is not within range. Please Enter a number from 0-100.");
                }
            }
            return total;
        }
        static string averageScores(int inputs)
        {
            double averageScore = sumOfNumbers(inputs);
            averageScore /= inputs;
            string letterGrade;
            if (averageScore >= 90)
            {
                letterGrade = "A";
            }
            else if (averageScore >= 80)
            {
                letterGrade = "B";
            }
            else if (averageScore >= 70)
            {
                letterGrade = "C";
            }
            else if (averageScore >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return $"Average of {inputs} Scores. The average of your 10 inputs are {averageScore} and the letter grade is {letterGrade}";
        }
        static void nonSpecific()
        {
            int total = 0;
            int count = 0;
            int average;
            while (true)
            {
                Console.WriteLine("Please enter a number from 0-100.");
                int input = int.Parse(Console.ReadLine());
                if (input >= 0 && input <= 100)
                {
                    count++;
                    total += input;
                    average = total / count;
                    if(average >= 90)
                    {
                        Console.WriteLine($"The current average letter grade is A. The current average percentage is {average}%");
                    }
                    else if(average >= 80)
                    {
                        Console.WriteLine($"The current average letter grade is B. The current average percentage is {average}%");
                    }
                    else if (average >= 70)
                    {
                        Console.WriteLine($"The current average letter grade is C. The current average percentage is {average}%");
                    }
                    else if (average >= 60)
                    {
                        Console.WriteLine($"The current average letter grade is D. The current average percentage is {average}%");
                    }
                    else
                    {
                        Console.WriteLine($"The current average letter grade is F. The current average percentage is {average}%");
                    }

                }
                else
                {
                    Console.WriteLine("The number entered is not within range. Please Enter a number from 0-100.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of numbers. The sum of 10 inputs are {sumOfNumbers(10)}");
            Console.WriteLine(averageScores(10));
            Console.WriteLine("Please enter the total number of inputs.");
            int noOfInputs = int.Parse(Console.ReadLine());
            Console.WriteLine($"Average a Specific Number of Scores. The average of your inputs are {averageScores(noOfInputs)}");
            
            
            nonSpecific();
            
        }
    }
}
