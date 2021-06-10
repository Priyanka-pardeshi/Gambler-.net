using System;

namespace GamblerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            StartGame objStartGame = new StartGame();
            objStartGame.InitializePlay();
            objStartGame.CheckWin();
        }
    }
}
