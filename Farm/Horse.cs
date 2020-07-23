using System;

namespace Farm
{
    class Horse
    {
        public string Name;

        public void Speak(string name)
        {
            Console.WriteLine($"I am a horse and my name is {name}. I say Neigh");
        }
        public void Eat()
        {
            Console.WriteLine("I am a horse. I eat grass");
        }

        public void Move()
        {
            Console.WriteLine("I like to gallop.");
        }

        public void Produce()
        {
            Console.WriteLine("I make tough meat.");
        }

        public void Food()
        {
            Console.WriteLine("I become horse steak.");
        }
    }
}