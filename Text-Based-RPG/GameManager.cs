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
            HUD hud = new HUD();

            // Game Start
            player.Start();
            enemy.Start(15, 15);

            // Gameplay Loop
            while (player.isAlive)
            {
                hud.Draw(player);
                map.Draw();
                player.Draw();
                enemy.Draw();

                map.Update();
                player.Update(map, enemy);
                enemy.Update(map, player);
            }
        }
    }
}
