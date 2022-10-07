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

        public void Draw(Player player, EnemyManager enemyManager, Inventory inventory) // TEMP
        {
            Console.SetCursorPosition(0, 20);
            PlayerHUD(player, inventory);
            EnemyHUD(player, enemyManager);
        }

        public void Update()
        {

        }

        void PlayerHUD(Player player, Inventory inventory)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Player Stats:");
            Console.Write("Position: " + player.playerX + "," + player.playerY);         
            Console.WriteLine(" Health: " + player.health + "/" + player.maxHealth);
            Console.Write("Damage: " + player.damageDelt);
            Console.WriteLine(" Souls: " + inventory.currentCurrency);    
        }

        void EnemyHUD(Player player, EnemyManager enemyManager)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enemy Stats:");
            

            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                if (enemyManager.weakEnemies[i].isHit)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.weakEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                if (enemyManager.normalEnemies[i].isHit)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.normalEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                if (enemyManager.toughEnemies[i].isHit)
                {
                    Console.WriteLine("Enemy's Health: " + enemyManager.toughEnemies[i].health);
                }
            }

            if (enemyManager.bossEnemy.isHit)
            {
                Console.WriteLine("Enemy's Health: " + enemyManager.bossEnemy.health);
            }
        }
    }
}
