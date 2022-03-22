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
        public bool playerIsAlive;

        public int playerY;
        public int playerX;
        public int newPlayerX;
        public int newPlayerY;

        public void Start()
        {
            playerX = 1;
            playerY = 1;
            isAlive = true;

            health = 100;
            maxHealth = 100;
        }

        // ---------------------------------- Update ----------------------------------
        public void Update(Map map, WeakEnemy weakEnemy, Door door, NormalEnemy normalEnemy, ToughEnemy toughEnemy)
        {             
            newPlayerX = playerX;
            newPlayerY = playerY;
            canAttack = false;

            ConsoleKey keyPress = Console.ReadKey(true).Key;

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

            OnCollision(map, newPlayerX, newPlayerY, this, weakEnemy, door);
            if (canMove) DetectEnemyCollision(weakEnemy, normalEnemy, toughEnemy);
            if (canMove)
            {
                playerX = newPlayerX;
                playerY = newPlayerY;
            }
        }

        void DetectEnemyCollision(WeakEnemy weakEnemy, NormalEnemy normalEnemy, ToughEnemy toughEnemy)
        {
            // player collision
            if (newPlayerX == weakEnemy.enemyX && newPlayerY == weakEnemy.enemyY)
            {
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                weakEnemy.health = DealDamage(damageDelt, weakEnemy.health);
            }
            else if (newPlayerX == normalEnemy.enemyX && newPlayerY == normalEnemy.enemyY)
            {
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                normalEnemy.health = DealDamage(damageDelt, normalEnemy.health);
            }
            else if (newPlayerX == weakEnemy.enemyX && newPlayerY == weakEnemy.enemyY)
            {
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                toughEnemy.health = DealDamage(damageDelt, toughEnemy.health);
            }
            else canMove = true;

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
            Console.SetCursorPosition(0, 0);
        }
    }
}
