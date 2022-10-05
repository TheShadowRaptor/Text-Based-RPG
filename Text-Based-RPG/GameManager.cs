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

            // Inventory
            Inventory inventory = new Inventory();
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
            Render render = new Render(camera);

            // GameObjects
            GameObject gameObject = new GameObject();
            HealthPotion healthPotion = new HealthPotion();
            KeyItem keyItem = new KeyItem();
            PowerUp powerUp = new PowerUp();

            // HUDs
            HUD hud = new HUD();
            Shop shop = new Shop();

            // Game Start
            startMenu.StartGame();

            player.Start();
            enemyManager.Start();
            itemManager.Start();            
            shop.Start();

            // set camera initially
            camera.Update(player);
            player.Draw(render, camera);

            // ---------------------- Gameplay Loop -------------------------
            while (enemyManager.bossEnemy.isAlive && player.isAlive)
            {
                map.Draw(render, camera);
                shop.Draw(render, camera);
                player.Draw(render, camera);
                itemManager.Draw(render, camera);
                keyItem.Draw('k', render, camera);                              
                enemyManager.Draw(render, camera);
                hud.Draw(player, enemyManager, inventory);

                player.Update(map, enemyManager, itemManager, shop, inventory, gameObject, render);
                enemyManager.Update(map, player, shop, itemManager);
                itemManager.Update(player, weakEnemy, enemyManager, inventory);
                powerUp.Update(player, enemyManager);
                camera.Update(player);       
            }

            // -------------------- Game Over ----------------------------
                endGame.GameOver(player, bossEnemy);                       
        }
    }
}
