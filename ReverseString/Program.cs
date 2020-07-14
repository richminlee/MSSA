using System;

namespace ReverseString
{
    class Program
    {
        static string ReverseString(string word)
        {
            string reversedString = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedString += word[i];
            }
            return reversedString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello"));
        }
    }
}
