using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Représente les dimentions de la zone de jeu
    /// </summary>
    class GameArea
    {
        private int areaHeight;
        private int areaWidth;

        public int Height { get => areaHeight; }
        public int Width { get => areaWidth; }

        public GameArea(int width=50, int height=20)
        {
            if ((width > 0) && (height > 0))
            {
                areaHeight = height;
                areaWidth = width;
            }
            else
                throw new Exception("Les valeurs de dimensions doivent être strictement positives.");
        }
    }
}
