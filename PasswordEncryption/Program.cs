using System;
using System.Collections.Generic;

namespace PasswordEncryption
{
    class Program
    {
        public static void Start(Dictionary<string, string> LoginInfo)
        {
            
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1.Establish an account");
            Console.WriteLine("2.Authenticate a user");
            Console.WriteLine("3.Exit the system");
            Console.WriteLine("Enter selection:");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    CreateAccount(LoginInfo);
                    break;
                case 2:
                    Authenticate(LoginInfo);
                    break;
                case 3:
                    Exit(LoginInfo);
                    break;
                default:
                    Console.WriteLine("Not a choice");
                    Start(LoginInfo);
                    break;
            }
        }
        public static void CreateAccount(Dictionary<string, string> LoginInfo)
        {
            Console.WriteLine("Please enter a Username");
            string Username = Console.ReadLine();
            Console.WriteLine("Please enter a Password");
            string Password = Console.ReadLine();
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(Password);
            
            if (LoginInfo.ContainsKey(Username))
            {
                Console.WriteLine("Username already exists, please try again.");
                CreateAccount(LoginInfo);
            }
            else
            {
                LoginInfo.Add(Username, passwordHash);
                Console.WriteLine("Account Created!");
                Start(LoginInfo);
            }
        }
        public static void Authenticate(Dictionary<string, string> LoginInfo)
        {
            Console.WriteLine("Please enter your Username");
            string Username = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string Password = Console.ReadLine();
            if (!LoginInfo.ContainsKey(Username))
            {
                Console.WriteLine("That Username does not exist.");
                Start(LoginInfo);
            }
            else
            {
                bool verified = BCrypt.Net.BCrypt.Verify(Password, LoginInfo[Username]);
                if (verified == true)
                {
                    Console.WriteLine("Verification Successful");
                    Start(LoginInfo);
                }
                else
                {
                    Console.WriteLine("Not a valid Username and Password. Please try again");
                    Start(LoginInfo);
                }
            }

        }
        public static void Exit(Dictionary<string, string> LoginInfo)
        {
            foreach (var users in LoginInfo)
            {
                Console.WriteLine(users);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> LoginInfo = new Dictionary<string, string>();
            Start(LoginInfo);
        }
    }
}
