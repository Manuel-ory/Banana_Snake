using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    class Fruit
    {
        public ConsoleColor FruitColor;
        public Position FruitPosition { get; set; }


        public Fruit(int xposition, int yposition , ConsoleColor color)
        {
            this.FruitPosition = new Position(xposition, yposition);
            this.FruitColor = color; 

        }

    }
}
