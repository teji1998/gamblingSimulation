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

        public void WinOrLose()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            Console.WriteLine("The toss is : " +toss );
            if (toss == 1)
            {
                Console.WriteLine("Gambler won 100 dollars" );
                
            }
            else
            {
                Console.WriteLine("Gambler lost one dollar" );

            }
        }
    }
}
