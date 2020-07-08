/*
Syntactic sugar is taking something and making it more concise and easier to read. 
Essentially what we did in this program is take three functions and made it into one that is easier to write, read and understand.
*/
using System;

namespace OptionalParameters
{
    class Program
    {
        // Syntactic Sugar
        
        static void createATruck(string make = "Ram", string size = "1/2 ton")
        {
            Console.WriteLine($"You have created a {size} truck that is made by {make}.");

        }
        
        /*
        static void createATruck()
        {
            Console.WriteLine($"You have created a 1/2 ton truck that is made by Ram.");
        }
        static void createATruck(string make)
        {
            Console.WriteLine($"You have created a 1/2 ton truck that is made by {make}.");
        }
        static void createATruck(string make, string size)
        {
            Console.WriteLine($"You have created a {size} truck that is made by {make}.");
        }
        */
        static void Main(string[] args)
        {
            createATruck();
            createATruck("Dodge");
            createATruck("Chevrolet", "one ton");
        }
    }
}

