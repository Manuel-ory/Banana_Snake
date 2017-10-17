using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;
using BananaSnake.View;


namespace BananaSnake.Controller
{
    class MainControler
    {


        public static void Execute()
        {
            //Setup
            GameArea gameAreaModel = new GameArea(50,20);
            Snake snakeModel = new Snake();
            Score scoreModel = new Score();
            Direction newDirection;
            ControlKey KeyController = new ControlKey();
            SnakeControler snakeControler = new SnakeControler();

            Console.Title = "BananaSnake game";
            GameAreaView.GameAera = gameAreaModel;
            GameAreaView.Draw();


            //Ready
            Console.ReadKey(true);

            while (Game.isGameOn)
            {
                newDirection = KeyController.GetLastKey(snakeModel);

                if (Game.isGamePaused)
                {
                    //Controller collisions
                    //Check collisions (mur, serpent, fruit)
                    //Act selon collisions
                    //Controller AvancerSerpent
                    snakeControler.MoveSnake(snakeModel, 
                        newDirection, 
                        Game.isWallHit, 
                        gameAreaModel);
                    //Dessiner jeu
                    SnakeView.ClearTail(snakeModel.TailPosition);
                    SnakeView.DrawHead(snakeModel);

                }
                else
                {
                    //Dessine pause
                }

                //Attendre prochain tick
            }

            //Score

            //Fin du jeu
        }

    }
}
