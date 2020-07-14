using System;

namespace GetCharFromString
{
    class Program
    {
		static int GetNumChar(string movieName, Char givenChar)
		{
			int count = 0;
			givenChar = char.ToLower(givenChar);
			movieName = movieName.ToLower();
			for (int i = 0; i < movieName.Length; i++)
			{
				if (movieName[i] == givenChar)
				{
					count++;
				}
			}
			return count;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(GetNumChar("moviename", 'e')); ;
		}
	}
}
