using System;
using System.Collections.Generic;
using System.Text;

namespace gamblingSimulation
{
    class Gambling
    {
        //Constants
        public const int STAKE = 100;
        public const int BET = 1;
        public const double STAKE_VALUE = 0.5;
        int maximumLose = (int)Math.Round(STAKE * STAKE_VALUE);
        int maximumWin = (int)Math.Round(STAKE + (STAKE * STAKE_VALUE));
        int numberOfDays = 20;


        /// <summary>
        /// Wins or lose bet
        /// </summary>
        /// <returns></returns>
        public bool winOrLose()
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

        /// <summary>
        /// Plays the game to meet resigning condition.
        /// </summary>
        public int playGame()
        {
            int total = STAKE;
            while (total > maximumWin && total < maximumWin)
            {
                if (winOrLose())
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
            return total;
        }

        public void amountFor2oDays()
        {
            int amount = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                Console.Write("for a day " + (i + 1));
                amount += playGame();
            }
            Console.WriteLine("TotalAmount is::" + amount);
            if (amount < 0)
            {
                Console.WriteLine("Loss occurred" + amount);
            }
            else
            {
                Console.WriteLine("Winning amount" + amount);
            }

        }
    }
}
