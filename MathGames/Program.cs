using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;

namespace MathGames
{
    class  Util
    {
        public static Tuple<int, int> Initialize()
        {
            Console.WriteLine("To Add, enter 1");
            Console.WriteLine("To Subtract, enter 2");
            Console.WriteLine("To Multiply, enter 3");
            Console.WriteLine("To Divide, enter 4");
            Console.Write("Choose your problem type: ");
            int probType = int.Parse(Console.ReadLine());
            if (probType < 1 || probType > 4)
            {
                Console.WriteLine("Please Try again");
                return Initialize();
            }
            Console.Write("Enter number of problems between 1 and 12: ");
            int numProb = int.Parse(Console.ReadLine());
            if (numProb < 1 || numProb > 12)
            {
                Console.WriteLine("Please Try again");
                return Initialize();
            }
            return new Tuple<int, int>(probType, numProb);
        }
        public static int Add(int numProb)
        {
            Console.WriteLine($"You are testing Addition and you have {numProb} problems");
            Random random = new Random();
            int correct = 0;
            for (int i = 1; i <= numProb; i++)
            {
                int first = random.Next(1, 100);
                int second = random.Next(1, 100);
                Console.Write($"{i}. {first} + {second} = ");
                int answer = int.Parse(Console.ReadLine());
                if(answer == first + second)
                {
                    correct++;
                    Console.WriteLine("correct.");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {first + second}");
                }
            }
            return correct;
        }        
        public static int Subtract(int numProb)
        {
            Console.WriteLine($"You are testing Subtraction and you have {numProb} problems");
            Random random = new Random();
            int correct = 0;
            for (int i = 1; i <= numProb; i++)
            {
                int first = random.Next(1, 100);
                int second = random.Next(1, 100);
                if(first < second)
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }
                Console.Write($"{i}. {first} - {second} = ");
                int answer = int.Parse(Console.ReadLine());
                if(answer == first - second)
                {
                    correct++;
                    Console.WriteLine("correct.");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {first + second}");
                }
            }
            return correct;
        }
        public static int Multiply(int numProb)
        {
            Console.WriteLine($"You are testing Multiplication and you have {numProb} problems");
            Random random = new Random();
            int correct = 0;
            for (int i = 1; i <= numProb; i++)
            {
                int first = random.Next(1, 100);
                int second = random.Next(1, 100);
                Console.Write($"{i}. {first} * {second} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == first * second)
                {
                    correct++;
                    Console.WriteLine("correct.");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {first * second}");
                }
            }
            return correct;
        }
        public static int Divide(int numProb)
        {
            Console.WriteLine($"You are testing Division and you have {numProb} problems");
            Random random = new Random();
            int correct = 0;
            for (int i = 1; i <= numProb; i++)
            {
                double first = random.Next(1, 100);
                double second = random.Next(1, 100);
                Console.Write($"{i}. {first} / {second} = ");
                double answer = double.Parse(Console.ReadLine());
                double response = Math.Truncate((first / second) * 100) / 100;
                if (answer == response || answer == response + .01 || answer == response - .01)
                {
                    correct++;
                    Console.WriteLine("correct.");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {response}");
                }
            }
            return correct;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games");
            int probType = 0;
            int numProb = 0;
            int score = 0;
            (probType, numProb) = Util.Initialize();
            if (probType == 1) score = Util.Add(numProb);
            else if (probType == 2) score = Util.Subtract(numProb);
            else if (probType == 3) score = Util.Multiply(numProb);
            else if (probType == 4) score = Util.Divide(numProb);
            double grade = ((double)score / (double)numProb) * 100;
            Console.WriteLine($"You got {score} out of {numProb} correct and your grade is {(int)grade}%");
        }
    }
}
