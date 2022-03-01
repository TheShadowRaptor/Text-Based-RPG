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
            PlayerHUD(player);

        }

        void Update()
        {

        }

        void PlayerHUD(Player player)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Player Stats:");
            Console.SetCursorPosition(65, 1);
            Console.WriteLine("Position: " + player.playerX + "," + player.playerY);
            Console.SetCursorPosition(65, 2);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth);
        }
    }
}
