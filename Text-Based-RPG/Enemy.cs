using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter // add enemy array for multiple enemies
    {
        public int health;
        public int damageDelt;

        public int enemyX;
        public int enemyY;
        public int newEnemyX;
        public int newEnemyY;

        private int speed;
        private int waitTime;
        private int waitTimeMax;

        bool isAlive;
        public bool isTimeStopped;

        // ----------------------------------- Start ---------------------------------------
        public void Start(int x, int y, int maxHealth, int damage, int speedMod, int maxWaitTime)
        {
            // establish enemy's world position
            enemyX = x;
            enemyY = y;

            // Health related variables
            health = maxHealth;
            damageDelt = damage;
            isAlive = true;
            
            // Establish enemy speed / skip distance
            speed = speedMod;

            // Establish how often enemy moves
            waitTime = 0;
            waitTimeMax = maxWaitTime;
        }

        // ---------------------------------------- Update --------------------------------
        public void Update(Map map, Player player, Door door)
        {
            // alive check
            if (health <= 0) isAlive = false;

            // wait checks
            waitTime++;
            if (waitTime > waitTimeMax) waitTime = 0;

            newEnemyX = enemyX;
            newEnemyY = enemyY;

            if (isAlive && !isTimeStopped && waitTime == 0)
            {
                // temp random movement? || non-agro state?
                RandomiseInt(1, 5);
                if (randNum == 1)
                {
                    newEnemyY -= speed;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyY -= speed;

                }
                else if (randNum == 2)
                {
                    newEnemyY += speed;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyY += speed;
                }
                else if (randNum == 3)
                {
                    newEnemyX -= speed;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyX -= speed;
                }
                else if (randNum == 4)
                {
                    newEnemyX += speed;
                    OnCollision(map, newEnemyX, newEnemyY, player, this, door);

                    if (canMove) PlayerCollision(player);
                    if (canMove) enemyX += speed;
                }
            }
        }

        protected void PlayerCollision(Player player)
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
        public void Draw(char icon)
        {
            
            Console.SetCursorPosition(enemyX, enemyY);           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (isAlive) Console.Write(icon);
            if (!isAlive)
            {
                enemyX = 2;
                enemyY = 4;
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
