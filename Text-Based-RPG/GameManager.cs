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
            Enemy enemy = new Enemy();
            Enemy enemy2 = new Enemy();
            Enemy enemy3 = new Enemy();

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
            enemy.Start(15, 15, 100, 10, 1); // can create a new enemy by simply altering the Start parameters...
            enemy2.Start(12, 10, 50, 5, 2);  // ...and I'm not sure if its smart or stupid
            enemy3.Start(45, 20, 150, 25, 1);
            healthPotion.Start(16, 18);
            keyItem.Start(50, 12);
            powerUp.Start(35, 10);
            door.Start(21, 10);

            // ---------------------- Gameplay Loop -------------------------

            while (player.isAlive)
            {
                hud.Draw(player);
                map.Draw();
                player.Draw();
                enemy.Draw('E');
                enemy2.Draw('T');
                enemy3.Draw('B');
                healthPotion.Draw('P');
                keyItem.Draw('k');
                powerUp.Draw('#');
                door.Draw('▓');

                map.Update();
                player.Update(map, enemy, door, enemy2, enemy3);
                enemy.Update(map, player, door);
                enemy2.Update(map, player, door);
                enemy3.Update(map, player, door);
                healthPotion.Update(player);
                keyItem.Update(player, door);
                powerUp.Update(player, enemy);
            }

            // ---------------------------------------------------------------
        }
    }
}
