using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class Clock
    {
        private int tickDuration;

        private System.DateTime nextTick = new System.DateTime();

        /// <summary>
        /// Create a clock to make regular ticks
        /// </summary>
        /// <param name="duration">The duration of each tick in milliseconds</param>
        public Clock(int duration = 250)
        {
            tickDuration = duration;
        }

        void WaitNextTick()
        {
            nextTick += new TimeSpan(0, 0, 0, 0, tickDuration);
            Thread.Sleep(nextTick - new System.DateTime());
        }

    }
}
