using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse Horsey = new Horse();
            Horsey.Speak("Horsey");
            Horsey.Eat();
            Horsey.Move();
            Horsey.Produce();
            Horsey.Food();

            Chicken Chickie = new Chicken();
            Chickie.Speak("Chickie");
            Chickie.Eat();
            Chickie.Move();
            Chickie.Produce();
            Chickie.Food();

            Cow Cowie = new Cow();
            Cowie.Speak("Cowie");
            Cowie.Eat();
            Cowie.Move();
            Cowie.Produce();
            Cowie.Food();

            Pig Piggie = new Pig();
            Piggie.Speak("Piggie");
            Piggie.Eat();
            Piggie.Move();
            Piggie.Produce();
            Piggie.Food();
        }
    }
}
