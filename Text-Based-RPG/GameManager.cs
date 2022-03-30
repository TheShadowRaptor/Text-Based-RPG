﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameManager
    {
        public void GameLoop()
        {
            // Initialisation

            // Maps
            Map map = new Map();

            // Game Characters
            GameCharacter gameCharacter = new GameCharacter();
            Player player = new Player();
            WeakEnemy weakEnemy = new WeakEnemy();
            NormalEnemy normalEnemy = new NormalEnemy();
            ToughEnemy toughEnemy = new ToughEnemy();
            Boss_Enemy bossEnemy = new Boss_Enemy();

            EnemyManager enemyManager = new EnemyManager();
            ItemManager itemManager = new ItemManager();

            EndGame endGame = new EndGame();
            StartMenu startMenu = new StartMenu();

            Camera camera = new Camera();
            Render render = new Render();

            // GameObjects
            GameObject gameObject = new GameObject();
            HealthPotion healthPotion = new HealthPotion();
            KeyItem keyItem = new KeyItem();
            PowerUp powerUp = new PowerUp();
            Door door = new Door();

            // HUDs
            HUD hud = new HUD();

            // Game Start
            startMenu.StartGame();
            render.Start();
            
            player.Start();
            enemyManager.Start();
            itemManager.Start();
            keyItem.Start(92, 55);            
            door.Start(46, 20);
            Console.SetCursorPosition(0, 0);

            // ---------------------- Gameplay Loop -------------------------
            

            while (player.isAlive || bossEnemy.isAlive)
            {
                map.Draw(render, camera);
                player.Draw(render, camera);
                enemyManager.Draw(render, camera);
                itemManager.Draw(render, camera);
                keyItem.Draw('k', render, camera);
                door.Draw('▓', render, camera);
                //hud.Draw(player, enemyManager);
                player.LateUpdate();
                

                player.Update(map, door, enemyManager);
                enemyManager.Update(map, player, door);
                itemManager.Update(player, weakEnemy);
                keyItem.Update(player, door);
                camera.Update(player);
            }

            // -------------------- Game Over ----------------------------
                endGame.GameOver(player, bossEnemy);                       
        }
    }
}
