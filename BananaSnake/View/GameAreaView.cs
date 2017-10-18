using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.View
{
    /// <summary>
    /// Affiche la zone de jeu
    /// </summary>
    static class GameAreaView
    {
        private static GameArea gameAera;

        public static GameArea GameAera { get => gameAera; set => gameAera = value; }

        /// <summary>
        /// Sert à générer le cadre de la zone de jeu.
        /// </summary>
        /// <param name="width">Largeur de la fenêtre</param>
        /// <param name="height">Hauteur de la fenêtre</param>
        /// <returns>La chaine de caractère utilisée pour afficher le cadre de la zone de jeu</returns>
        static private string GenerateBorder(int width, int height)
        {
            string result = "";
            string upDownLines = "";
            string otherLines = "";

            for (int i = 0; i < width; i++)
            {

                if ((i == 0) || (i == width - 1))
                {
                    otherLines += "|";
                    upDownLines += "+";
                }
                else
                {
                    otherLines += " ";
                    upDownLines += "-";
                }
            }

            for (int i = 0; i < height; i++)
            {
                if ((i == 0) || (i == height - 1) || (i == height - 3))
                    result += upDownLines;
                else
                    result += otherLines;
            }

            return result;
        }

        /// <summary>
        /// Dessine la zone de jeu. En profite aussi pour redimentionner la console.
        /// </summary>
        public static void Draw()
        {
            int windowWidth = gameAera.Width + 2;
            int windowHeight = gameAera.Height + 4;
            string borders = GenerateBorder(windowWidth, windowHeight);

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight+1);
            Console.SetBufferSize(windowWidth, windowHeight+1);
            Console.Write(borders);
            ScoreView.SetScorePosition(windowHeight - 2);

        }


    }
}
