using System;

namespace JulianCalendar
{
    class Program
    {
        static int getJulian(DateTime input)
        {
            int inputYear = input.Year;
            DateTime Jan01 = new DateTime(inputYear, 1, 1);
            TimeSpan dateDifference = input.Subtract(Jan01);
            int dateDiff = dateDifference.Days +1;
            inputYear = inputYear % 100;
            string result = $"{inputYear}{dateDiff}";
            return int.Parse(result);
        }
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today\'s Julian Calendar is {getJulian(today)}");
        }
    }
}
