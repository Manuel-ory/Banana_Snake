using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    class GameOver
    {
        private int width, height;

        public GameOver(int gameWidth=50, int gameHeight=20)
        {
            this.width = gameWidth;
            this.height = gameHeight;
        }

        public void Draw(int score)
        {
            for(int i = 0; i<height; i++)
            {
                Console.SetCursorPosition(1, i + 1);
                for(int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(width/2 - 3, height/2 - 1);
            Console.Write("Score:");
            Console.SetCursorPosition(width/2 - 2, height/2);
            Console.Write(score);
            Console.SetCursorPosition(1, height);
            Console.Write("Game designed by: Anthony Maudry");
        }

    }
}
