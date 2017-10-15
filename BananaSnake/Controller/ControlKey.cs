using BananaSnake.Model;
using BananaSnake.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class ControlKey
    {        
        ConsoleKey command = Console.ReadKey().Key;

        // Get the snake to apear on the console 
        SerpentView serpentView = new SerpentView();
        
        public void GetSnakeTomove(Snake snake, Game game)
        {
            do
            {
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        Console.Write("    ");
                        snake.HeadPosition.x--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        Console.Write("    ");
                        snake.HeadPosition.y++;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        Console.Write("    ");
                        snake.HeadPosition.y--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        Console.Write("    ");
                        snake.HeadPosition.x++;
                        break;
                }
                Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                serpentView.DisplaySerpent(snake);

                snake.isWallHit = snake.DidSnakeHitWall();
                if (snake.isWallHit)
                {
                    game.isGameOn = false;
                    Console.SetCursorPosition(18, 20);
                    Console.WriteLine("Snake hit the wall");
                }

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey().Key;
                }
                System.Threading.Thread.Sleep(game.gameSpeed);
                    
            } while (game.isGameOn);

        }

    }
}
