using System;

namespace Farm
{
    class Chicken
    {
        public string Name;

        public void Speak(string name)
        {
            Console.WriteLine($"I am a chicken and my name is {name}. I say Cluck.");
        }        
        public void Eat()
        {
            Console.WriteLine("I am a chicken and I eat seeds and bugs.");
        }

        public void Move()
        {
            Console.WriteLine("I like to jump and glide down.");
        }

        public void Produce()
        {
            Console.WriteLine("I make chicken cutlets.");
        }

        public void Food()
        {
            Console.WriteLine("I become rotisserie chicken.");
        }
    }
}