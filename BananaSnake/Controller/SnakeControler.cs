﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.Controller
{
    /// <summary>
    /// S'occupe des actions sur le serpent
    /// </summary>
    class SnakeControler
    {
        /// <summary>
        /// Bouge le serpent d'1 case
        /// </summary>
        /// <param name="snake">Le serpent à bouger</param>
        /// <param name="newDirection">la direction du serpent</param>
        /// <param name="isWallHit">Le serpent a touché le mur ?</param>
        /// <param name="isFruitEaten">Le serpent a mangé un fruit ?</param>
        /// <param name="gameArea">l'aire de jeu.</param>
        public void MoveSnake(Snake snake, Direction newDirection, bool isWallHit, bool isFruitEaten, GameArea gameArea)
        {
            snake.AddHeadToBody();
            snake.HeadDirection = newDirection;

            if (isWallHit)
            {
                switch (newDirection)
                {
                    case Direction.up:
                        snake.HeadPosition.y = gameArea.Height - 1;
                        break;
                    case Direction.right:
                        snake.HeadPosition.x = 0;
                        break;
                    case Direction.down:
                        snake.HeadPosition.y = 0;
                        break;
                    case Direction.left:
                        snake.HeadPosition.x = gameArea.Width - 1;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (newDirection)
                {
                    case Direction.up:
                        snake.HeadPosition.y--;
                        break;
                    case Direction.right:
                        snake.HeadPosition.x++;
                        break;
                    case Direction.down:
                        snake.HeadPosition.y++;
                        break;
                    case Direction.left:
                        snake.HeadPosition.x--;
                        break;
                    default:
                        break;
                }
            }

            if (!isFruitEaten)
                snake.DeleteBodyEnd();
        }
        

    }
}
