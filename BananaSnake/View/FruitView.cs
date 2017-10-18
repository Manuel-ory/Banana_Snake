using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    class FruitView
    {

        public static void DisplayFruit(Fruit fruit)
        {
            Console.SetCursorPosition(fruit.FruitPosition.x+1, fruit.FruitPosition.y+1);
            Console.ForegroundColor = fruit.FruitColor;
            Console.WriteLine(")");
            Console.ResetColor();
        }

        public static void ClearFruit(Fruit fruit)
        {
            Console.SetCursorPosition(fruit.FruitPosition.x + 1, fruit.FruitPosition.y + 1);
            Console.Write(' ');
        }


    }
}
