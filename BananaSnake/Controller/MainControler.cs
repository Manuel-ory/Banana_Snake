﻿using System;
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
            CollisionController collisionController = new CollisionController();

            Console.Title = "BananaSnake game";
            GameAreaView.GameAera = gameAreaModel;
            GameAreaView.Draw();


            //Ready
            Console.ReadKey(true);

            while (Game.isGameOn)
            {
                //Récupère nouvelle direction serpent
                newDirection = KeyController.GetLastKey(snakeModel);

                if (!Game.isGamePaused)
                {
                    //Controller collisions
                    //Check collisions (mur, serpent, fruit)
                    Game.isWallHit = collisionController.IsHitWall(snakeModel, gameAreaModel, newDirection);
                    //Game.isFruitEat = collisionController.IsHitFruit(snakeModel,)
                    //Act selon collisions
                    //Controller AvancerSerpent
                    snakeControler.MoveSnake(snakeModel, 
                        newDirection, 
                        Game.isWallHit,
                        false,
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
                System.Threading.Thread.Sleep(250);
            }

            //Score

            //Fin du jeu
        }

    }
}
