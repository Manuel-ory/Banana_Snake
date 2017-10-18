using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    /// <summary>
    /// Permet d'afficher/effacer un fruit
    /// </summary>
    static class FruitView
    {
        /// <summary>
        /// Affiche un fruit
        /// </summary>
        /// <param name="fruit">fruit à afficher</param>
        public static void DisplayFruit(Fruit fruit)
        {
            Console.SetCursorPosition(fruit.FruitPosition.x+1, fruit.FruitPosition.y+1);
            Console.ForegroundColor = fruit.FruitColor;
            Console.WriteLine(Game.shapeFruit);
            Console.ResetColor();
        }

        /// <summary>
        /// Efface un fruit
        /// </summary>
        /// <param name="fruit">fruit à effacer</param>
        public static void ClearFruit(Fruit fruit)
        {
            Console.SetCursorPosition(fruit.FruitPosition.x + 1, fruit.FruitPosition.y + 1);
            Console.Write(Game.emptyCase);
        }


    }
}
