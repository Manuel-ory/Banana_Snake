using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    class Snake
    {
        public ConsoleColor SnakeColor; 
        public bool isWallHit = false;
        /// <summary>
        /// Store the current position of the head of the snake.
        /// </summary>
        public Position HeadPosition { get; set; }

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
            //Add three parts of body
            this.HeadPosition = new Position(25, 19);
            
            this.TailPosition = new Position(25, 19);
            this.BodyPosition = new List<Position>();
            this.AddHeadToBody();
            this.HeadPosition.x++;
            this.AddHeadToBody();
            this.HeadPosition.x++;
            this.AddHeadToBody();
            //Add head of the snake
            this.HeadPosition.x++;
            
        }

        public bool DidSnakeHitWall()
        {
            if (this.HeadPosition.x == 1 || this.HeadPosition.x == 50 || this.HeadPosition.y == 1 || this.HeadPosition.y == 20)
            {
                return true;
            }
            return false;
        }
    }
}
