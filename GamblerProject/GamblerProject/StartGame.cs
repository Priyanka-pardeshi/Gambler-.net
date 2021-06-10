using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProject
{
    class StartGame
    {
        const int AMOUNT = 100;
        int currentAmount = 100;
        const int EVERYDAY_RS = 100;
        const int MAX_AMOUNT = 150;
        const int MIN_AMOUNT = 50;
        /// <summary>
        /// Gambling game 
        /// </summary>
        public void InitializePlay()
        {
            
            Console.WriteLine("total amount is="+EVERYDAY_RS+" and bet is of= "+AMOUNT+" rs");
        }

        /// <summary>
        /// Method to check win
        /// </summary>
        public void CheckWin()
        {
            bool flag = true;
            while (flag)
            {
                Random objRandom = new Random();
                int check = objRandom.Next(0, 2);
                
                
                switch (check)
                {
                    case 1:
                        if (currentAmount == MAX_AMOUNT)
                        {
                            flag = false;
                            Console.WriteLine("you're at profit:"+currentAmount);
                            break;
                        }
                        currentAmount = currentAmount + 1;
                        break;
                    default:
                        if (currentAmount == MIN_AMOUNT)
                        {
                            flag = false;
                            Console.WriteLine("yoou're at loss:"+currentAmount);
                        }
                        currentAmount = currentAmount - 1;
                        break;  
                }//switch close
            }//While close
        }//Method CLose
    }
}
