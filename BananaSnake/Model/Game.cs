using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    class Game
    {
        public bool isGameOn = true; //jeu en cours
        public bool isSnakeHitHimself = false; //condition partie perdue

        public bool isWallHit = false; // Condition passage autre coté a voir si nécessaire ici ?
    }
}
