using System;
using System.Collections.Generic;
using System.Text;

namespace HowMuchMoney
{
    public class Bank
    {
        static string[] coins = { "penny", "nickel", "dime", "quarter" };
        Random RandomNumber;
        public Bank()
        {
            RandomNumber = new Random();
        }
        public Bank(int RandomSeed)
        {
            RandomNumber = new Random(RandomSeed);
        }
        public int CountMyCoins()
        {
            return RandomNumber.Next(10, 50);
        }
        public string[] GetCoins(int howMany)
        {
            string[] MyCoins = new string[howMany];
            for (int i = 0; i < MyCoins.Length; i++)
            {
                MyCoins[i] = coins[RandomNumber.Next(0, 4)];
                Console.Write(MyCoins[i] + ", ");
            }
            return MyCoins;
        }
        public int HowMuch(string[] allTheCoins)
        {
            int total = 0;
            for(int i = 0; i < allTheCoins.Length; i++)
            {
                if (allTheCoins[i] == "penny") total += 1;
                else if (allTheCoins[i] == "nickel") total += 5;
                else if (allTheCoins[i] == "dime") total += 10;
                else total += 25;
            }
            return total;
        }
    }
}
