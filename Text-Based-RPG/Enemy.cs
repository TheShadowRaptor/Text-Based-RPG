using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter // add enemy array for multiple enemies
    {
        public int health = 100;
        public int damageDelt = 10;

        public int enemyX;
        public int enemyY;
        public int newEnemyX;
        public int newEnemyY;

        private int enemyType; // 0 - 2, sort of like a State manager, but determins type of enemy
                               // 0 = normal "E", 1 = stationary until close "S", 2 = extra damage & health "T"
        bool isAlive;
        public bool isTimeStopped;

        public void Start(int x, int y)
        {
            isAlive = true;
            enemyX = x;
            enemyY = y;
            enemyType = 0;
        }

        // ---------------------------------------- Update --------------------------------
        public void Update(Map map, Player player, Door door)
        {
            // alive check
            if (health <= 0) isAlive = false;

            newEnemyX = enemyX;
            newEnemyY = enemyY;

            if (isAlive && !isTimeStopped)
            {
                // temp random movement? || non-agro state?
                RandomiseInt(1, 5);
                if (randNum == 1)
                {
                    newEnemyY -= 1;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyY -= 1;

                }
                else if (randNum == 2)
                {
                    newEnemyY += 1;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyY += 1;
                }
                else if (randNum == 3)
                {
                    newEnemyX -= 1;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyX -= 1;
                }
                else if (randNum == 4)
                {
                    newEnemyX += 1;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyX += 1;
                }
            }                
        }

        void PlayerCollision(Player player)
        {
            // collision with player
            if (newEnemyX == player.playerX && newEnemyY == player.playerY)
            {
                canMove = false;
                Console.Beep();
                player.health = DealDamage(damageDelt, player.health);
            }
            else canMove = true;
        }

        // ------------------------- Draw --------------------------------------
        public void Draw()
        {
            
            Console.SetCursorPosition(enemyX, enemyY);           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (isAlive) Console.Write('E');
            if (!isAlive)
            {
                enemyX = 2;
                enemyY = 4;
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
