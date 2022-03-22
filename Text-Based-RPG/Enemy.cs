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

        public int speed;
        protected int waitTime;
        protected int waitTimeMax;

        public int enemyX;
        public int enemyY;
        public int newEnemyX;
        public int newEnemyY;

        public bool isTimeStopped;


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
                EnemyMovement(this);

                OnCollision(map, newEnemyX, newEnemyY, player, this, door);
                if (canMove) DetectPlayerChar(player);
                if (canMove)
                {
                    enemyX = newEnemyX;
                    enemyY = newEnemyY;
                }
            }
        }

        protected void DetectPlayerChar(Player player)
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
