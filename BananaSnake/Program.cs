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
            Random randomx = new Random();
            Random randomy = new Random();

            Console.Title = "BananaSnake game";
            TetrisMusic.StartMusic();

            Snake snakeModel = new Snake();
            Score scoreModel = new Score();
            Fruit fruitModel = new Fruit(randomx.Next(3, 45), randomy.Next(3, 18),ConsoleColor.Yellow);



            //Setup the game aera view
            GameAreaView.GameAera = new GameArea();
            GameAreaView.Draw();


            // Get the fruit to apear on the console 
            FruitView fruit = new FruitView();
            fruit.DisplayFruit(fruitModel);

            // Get snake to move 
            ControlKey keyController = new ControlKey();
            keyController.GetSnakeTomove(snakeModel);

            //Setup the score model & view
            scoreModel.ScoreValue = 20;
            ScoreView.Draw(scoreModel);

            Console.ReadKey();

        }
    }
}
