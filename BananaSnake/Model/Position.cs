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

        public Position()
        {
            // Define the initial position of the snake 
            this.x = 25;
            this.y = 19;
        }

    }
}
