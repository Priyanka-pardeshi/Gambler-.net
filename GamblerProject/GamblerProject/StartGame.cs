using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProject
{
    class StartGame
    {
        const int AMOUNT = 1;
        int currentAmount = 0;
        const int EVERYDAY_RS = 100;
        /// <summary>
        /// Gambling game 
        /// </summary>
        public void Play()
        {
            
            Console.WriteLine("total amount is="+EVERYDAY_RS+" and bet is of ="+AMOUNT+" rs");
        }
        public void CheckWin()
        {
            Random objRandom = new Random();
            int check = objRandom.Next(0, 2);
            switch (check)
            {
                case 1:
                    Console.WriteLine("Win");
              
                    break;
                case 2:
                    Console.WriteLine("Lose");
                    break;
            }
            
        }
    }
}
