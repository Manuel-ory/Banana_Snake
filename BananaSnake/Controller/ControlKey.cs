using BananaSnake.Model;
using BananaSnake.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class ControlKey
    {        
        ConsoleKey command = Console.ReadKey(true).Key;
        FruitView fruitView = new FruitView();


        public void GetSnakeTomove(Snake snake, Game game)
        {
            Random randomx = new Random();
            Random randomy = new Random();

            do
            {

                snake.AddHeadToBody();
                
                if (game.fruitEat == false)
                {
                    snake.DeleteBodyEnd();
                   
                }else
                {
                    Fruit fruit = new Fruit(randomx.Next(3, 45), randomy.Next(3, 18));

                    fruitView.DisplayFruit(fruit);
                    eatFruit(game, snake, fruit);

                }

                switch (command)
                {
                    case ConsoleKey.Q:                  
                        snake.HeadPosition.x--;
                        snake.HeadDirection = Direction.left;
                        //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        //Console.Write("    ");
                        break;

                    case ConsoleKey.S:
                        snake.HeadPosition.y++;
                        snake.HeadDirection = Direction.down;
                        //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        //Console.Write("    ");
                        break;
                    case ConsoleKey.Z:
                        snake.HeadPosition.y--;
                        snake.HeadDirection = Direction.up;
                        //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        //Console.Write("    ");
                        break;

                    case ConsoleKey.D:
                        snake.HeadPosition.x++;
                        snake.HeadDirection = Direction.right;
                        //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);
                        //Console.Write("    ");
                        break;

                }

                View.SnakeView.ClearTail(snake.TailPosition);
                View.SnakeView.DrawHead(snake);

                //Console.SetCursorPosition(snake.HeadPosition.x, snake.HeadPosition.y);

                snake.isWallHit = snake.DidSnakeHitWall();
                if (snake.isWallHit)
                {
                    game.isGameOn = false;
                    Console.SetCursorPosition(18, 20);
                    Console.WriteLine("Snake hit the wall");
                }

                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey(true).Key;
                }
                System.Threading.Thread.Sleep(game.gameSpeed);
                    
            } while (game.isGameOn);

        }

        public void eatFruit(Game game , Snake snake , Fruit fruit) {
            if (snake.HeadPosition == fruit.FruitPosition)
            {
                game.fruitEat = false;
            }
            
        }


        // deplacer dans controller fruit
       /*public void GenerateFruit(Game game , Snake snake){
            Random randomx = new Random();
            Random randomy = new Random();

            do
            {
                if (game.fruitEat == false)
                {
                    Fruit fruit = new Fruit(randomx.Next(3, 45), randomy.Next(3, 18));

                    fruitView.DisplayFruit(fruit);
                    eatFruit(game, snake, fruit);

                }


            } while (game.isGameOn );
        }*/




    }
}
