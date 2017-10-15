using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    class Snake
    {
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
            BodyPosition.Insert(0, HeadPosition);
        }

        /// <summary>
        /// Delete the position of the last part of the body.
        /// </summary>
        public void DeleteBodyEnd()
        {
            BodyPosition.RemoveAt(BodyPosition.Count-1);
        }

        public Snake()
        {
            this.HeadPosition = new Position();
        }
    }
}
