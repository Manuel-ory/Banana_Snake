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
            Fruit fruitModel = new Fruit(15,15);

            //Setup the game aera view
            GameAreaView.GameAera= new GameArea();
            GameAreaView.Draw();

            // Get the snake to apear on the console 
            SerpentView serpent = new SerpentView();
            serpent.DisplaySerpent(snakeModel);

            // Get the fruit to apear on the console 
            FruitView fruit = new FruitView();
            fruit.DisplayFruit(fruitModel);


            // Get snake to move 
            ControlKey keyController = new ControlKey();
            keyController.GetSnakeTomove(snakeModel, gameModel);
            keyController.GenerateFruit(gameModel);
            //Setup the score model & view
            scoreModel.ScoreValue = 20;
            ScoreView.Draw(scoreModel);

            Console.ReadKey();

        }
    }
}
