using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.View
{
    class ScoreView
    {
        static int scorePosY;

        public static void SetScorePosition(int yPos)
        {
            scorePosY = yPos;
        }

        public static void Draw(Score score)
        {
            Console.SetCursorPosition(1, scorePosY);
            Console.Write("Score : " + score.ScoreValue);
        }

    }
}
