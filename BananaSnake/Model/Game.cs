using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    static class Game
    {
        public static bool isGameOn=true; //jeu en cours
        public static bool isSnakeHitHimself=false; //condition partie perdue
        public static int gameSpeed=150;
        

        public static bool isWallHit=false; // Condition passage autre coté a voir si nécessaire ici ?

        public static ConsoleKey lastControl=  new ConsoleKey();

    

    

    }
}
