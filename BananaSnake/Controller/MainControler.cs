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
            //*************************SETUP*************************
            //Model
            GameArea gameAreaModel = new GameArea(50,20);
            Snake snakeModel = new Snake();
            Score scoreModel = new Score();
            FruitFactory fruitFactory = new FruitFactory();
            Fruit fruitModel = fruitFactory.CreateFruit(gameAreaModel);
            
            //Controllers
            ControlKey KeyController = new ControlKey();
            SnakeControler snakeControler = new SnakeControler();
            FruitControler fruitControler = new FruitControler();
            CollisionController collisionController = new CollisionController();

            Direction newDirection;

            //Views
            Console.Title = "BananaSnake game";
            TetrisMusic.StartMusic();
            GameAreaView.GameAera = gameAreaModel;
            GameAreaView.Draw();
            SnakeView.DrawAllSnake(snakeModel);

            //*************************READY*************************
            Console.ReadKey(true);

            //*************************START*************************
            while (Game.isGameOn)
            {
                //Récupère nouvelle direction serpent
                newDirection = KeyController.GetLastKey(snakeModel);
                
                if (!Game.isGamePaused)
                {
                    //Controler collisions
                    Game.isWallHit = collisionController.IsHitWall(snakeModel, gameAreaModel, newDirection);//Mintenant inutile
                    Game.isFruitEat = collisionController.IsHitFruit(snakeModel, fruitModel, newDirection, gameAreaModel);
                    Game.isSnakeHitHimself = collisionController.IsHitSnake(snakeModel);
                    Game.isFruitAppearOnSnake = collisionController.IsFruitAppearOnSnake(snakeModel, fruitModel);

                    //Controler fruit
                    fruitModel = fruitControler.UpdateFruit(fruitModel, Game.isFruitEat, Game.isFruitAppearOnSnake, fruitFactory, gameAreaModel, scoreModel);

                    //Controler serpent
                    snakeControler.MoveSnake(snakeModel, 
                        newDirection, 
                        Game.isFruitEat,
                        gameAreaModel);

                    //Game Over
                    if (Game.isSnakeHitHimself)
                    {
                        Game.isGameOn = false;
                    }

                    
                }
                //Dessiner jeu
                ViewStratege.DrawView(scoreModel, gameAreaModel, snakeModel, fruitModel);
                if (!Game.isGameOn)
                {
                    Console.ReadKey();
                }
                
                //Attendre prochain tick
                System.Threading.Thread.Sleep(250);
            }

            
            //Fin du jeu
        }

    }
}
