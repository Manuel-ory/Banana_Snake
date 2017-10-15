using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    class GameAreaView
    {
        private static int gameAeraWidth = 50;
        private static int gameAeraHeight = 20;

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
            int windowWidth = gameAeraWidth + 2;
            int windowHeight = gameAeraHeight + 4;
            string borders = GenerateBorder(windowWidth, windowHeight);

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight+1);
            Console.SetBufferSize(windowWidth, windowHeight+1);
            Console.Write(borders);
            ScoreView.SetScorePosition(windowHeight - 2);

        }

        /// <summary>
        /// (Re)définit la taille de l'aire de jeu. La fenêtre sera plus grande pour permettre l'affichage des bordures et du score.
        /// </summary>
        /// <param name="width">Largeur de l'aire de jeu (défaut 50)</param>
        /// <param name="height">Hauteur de l'aire de jeu (défaut 20)</param>
        /// <returns>true si les valeurs sont valides et ont été modifiées.</returns> 
        public static bool SetAeraSize(int width =50, int height = 20)
        {
            if ((width > 0) && (height > 0))
            {
                gameAeraWidth = width;
                gameAeraHeight = height;
                return true;
            }
            else
                return false;
        }


    }
}
