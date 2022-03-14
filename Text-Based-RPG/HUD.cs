 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HUD
    {

        public void Draw(Player player, Enemy enemy, Enemy enemy2, Enemy enemy3, Enemy enemy4) // TEMP
        {
            PlayerHUD(player);
            //EnemyHUD(enemy, enemy2, enemy3, enemy4, player);
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

        void EnemyHUD(Enemy enemy, Enemy enemy2, Enemy enemy3, Enemy enemy4, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(65, 4);
            Console.WriteLine("Enemy Stats:");
            Console.SetCursorPosition(65, 6);
            if (player.playerX < enemy.enemyX + 5 && player.playerX > enemy.enemyX - 5
                && player.playerY < enemy.enemyX + 5 && player.playerY > enemy.enemyY - 5)
            {
                Console.WriteLine("Health: " + enemy.health);
            }
            else if (player.playerX < enemy2.enemyX + 5 && player.playerX > enemy2.enemyX - 5
                && player.playerY < enemy2.enemyX + 5 && player.playerY > enemy2.enemyY - 5)
            {
                Console.WriteLine("Health: " + enemy2.health);
            }
            else if (player.playerX < enemy3.enemyX + 5 && player.playerX > enemy3.enemyX - 5
                && player.playerY < enemy3.enemyX + 5 && player.playerY > enemy3.enemyY - 5)
            {
                Console.WriteLine("Health: " + enemy3.health);
            }
            else if (player.playerX < enemy4.enemyX + 5 && player.playerX > enemy4.enemyX - 5
                && player.playerY < enemy4.enemyX + 5 && player.playerY > enemy4.enemyY - 5)
            {
                Console.WriteLine("Health: " + enemy4.health);
            }
            else Console.WriteLine("              ");
        }
    }
}
