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
        // inherites from GameCharacter
        int EXP;
        int lives;

        public int health;
        public int maxHealth;
        int damageDelt = 50;
        public bool playerIsAlive;

        public int playerY;
        public int playerX;
        public int newPlayerX;
        public int newPlayerY;

        // healing

        // lives

        // level up

        public void Start()
        {
            playerX = 1;
            playerY = 1;
            isAlive = true;

            health = 100;
            maxHealth = 100;
        }

        // ---------------------------------- Update ----------------------------------
        public void Update(Map map, Enemy enemy)
        {             
            newPlayerX = playerX;
            newPlayerY = playerY;
            canAttack = false;

            ConsoleKey keyPress = Console.ReadKey(true).Key;

            // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                newPlayerY -= 1;
                OnCollision(map, newPlayerX, newPlayerY); // check if future space can be moved into

                if (canMove) EnemyCollision(enemy);
                if (canMove) playerY -= 1;
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                newPlayerY += 1;
                OnCollision(map, newPlayerX, newPlayerY);

                if (canMove) EnemyCollision(enemy);
                if (canMove) playerY += 1;
            }
            else if (keyPress == ConsoleKey.D)
            {
                newPlayerX += 1;
                OnCollision(map, newPlayerX, newPlayerY);

                if (canMove) EnemyCollision(enemy);
                if (canMove) playerX += 1;
            }
            else if (keyPress == ConsoleKey.A)
            {
                newPlayerX -= 1;
                OnCollision(map, newPlayerX, newPlayerY);

                if (canMove) EnemyCollision(enemy);
                if (canMove) playerX -= 1;
            }
        }

        void EnemyCollision(Enemy enemy)
        {
            // player collision
            if (newPlayerX == enemy.enemyX && newPlayerY == enemy.enemyY)
            {
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                enemy.health = DealDamage(damageDelt, enemy.health);
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
