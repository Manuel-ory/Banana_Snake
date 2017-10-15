using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class ControlKey
    {
        private Snake snake;
        private Game game;

        ConsoleKey command = Console.ReadKey().Key;

        public void GetSnakeTomove()
        {
            do
            {
                switch (command)
                {
                    case ConsoleKey.Z:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        snake.HeadPosition.y--;
                        break;
                    case ConsoleKey.Q:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        snake.HeadPosition.x--;
                        break;
                    case ConsoleKey.S:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        snake.HeadPosition.y++;
                        break;
                    case ConsoleKey.D:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        snake.HeadPosition.x++;
                        break;
                }
                Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                                
            } while (game.isGameOn);

        }
            
    }
}
