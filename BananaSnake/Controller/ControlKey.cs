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
        ConsoleKey command = Console.ReadKey(true).Key;
        
        public void GetSnakeTomove(Snake snake)
        {

            do
            {

                snake.AddHeadToBody();
                
                if (Game.fruitEat == false)
                {
                    snake.DeleteBodyEnd();
                }

                switch (command)
                {
                    case ConsoleKey.Q:                  
                        snake.HeadPosition.x--;
                        snake.HeadDirection = Direction.left;

                        break;

                    case ConsoleKey.S:
                        snake.HeadPosition.y++;
                        snake.HeadDirection = Direction.down;

                        break;
                    case ConsoleKey.Z:
                        snake.HeadPosition.y--;
                        snake.HeadDirection = Direction.up;
      
                        break;

                    case ConsoleKey.D:
                        snake.HeadPosition.x++;
                        snake.HeadDirection = Direction.right;
                   
                        break;

                }

                View.SnakeView.ClearTail(snake.TailPosition);
                View.SnakeView.DrawHead(snake);

                //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);

                snake.isWallHit = snake.DidSnakeHitWall();
                if (snake.isWallHit)
                {
                    Game.isGameOn = false;
                    Console.SetCursorPosition(18, 20);
                    Console.WriteLine("Snake hit the wall");
                }

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey(true).Key;
                }
                System.Threading.Thread.Sleep(Game.gameSpeed);
                    
            } while (Game.isGameOn);

        }


    }
}
