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

        private System.DateTime nextTick;

        /// <summary>
        /// Create a clock to make regular ticks
        /// </summary>
        /// <param name="duration">The duration of each tick in milliseconds</param>
        public Clock(int duration = 250)
        {
            tickDuration = duration;
        }

        public void StartClock()
        {
            nextTick = System.DateTime.Now;
        }

        public void WaitNextTick()
        {
            nextTick = nextTick.AddMilliseconds(tickDuration);
            if (nextTick - System.DateTime.Now > TimeSpan.FromMilliseconds(0))
            {
                Thread.Sleep(nextTick - System.DateTime.Now);
            }
        }

    }
}
