using System;
using System.Collections.Generic;
using System.Text;

namespace gamblingSimulation
{
    class Gambling
    {
        public const int STAKE = 100;
        public const int BET = 1;
        public const int MAXIMUM_WIN = 150;
        public const int MAXIMUM_LOSE = 50;

        public bool WinOrLose()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            Console.WriteLine("The toss is : " + toss);

            if (toss == 1)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public void playGame()
        {
            int total = STAKE;
            while (total > MAXIMUM_LOSE && total < MAXIMUM_LOSE)
            {
                if (WinOrLose())
                {
                    total = total + BET;
                }
                else
                {
                    total = total - BET;
                }
            }
            int amount = total - STAKE;
            if (total < 0)
            {
                Console.WriteLine("Stopped playing after losing : " + total);
            }
            else
            {
                Console.WriteLine("Stopped playing after winning : " + total);
            }
        }
    }
}
