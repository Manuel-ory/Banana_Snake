using BananaSnake.View;
using BananaSnake.Model;
using BananaSnake.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BananaSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "BananaSnake game";

            Snake snakeModel = new Snake();
            Score scoreModel = new Score();

            //Setup the game aera view
            GameAreaView.GameAera= new GameArea();
            GameAreaView.Draw();

            KeyObserver keyObserver = new KeyObserver();
            //Thread threadKeyObserver = new Thread(keyObserver.startThread);
            //threadKeyObserver.Start();
            // Controller.Clock clock = new Clock(snakeModel, gameModel);
            // Get snake to move 
            ControlKey keyController = new ControlKey();
            keyController.GetSnakeTomove(snakeModel);

            //Setup the score model & view
            scoreModel.ScoreValue = 20;
            ScoreView.Draw(scoreModel);

            Console.ReadKey();
            keyObserver.Stop();

        }
    }
}
