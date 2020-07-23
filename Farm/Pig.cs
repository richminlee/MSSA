using System;

namespace Farm
{
    class Pig
    {
        public string Name;

        public void Speak(string name)
        {
            Console.WriteLine($"I am a pig and my name is {name}. I say Oink");
        }
        public void Eat()
        {
            Console.WriteLine("I am a pig and everything.");
        }

        public void Move()
        {
            Console.WriteLine("I like to sit around and sleep.");
        }

        public void Produce()
        {
            Console.WriteLine("I make pork.");
        }

        public void Food()
        {
            Console.WriteLine("I become pork chops.");
        }
    }
}