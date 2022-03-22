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
            EnemyManager enemyManager = new EnemyManager();

            // GameObjects
            GameObject gameObject = new GameObject();
            HealthPotion healthPotion = new HealthPotion();
            KeyItem keyItem = new KeyItem();
            PowerUp powerUp = new PowerUp();
            Door door = new Door();

            // HUDs
            HUD hud = new HUD();

            // Game Start
            player.Start();
            enemyManager.Start();
            normalEnemy.Start(15, 10);
            toughEnemy.Start(45, 20);
            healthPotion.Start(16, 18);
            keyItem.Start(50, 12);
            powerUp.Start(9, 10);
            door.Start(21, 10);

            // ---------------------- Gameplay Loop -------------------------

            while (player.isAlive)
            {                
                map.Draw(player);
                hud.Draw(player, weakEnemy, normalEnemy, toughEnemy);
                player.Draw();
                enemyManager.Draw();
                healthPotion.Draw('P');
                keyItem.Draw('k');
                powerUp.Draw('#');
                door.Draw('▓');

                map.Update();
                player.Update(map, weakEnemy, door, normalEnemy, toughEnemy);
                enemyManager.Update(map, player, door);
                healthPotion.Update(player);
                keyItem.Update(player, door);
                powerUp.Update(player, weakEnemy);
            }

            // ---------------------------------------------------------------
        }
    }
}
