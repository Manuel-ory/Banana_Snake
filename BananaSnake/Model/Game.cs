using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Contient les valeurs des paramètres globaux du jeu
    /// </summary>
    static class Game
    {
        public static bool isGameOn=true;                   //jeu en cours
        public static bool isGamePaused=false;              //jeu en pause
        public static bool isSnakeHitHimself=false;         //Serpent se mange lui-même
        public static bool isFruitAppearOnSnake = false;    //le fruit est apparu dans le serpent
        public static int speed=250;                    //Vitesse de jeu
        public static bool isFruitEat=false;                //Le fruit a été mangé
        public static bool isWallHit=false;                 // Condition passage autre coté. À voir si nécessaire ici ?

        public static void SwitchPause()
        {
            isGamePaused = !isGamePaused;
        }
    


    }
}
