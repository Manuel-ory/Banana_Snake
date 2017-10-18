using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Modèle du serpent
    /// </summary>
    class Snake
    {
        //public ConsoleColor SnakeColor; 
        public bool isWallHit = false;
        /// <summary>
        /// Store the current position of the head of the snake.
        /// </summary>
        public Position HeadPosition { get; set; }


        public int sizeBodyInitial;
        /// <summary>
        /// Store the direction of the head of the snake.
        /// </summary>
        public Direction HeadDirection { get; set; }

        /// <summary>
        /// Store the position of each part of the snake body (excluding the head).
        /// </summary>
        public List<Position> BodyPosition { get; set; }

        /// <summary>
        /// Add the head position to the beginning of the body list.
        /// </summary>
        public void AddHeadToBody()
        {

            BodyPosition.Insert(0,new Position( HeadPosition));
        }

        /// <summary>
        /// Delete the position of the last part of the body.
        /// </summary>
        public void DeleteBodyEnd()
        {
            TailPosition = BodyPosition[BodyPosition.Count-1];
            BodyPosition.RemoveAt(BodyPosition.Count-1);
        }

        public Position TailPosition { get; set; }


        /// <summary>
        /// Constructor of the snake. Snake of 4 parts with a determinate position
        /// </summary>
        public Snake()
        {
            this.sizeBodyInitial = 3;
            //Add three parts of body
            this.HeadPosition = new Position(5, 1);
            this.TailPosition = new Position(2, 1);
            this.HeadDirection = Direction.right;
            this.BodyPosition = new List<Position>();

            for (int i = 0; i < sizeBodyInitial; i++)
            {
                this.AddHeadToBody();
                this.HeadPosition.x++;
            }
            
        }
    }
}
