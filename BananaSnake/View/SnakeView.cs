using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    class SnakeView
    {

        public static void ClearTail(Position tailPos)
        {
            Console.SetCursorPosition(tailPos.x + 1, tailPos.y + 1);
            Console.Write(' ');
        }

        /*public static void ClearTail(Snake snake)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.SetCursorPosition(tailPos.x + 1, tailPos.y + 1);
            Console.Write(' ');
            Console.ResetColor();
        }*/

        /// <summary>
        /// Redessine la tête du serpent
        /// </summary>
        /// <param name="snake">Serpent dont on redessine la tête</param>
        public static void DrawHead(Snake snake)
        {
            //Dessine la tête
            char head =' ';
            switch (snake.HeadDirection)
            {
                case Direction.up:
                    head = '^';
                    break;
                case Direction.right:
                    head = '>';
                    break;
                case Direction.down:
                    head = 'v';
                    break;
                case Direction.left:
                    head = '<';
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(snake.HeadPosition.x + 1, snake.HeadPosition.y + 1);
            Console.Write(head);

            //Remplace la dernière tête
            Console.SetCursorPosition(snake.BodyPosition.First().x + 1, snake.BodyPosition.First().y + 1);
            Console.Write('█');
            Console.ResetColor();

        }
    }
}
