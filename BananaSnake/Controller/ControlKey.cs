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
        //ConsoleKey command = Console.ReadKey(true).Key;


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

        FruitView fruitView = new FruitView();



        public void eatFruit(Snake snake , Fruit fruit) {
            if (snake.HeadPosition == fruit.FruitPosition)
            {
                Game.isFruitEat = false;
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
