using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;
using BananaSnake.Model.Factory;
using BananaSnake.View;


namespace BananaSnake.Controller
{
    /// <summary>
    /// Gère le jeu dans son ensemble fonctionnel, instanciant les modèles, appellant les autres controlleurs et rafraichissant les vues.
    /// </summary>
    static class MainControler
    {
        /// <summary>
        /// exécute le contrôleur principal
        /// </summary>
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

            FruitFactory fruitFactory = new FruitFactory();
            Fruit fruit = fruitFactory.CreateFruit(gameAreaModel);


            Console.Title = "BananaSnake game";
            TetrisMusic.StartMusic();
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

                    Game.isWallHit = collisionController.IsHitWall(snakeModel, gameAreaModel, newDirection);//Mintenant inutile
                    Game.isFruitEat = collisionController.IsHitFruit(snakeModel, fruit, newDirection, gameAreaModel);

                    Game.isSnakeHitHimself = collisionController.IsHitSnake(snakeModel);
                    //Act selon collisions

                    //Controller AvancerSerpent

                    if (Game.isFruitEat)
                    {
                        fruit = fruitFactory.CreateFruit(gameAreaModel);
                        scoreModel.ScoreValue = scoreModel.ScoreValue + fruit.earnedPoints;
                    }
                    else
                    {
                        if(fruit.existingTicksLeft == 0)
                        {
                            FruitView.ClearFruit(fruit);
                            fruit = fruitFactory.CreateFruit(gameAreaModel);
                        }
                        else
                        {
                            fruit.existingTicksLeft--;
                        }
                        
                    }


                    snakeControler.MoveSnake(snakeModel, 
                        newDirection, 
                        Game.isFruitEat,
                        gameAreaModel);


                    if (Game.isSnakeHitHimself)
                    {
                        Game.isGameOn = false;
                        break;
                    }

                    //Dessiner jeu
                    SnakeView.ClearTail(snakeModel.TailPosition);
                    SnakeView.DrawHead(snakeModel);
                    ScoreView.Draw(scoreModel);

                    FruitView.DisplayFruit(fruit);

                   

                }
                else
                {
                    //Dessine pause
                }

                //Attendre prochain tick
                System.Threading.Thread.Sleep(250);
            }

            //Score
            //ScoreView.Draw(scoreModel);

            //Fin du jeu
        }

    }
}
