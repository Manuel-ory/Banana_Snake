using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    /// <summary>
    /// Permet d'afficher le serpent
    /// </summary>
    static class SnakeView
    {
        /// <summary>
        /// Efface le bout de queue du serpent
        /// </summary>
        /// <param name="tailPos">Position du bout de queue</param>
        public static void ClearTail(Position tailPos)
        {
            Console.SetCursorPosition(tailPos.x + 1, tailPos.y + 1);
            Console.Write(Game.emptyCase);
        }

        /// <summary>
        /// Efface le bout de queue du serpent
        /// </summary>
        /// <param name="snake">Serpent</param>
        public static void ClearTail(Snake snake)
        {
            Console.SetCursorPosition(snake.TailPosition.x + 1, snake.TailPosition.y + 1);
            Console.Write(Game.emptyCase);
        }

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
                    head = Game.headSnakeUp;
                    break;
                case Direction.right:
                    head = Game.headSnakeRight;
                    break;
                case Direction.down:
                    head = Game.headSnakeDown;
                    break;
                case Direction.left:
                    head = Game.headSnakeLeft;
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(snake.HeadPosition.x + 1, snake.HeadPosition.y + 1);
            Console.Write(head);

            //Remplace la dernière tête
            Console.SetCursorPosition(snake.BodyPosition.First().x + 1, snake.BodyPosition.First().y + 1);
            Console.Write(Game.bodySnake);
            Console.ResetColor();

        }

        /// <summary>
        /// Dessine l'intégralité du serpent
        /// </summary>
        /// <param name="snake">serpent à dessiner</param>
        public static void DrawAllSnake(Snake snake)
        {
            DrawHead(snake);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            foreach (Position position in snake.BodyPosition)
            {
                Console.SetCursorPosition(position.x + 1, position.y + 1);
                Console.Write(Game.bodySnake);
            }
            Console.ResetColor();


        }
    }
}
