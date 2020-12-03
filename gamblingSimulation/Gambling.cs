using System;
using System.Collections.Generic;
using System.Text;

namespace gamblingSimulation
{
    class Gambling
    {
        public const int STAKE = 100;
        public const int BET = 1;
        int total;

        public int WinOrLose()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == 1)
            {
                Console.WriteLine("Gambler won 100 dollars" + total);
                total = STAKE + BET;

            }
            else
            {
                Console.WriteLine("Gambler loss one dollar" + total);
                total = STAKE - BET;

            }
            return total;
        }
    }
}
