using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Define the coordinates (x, y) of a position 
    /// </summary>
    class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            // Define the initial position of the snake 
            this.x = x;
            this.y = y;
        }

        public Position(Position PositionToClone)
        {
            // Define the initial position of the snake 
            x = PositionToClone.x;
            y = PositionToClone.y;
        }

    }
}
