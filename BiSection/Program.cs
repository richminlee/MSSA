using System;
using System.Threading;

namespace BiSection
{
    class Program
    {
        public static int[] HalfIntArray(int start, int end, int[] input)
        {
            int[] result = new int[(input.Length/2) + 1];
            int resultIdx = 0;
            for(int i = start; i < end; i++)
            {
                result[resultIdx] = input[i];
                resultIdx++;
            }
            return result;
        }
        public static bool BiSection(int value, int[] list)
        {
            if (value == list[list.Length / 2 -1]) return true;
            if(list.Length <= 2) return false;
            else if (value > list[list.Length / 2 -1]) return BiSection(value, HalfIntArray((list.Length / 2), list.Length, list));
            else return BiSection(value, HalfIntArray(0, (list.Length / 2), list));
        }
        public static bool Play()
        {
            try
            {
                Console.WriteLine("Type a number to see if it's in The List!");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine(BiSection(userInput, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Play();
        }
        public static bool GuessNumber(int input, int count = 0)
        {
            try
            {
                
                Console.WriteLine("Guess the Computer's number!");
                int userGuess = int.Parse(Console.ReadLine());
                count++;
                if (input == userGuess)
                {
                    Console.WriteLine($"You Guessed the Right Number! It took {count} tries.");
                    return true;
                }
                else if (input > userGuess)
                {
                    Console.WriteLine("Too Low try again");
                    return GuessNumber(input, count);
                }
                else
                {
                    Console.WriteLine("Too High try again");
                    return GuessNumber(input, count);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return GuessNumber(input, count);
            }
        }
        public static int CompGuess(int value, int[] list,int count = 0)
        {
            count++;
            Console.WriteLine("==========================================================================================");
            foreach(var num in list)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine(  );
            Console.WriteLine("==========================================================================================");
            if (value == list[list.Length / 2 - 1]) return count;
            else if (value > list[list.Length / 2 - 1]) return CompGuess(value, HalfIntArray((list.Length / 2), list.Length, list), count);
            else return CompGuess(value, HalfIntArray(0, (list.Length / 2), list), count);
        }
        static void Main(string[] args)
        {
            // 1. Implement bisection algorithm
            // Play();
            // 2. Guess my number, human plays
            //Random rand = new Random();
            //int computerNumber = rand.Next(1, 1001);
            //GuessNumber(computerNumber);
            // 3. Guess my number, computer plays
            int[] list = new int[100];
            for (int i = 0; i < 100; i++)
            {
                list[i] = i + 1;
            }
            Console.WriteLine("Pick a number for the computer to guess between 1-100");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"It took {CompGuess(userNumber, list)} tries to guess {userNumber} out of 100");
            // I thought the computer was pretty accurate. I definitely followed the same logic to get the answer as the logic I created for the computer.

        }
    }
}
