using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.Controller
{
    class SnakeControler
    {
        public void MoveSnake(Snake snake, Direction newDirection, bool isWallHit, GameArea gameArea)
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
        }
        }
        {

        }
    }
}
