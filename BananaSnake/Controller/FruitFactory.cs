using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class FruitFactory
    {
        public Fruit CreateFruit(GameArea area)
        {
            //Random position 
            Random randX = new Random();

            int X = randX.Next(1, area.Width);
            int Y = randX.Next(1, area.Height);


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
                    throw new Exception("invalid default color value ");
                    break; 
            }

            return new Fruit(X,Y,randomColor);

        }
    }
}
