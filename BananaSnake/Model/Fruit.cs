using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Objet représentant un fruit, avec une position, une couleur et un temps de vie.
    /// </summary>
    class Fruit
    {
        public ConsoleColor FruitColor;
        public Position FruitPosition { get; set; }

        public int existingTicksLeft = 40;
        public int earnedPoints = 50;


        public Fruit(int xposition, int yposition , ConsoleColor color)
        {
            this.FruitPosition = new Position(xposition, yposition);
            this.FruitColor = color; 

        }



    }
}
