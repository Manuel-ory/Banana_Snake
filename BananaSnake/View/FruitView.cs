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
        public void DisplayFruit(Fruit fruit)
        {
            Console.SetCursorPosition(fruit.FruitPosition.x, fruit.FruitPosition.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(")");
            Console.ResetColor();
        }
    }
}
