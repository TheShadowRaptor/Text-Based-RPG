 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {
        public void Draw(Player player, WeakEnemy weakEnemy, NormalEnemy normalEnemy, ToughEnemy toughEnemy) // TEMP
        {
            PlayerHUD(player);
            EnemyHUD(weakEnemy, player, normalEnemy, toughEnemy);
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

        void EnemyHUD(WeakEnemy weakEnemy, Player player, NormalEnemy normalEnemy, ToughEnemy toughEnemy)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(65, 4);
            Console.WriteLine("Enemy Stats:");
            Console.SetCursorPosition(65, 6);
            if (player.newPlayerX == weakEnemy.enemyX && player.newPlayerY == weakEnemy.enemyY)
            {
                Console.WriteLine("Health: " + weakEnemy.health);
            }
            else if (player.newPlayerX == normalEnemy.enemyX && player.newPlayerY == normalEnemy.enemyY)
            {
                Console.WriteLine("Health: " + normalEnemy.health);
            }
            else if (player.newPlayerX == toughEnemy.enemyX && player.newPlayerY == toughEnemy.enemyY)
            {
                Console.WriteLine("Health: " + toughEnemy.health);
            }
            else Console.WriteLine(" ");
        }
    }
}
