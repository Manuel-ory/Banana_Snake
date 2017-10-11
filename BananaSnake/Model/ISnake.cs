using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    interface ISnake
    {
        /// <summary>
        /// Get the position of the snake head.
        /// </summary>
        /// <returns>List<int> : with 2 values of x and y of the head.</returns>
        List<int> GetHeadPosition();

        /// <summary>
        /// Get the direction of the head.
        /// </summary>
        /// <returns>int : value of the direction (1=up, 2=right, 3=down, 4=left).</returns>
        int GetHeadDirection();

        /// <summary>
        /// Get the position of each part of the snake body.
        /// </summary>
        /// <returns>List<List<int>> : list of the position (x, y) of each part of the body.</returns>
        List<List<int>> GetBodyposition();

        /// <summary>
        /// Set the direction of the head (can't make a U-turn)
        /// </summary>
        /// <param name="value">1=up, 2=right, 3=down, 4=left</param>
        void SetHeadDirection(int value);

        /// <summary>
        /// Update the position of the snake at each tick.
        /// </summary>
        void Update();
    }
}
