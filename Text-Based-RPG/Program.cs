﻿using System;
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

            player.Start();

            // Gameplay Loop
            while (player.isAlive)
            {
                hud.Draw();
                map.Draw();               
                enemy.Draw(map);
                player.Draw(map);

                map.Update();                
                enemy.Update(map);
                player.Update(map);
            }

            Console.ReadKey(true);

        }
    }
}
