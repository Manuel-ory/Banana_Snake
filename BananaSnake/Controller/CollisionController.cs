using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class CollisionController
    {
        /// <summary>
        /// Return true if snake hit himself
        /// </summary>
        /// <returns></returns>
        public bool IsHitSnake(Snake snake, Direction direction)
        {
            if (snake.BodyPosition.Contains(snake.HeadPosition))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Return true if collision with wall
        /// </summary>
        /// <returns></returns>
        public bool IsHitWall(Snake snake, GameArea gameArea, Direction direction)
        {
            switch (direction)
            {
                case Direction.left:
                    if (snake.HeadPosition.x == 0)
                        return true;
                    break;

                case Direction.down:
                    if (snake.HeadPosition.y + 1 == gameArea.Height)
                        return true;
                    break;

                case Direction.up:
                    if (snake.HeadPosition.y == 0)
                        return true;
                    break;

                case Direction.right:
                    if (snake.HeadPosition.x + 1 == gameArea.Width)
                        return true;
                    break;

            }

            return false;
        }

        /// <summary>
        /// Return true if collision with fruit 
        /// </summary>
        /// <returns></returns>
        public bool IsHitFruit(Snake snake, Fruit fruit, Direction direction, GameArea gameArea)
        {
            if (fruit.existingTicksLeft > 0)
            {
                switch (direction)
                {
                    case Direction.left:
                        if(((snake.HeadPosition.x + gameArea.Width -1) % gameArea.Width) == fruit.FruitPosition.x 
                            && snake.HeadPosition.y == fruit.FruitPosition.y)
                        {
                            return true;
                        }
                        break;

                    case Direction.down:
                        if (snake.HeadPosition.x == fruit.FruitPosition.x 
                            && ((snake.HeadPosition.y +1) % gameArea.Height) == fruit.FruitPosition.y)
                        {
                            return true;
                        }
                        break;

                    case Direction.up:
                        if (snake.HeadPosition.x  == fruit.FruitPosition.x 
                            && ((snake.HeadPosition.y + gameArea.Height - 1) % gameArea.Height) == fruit.FruitPosition.y)
                        {
                            return true;
                        }
                        break;

                    case Direction.right:
                        if (((snake.HeadPosition.x +1)% gameArea.Width) == fruit.FruitPosition.x 
                            && snake.HeadPosition.y == fruit.FruitPosition.y)
                        {
                            return true;
                        }
                        break;

                }

            }

            return false;
        }

    }
}
