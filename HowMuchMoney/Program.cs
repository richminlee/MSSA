using System;

namespace HowMuchMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HowMuchMoney.Program.Main()");
            Bank myBank = new Bank();
            int nrCoins = myBank.CountMyCoins();
            Console.WriteLine($"Wow! I have {nrCoins} coins in my bank!");
            string[] AllMyCoins = myBank.GetCoins(nrCoins);
            Console.WriteLine($"I have { myBank.HowMuch(AllMyCoins):C}"); 
        }
    }
}
