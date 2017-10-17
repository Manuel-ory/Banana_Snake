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


        public Direction GetLastKey(Snake snake)
        {
            ConsoleKey readKey;
            Direction newDirection = snake.HeadDirection;

            while (Console.KeyAvailable)
            {
                readKey = Console.ReadKey(true).Key;

                switch (readKey)
                {
                    case ConsoleKey.Q:
                        if (snake.HeadDirection != Direction.right)
                            newDirection = Direction.left;
                        break;

                    case ConsoleKey.S:
                        if (snake.HeadDirection != Direction.up)
                            newDirection = Direction.down;
                        break;

                    case ConsoleKey.Z:
                        if (snake.HeadDirection != Direction.down)
                            newDirection = Direction.up;
                        break;

                    case ConsoleKey.D:
                        if (snake.HeadDirection != Direction.left)
                            newDirection = Direction.right;
                        break;

                    case ConsoleKey.Spacebar:
                        Game.SwitchPause();
                        break;
                }
            }

            return newDirection;
        }
        
        public void GetSnakeTomove(Snake snake)
        FruitView fruitView = new FruitView();


        public void GetSnakeTomove(Snake snake, Game game)
        {
            Random randomx = new Random();
            Random randomy = new Random();

            do
            {

                snake.AddHeadToBody();
                
                if (Game.fruitEat == false)
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
