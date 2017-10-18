using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.View
{
    /// <summary>
    /// Permet d'afficher le score
    /// </summary>
    static class ScoreView
    {
        static int scorePosY;

        /// <summary>
        /// Indique la position verticale du score
        /// </summary>
        /// <param name="yPos"></param>
        public static void SetScorePosition(int yPos)
        {
            scorePosY = yPos;
        }

        /// <summary>
        /// Affiche le score
        /// </summary>
        /// <param name="score"></param>
        public static void Draw(Score score)
        {
            Console.SetCursorPosition(1, scorePosY);
            Console.Write("Score : " + score.ScoreValue);
        }

    }
}
