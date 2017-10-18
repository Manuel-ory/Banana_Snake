using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.View
{
    static class GameOver
    {

        public static void Draw(int score, GameArea gameArea)
        {
            for(int i = 0; i< gameArea.Height; i++)
            {
                Console.SetCursorPosition(1, i + 1);
                for(int j = 0; j < gameArea.Width; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(gameArea.Width / 2 - 3, gameArea.Height / 2 - 1);
            Console.Write("Score:");
            Console.SetCursorPosition(gameArea.Width/ 2 - 2, gameArea.Height/ 2);
            Console.Write(score);
            Console.SetCursorPosition(1, gameArea.Height);
            Console.Write("Game designed by: Anthony Maudry");
        }

    }
}
