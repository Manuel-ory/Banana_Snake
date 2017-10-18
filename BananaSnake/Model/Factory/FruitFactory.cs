using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model.Factory
{
    /// <summary>
    /// Usine à fruits :D
    /// </summary>
    class FruitFactory
    {


        /// <summary>
        /// Crée un nouveau fruit
        /// </summary>
        /// <param name="area">La zone de jeu, pour que le fruit soit créé dedans</param>
        /// <returns></returns>
        public Fruit CreateFruit(GameArea area, Snake snake)
        {
            //Random position 
            Random randX = new Random();
            Random randY = new Random();

            int X = randX.Next(0, area.Width);
            int Y = randX.Next(0, area.Height);

            bool onSnake = false;

            do
            {
                onSnake = false;



                for (int i = 0; i < snake.BodyPosition.Count(); i++)
                {
                    if (snake.BodyPosition[i].x == X && snake.BodyPosition[i].y == Y )
                    {
                        onSnake = true;
                        X = randX.Next(0, area.Width);
                        Y = randX.Next(0, area.Height);
                    }
                }
                
                if(snake.HeadPosition.x == X && snake.HeadPosition.y == Y)
                {
                    onSnake = true;
                    X = randX.Next(0, area.Width);
                    Y = randX.Next(0, area.Height);
                }

            }
            while (onSnake);



            // Random Color 
            Random randColor = new Random();
            int color = randColor.Next(1, 4);
            ConsoleColor randomColor; 

            switch (color)
            {
                case 1 :
                    randomColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    randomColor = ConsoleColor.Red;
                    break;
                case 3:
                    randomColor = ConsoleColor.Green;
                    break;
                default:
                    throw new Exception("invalid default fruit's color value ");
                    break; 
            }

            return new Fruit(X,Y,randomColor);

        }
    }
}
