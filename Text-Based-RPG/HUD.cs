 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {

        public void Draw(Player player, WeakEnemy weakEnemy) // TEMP
        {
            PlayerHUD(player);
            EnemyHUD(weakEnemy, player);
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

        void EnemyHUD(WeakEnemy weakEnemy, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(65, 4);
            Console.WriteLine("Enemy Stats:");
            Console.SetCursorPosition(65, 6);
            if (player.playerX < weakEnemy.enemyX + 5 && player.playerX > weakEnemy.enemyX - 5
                && player.playerY < weakEnemy.enemyX + 5 && player.playerY > weakEnemy.enemyY - 5)
            {
                Console.WriteLine("Health: " + weakEnemy.health);
            }
        }
    }
}
