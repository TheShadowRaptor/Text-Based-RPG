using System;
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
            Screen screen = new Screen();

            EndGame endGame = new EndGame();
            StartMenu startMenu = new StartMenu();

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

            screen.Start();
            player.Start();
            enemyManager.Start();
            itemManager.Start();
            keyItem.Start(67, 45);
            powerUp.Start(9, 10);
            door.Start(21, 10);

            // ---------------------- Gameplay Loop -------------------------
            while (player.isAlive || bossEnemy.isAlive)
            {
                map.Draw();
                hud.Draw(player, weakEnemy, normalEnemy, toughEnemy);
                player.Draw(map);
                enemyManager.Draw();
                itemManager.Draw();
                keyItem.Draw('k');
                powerUp.Draw('#');
                door.Draw('▓');

                player.Update(map, door, enemyManager);
                enemyManager.Update(map, player, door);
                itemManager.Update(player);
                keyItem.Update(player, door);
                powerUp.Update(player, weakEnemy);
                if (player.canMove) screen.MoveCamera(player.keyPressed);
            }

            // -------------------- Game Over ----------------------------
                endGame.GameOver(player, bossEnemy);                       
        }
    }
}
