using System;
using System.Collections.Generic;

namespace Scrabble
{
    class Program
    {
        public static int getWordValue(string input)
        {
            string word = input.ToUpper();
            int result = 0;
            Dictionary<char, int> scrabbleValues = new Dictionary<char, int>()
            { 
                { 'A', 1}, { 'B', 3}, { 'C', 3}, { 'D', 2}, { 'E', 1}, { 'F', 4}, { 'G', 2}, { 'H', 4},
                { 'I', 1}, { 'J', 8}, { 'K', 5}, { 'L', 1}, { 'M', 3}, { 'N', 1}, { 'O', 1}, { 'P', 3},
                { 'Q', 10}, { 'R', 1}, { 'S', 1}, { 'T', 1}, { 'U', 1}, { 'V', 4}, { 'W', 4}, { 'X', 8},
                { 'Y', 4}, { 'Z', 10}
            };

            for (int i = 0; i < word.Length; i++)
            {
                result += scrabbleValues[word[i]];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                int word = getWordValue(input);
                total += word;
                Console.WriteLine($"word: {word}");
                Console.WriteLine($"total: {total}");
            }
        }
    }
}
