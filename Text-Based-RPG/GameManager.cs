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

            Map map = new Map();
            Player player = new Player();
            Enemy enemy = new Enemy();
            GameObject game = new GameObject();
            HealthPotion healthPotion = new HealthPotion();
            KeyItem keyItem = new KeyItem();
            PowerUp powerUp = new PowerUp();
            Door door = new Door();
            HUD hud = new HUD();

            // Game Start
            player.Start();
            enemy.Start(15, 15);
            healthPotion.Start(5, 5);
            keyItem.Start(13, 12);
            powerUp.Start(16, 16);
            door.Start(21, 10);


            // Gameplay Loop
            while (player.isAlive)
            {
                hud.Draw(player);
                map.Draw();
                player.Draw();
                enemy.Draw();
                healthPotion.Draw('P');
                keyItem.Draw('k');
                powerUp.Draw('#');
                door.Draw('▓');


                map.Update();
                player.Update(map, enemy, door);
                enemy.Update(map, player, door);
                healthPotion.Update(player);
                keyItem.Update(player, door);
                powerUp.Update(player, enemy);
            }
        }
    }
}
