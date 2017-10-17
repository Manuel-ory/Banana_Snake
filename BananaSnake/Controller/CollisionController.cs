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
        public bool IsHitSnake(Snake snake)
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
            if (snake.HeadPosition.x == 0 || snake.HeadPosition.x == gameArea.Width -1 || snake.HeadPosition.y == 0 || snake.HeadPosition.y == gameArea.Height - 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return true if collision with fruit 
        /// </summary>
        /// <returns></returns>
        public bool IsHitFruit(Snake snake, Fruit fruit)
        {
            if (fruit.existingTicksLeft > 0 && snake.HeadPosition == fruit.FruitPosition)
            {
                fruit.existingTicksLeft = 0;
                return true;
            }
            return false;
        }

    }
}
