using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    class SerpentView
    {
        private Snake snake = new Snake();

        public void DisplaySerpent()
        {
            Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("<■■■■");
            Console.ResetColor();
        }
    }
}
