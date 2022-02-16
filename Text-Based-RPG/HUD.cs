using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {
        public void Draw(Player player) // TEMP
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 0);
            Console.WriteLine("Player Stats:");
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Position: " + player.playerX + "," + player.playerY);
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth);

        }

        void Update()
        {

        }
    }
}
