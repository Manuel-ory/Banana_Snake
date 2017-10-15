using BananaSnake.View;
using BananaSnake.Model;
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
            //Setup the game aera view
            GameAreaView.SetAeraSize();
            GameAreaView.Draw();

            // Get the snake to apear on the console 
            SerpentView serpent = new SerpentView();
            serpent.DisplaySerpent();

            //Setup the score model & view
            Score scoreModel = new Score();
            scoreModel.ScoreValue = 20;
            ScoreView.Draw(scoreModel);

            Console.ReadKey();

        }
    }
}
