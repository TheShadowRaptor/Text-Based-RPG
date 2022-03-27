using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Text_Based_RPG
{
    class Player : GameCharacter
    {
        public int health;
        public int maxHealth;
        int damageDelt = 25;

        public int playerY;
        public int playerX;
        public int newPlayerX;
        public int newPlayerY;

        Screen screen = new Screen();

        public void Start()
        {
            playerX = 1;
            playerY = 1;
            isAlive = true;

            health = 100;
            maxHealth = 100;
        }

        // ---------------------------------- Update ----------------------------------
        public void Update(Map map, Door door, EnemyManager enemyManager)
        {
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            newPlayerX = playerX;
            newPlayerY = playerY;
            canAttack = false;

            // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                newPlayerY -= 1;
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                newPlayerY += 1;
            }
            else if (keyPress == ConsoleKey.D)
            {
                newPlayerX += 1;
            }
            else if (keyPress == ConsoleKey.A)
            {
                newPlayerX -= 1;
            }
           
            OnCollision(map, newPlayerX, newPlayerY, this, door);
            if (canMove) screen.MoveCamera(keyPress);
            if (canMove) DetectEnemyCollision(enemyManager);
            if (canMove)
            {
                playerX = newPlayerX;
                playerY = newPlayerY;
            }
        }

        void DetectEnemyCollision(EnemyManager enemyManager)
        {
            // player collision
            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                if (newPlayerX == enemyManager.weakEnemies[i].enemyX && newPlayerY == enemyManager.weakEnemies[i].enemyY)
                {
                    canAttack = true;
                    canMove = false;
                    Console.Beep(1000, 500);
                    enemyManager.weakEnemies[i].health = DealDamage(damageDelt, enemyManager.weakEnemies[i].health);
                }
                else canMove = true;
            }

            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                if (newPlayerX == enemyManager.normalEnemies[i].enemyX && newPlayerY == enemyManager.normalEnemies[i].enemyY)
                {
                    canAttack = true;
                    canMove = false;
                    Console.Beep(1000, 500);
                    enemyManager.normalEnemies[i].health = DealDamage(damageDelt, enemyManager.normalEnemies[i].health);
                }
                else canMove = true;
            }

            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                if (newPlayerX == enemyManager.toughEnemies[i].enemyX && newPlayerY == enemyManager.toughEnemies[i].enemyY)
                {
                    canAttack = true;
                    canMove = false;
                    Console.Beep(1000, 500);
                    enemyManager.toughEnemies[i].health = DealDamage(damageDelt, enemyManager.toughEnemies[i].health);
                }
                else canMove = true;
            }
            
            if (newPlayerX == enemyManager.bossEnemy.enemyX && newPlayerY == enemyManager.bossEnemy.enemyY)
            {
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                enemyManager.bossEnemy.health = DealDamage(damageDelt, enemyManager.bossEnemy.health);
            }

            if (health <= 0)
            {
                isAlive = false;
            }
        }

        // -------------------------------- Draw -------------------------------
        public void Draw()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write('@');
        }
    }
}
