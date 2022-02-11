using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Program
    {
        // Declerations
       

        static void Main(string[] args)
        {
            // Initialisation

            Map map = new Map();
            Player player = new Player();
            Enemy enemy = new Enemy();
            HUD hud = new HUD();

            // Game Start
            player.Start();
            enemy.Start();

            // Gameplay Loop
            while (player.isAlive)
            {
                hud.Draw(player);
                map.Draw();
                player.Draw();
                enemy.Draw();              

                map.Update();
                player.Update(map);
                enemy.Update(map);             
            }

            Console.ReadKey(true);

        }
    }
}
