using System;

namespace gamblingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to gambling simulation!!");
            Gambling gambling = new Gambling();
            gambling.playGame();
        }
    }
}
