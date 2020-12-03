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
        public const int NUMBER_OF_DAYS = 20;


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
            while (total > maximumLose && total < maximumWin)
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
            int totalMoney = total - STAKE;
            if (totalMoney < 0)
            {
                Console.WriteLine("\nFinal amount for the day after losing : " + totalMoney);
            }
            else
            {
                Console.WriteLine("\nFinal amount for the day after winning : " + totalMoney);
            }
            return totalMoney;
        }

        public void amountFor20Days()
        {
            int amount = 0;
            for (int i = 1; i <= NUMBER_OF_DAYS; i++)
            {
                Console.Write("For day " +i);
                amount = amount + playGame();
            }
            Console.WriteLine("Total amount is :" + amount);
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
