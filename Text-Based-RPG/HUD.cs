 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {
        // use a string variable for health and whatnot
        // set enemy function

        public void Draw(Player player, EnemyManager enemyManager) // TEMP
        {
            PlayerHUD(player);
            EnemyHUD(player, enemyManager);
        }

        public void Update()
        {

        }

        void PlayerHUD(Player player)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(player.playerX + 25, player.playerY - 10);
            Console.WriteLine("Player Stats:");
            Console.SetCursorPosition(player.playerX + 25, player.playerY - 9);
            Console.WriteLine("Position: " + player.playerX + "," + player.playerY);
            Console.SetCursorPosition(player.playerX + 25, player.playerY - 8);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth);
        }

        void EnemyHUD(Player player, EnemyManager enemyManager)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(player.playerX + 25, player.playerY - 7);
            Console.WriteLine("Enemy Stats:");
            Console.SetCursorPosition(player.playerX + 25, player.playerY - 6);
            

            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                if (player.newPlayerX == enemyManager.weakEnemies[i].enemyX && player.newPlayerY == enemyManager.weakEnemies[i].enemyY)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.weakEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                if (player.newPlayerX == enemyManager.normalEnemies[i].enemyX && player.newPlayerY == enemyManager.normalEnemies[i].enemyY)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.normalEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                if (player.newPlayerX == enemyManager.toughEnemies[i].enemyX && player.newPlayerY == enemyManager.toughEnemies[i].enemyY)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.toughEnemies[i].health);
                }
            }

            if (player.newPlayerX == enemyManager.bossEnemy.enemyX && player.newPlayerY == enemyManager.bossEnemy.enemyY)
            {
                Console.WriteLine("Enemy's Health: " + enemyManager.bossEnemy.health);
            }
        }
    }
}
