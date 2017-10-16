using BananaSnake.View;
using BananaSnake.Model;
using BananaSnake.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "BananaSnake game";

            Snake snakeModel = new Snake();
            Game gameModel = new Game();
            Score scoreModel = new Score();

            //Setup the game aera view
            GameAreaView.GameAera= new GameArea();
            GameAreaView.Draw();

            // Get snake to move 
            ControlKey keyController = new ControlKey();
            keyController.GetSnakeTomove(snakeModel, gameModel);

            //Setup the score model & view
            scoreModel.ScoreValue = 20;
            ScoreView.Draw(scoreModel);

            Console.ReadKey();

        }
    }
}
