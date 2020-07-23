using System;

namespace Farm
{
    class Cow
    {
        public string Name;

        public void Speak(string name)
        {
            Console.WriteLine($"I am a cow and my name is {name}. I say Moo.");
        }
        public void Eat()
        {
            Console.WriteLine("I am a cow and I eat grass.");
        }

        public void Move()
        {
            Console.WriteLine("I like to walk around and graze.");
        }

        public void Produce()
        {
            Console.WriteLine("I make steaks.");
        }

        public void Food()
        {
            Console.WriteLine("I become smoked brisket.");
        }
    }
}