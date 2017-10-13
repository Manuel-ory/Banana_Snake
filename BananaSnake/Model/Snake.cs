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
        Position HeadPosition { get; set; }

        /// <summary>
        /// Store the direction of the head of the snake.
        /// </summary>
        Direction HeadDirection { get; set; }

        /// <summary>
        /// Store the position of each part of the snake body (excluding the head).
        /// </summary>
        List<Position> BodyPosition { get; set; }

        /// <summary>
        /// Add the head position to the beginning of the body list.
        /// </summary>
        void AddHeadToBody()
        {
            BodyPosition.Insert(0, HeadPosition);
        }

        /// <summary>
        /// Delete the position of the last part of the body.
        /// </summary>
        void DeleteBodyEnd()
        {
            BodyPosition.RemoveAt(BodyPosition.Count-1);
        }
    }
}
