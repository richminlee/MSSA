using System;

namespace Palindrome
{
    public class Program
    {
        public static bool FindPalindrome(string input)
        {
            input = input.ToLower();
            int i = 0;
            int j = input.Length - 1;
            while (j > i)
            {
                if (input[i] != input[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindPalindrome("Racecar"));
        }
    }
}
