using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter // add enemy array for multiple enemies
    {
        public float health;
        public float damageDelt;

        public int speed;
        protected int waitTime;
        protected int waitTimeMax;

        public int enemyX;
        public int enemyY;
        public int newEnemyX;
        public int newEnemyY;

        public bool isTimeStopped;
        public bool isHit;


        // ---------------------------------------- Update --------------------------------
        public void Update(Map map, Player player, Shop shop, ItemManager itemManager, EnemyManager enemyManager, Npc npc)
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
                Movement(this);

                OnCollision(map, newEnemyX, newEnemyY, player, shop, itemManager);
                DetectDoorCollision(itemManager, enemyManager);
                DetectNpcCollision(npc, itemManager, enemyManager);
                if (canMove) DetectPlayerChar(player);
                if (canMove)
                {
                    enemyX = newEnemyX;
                    enemyY = newEnemyY;
                }
            }
        }
        // ------------------------- protected methods -------------------------------
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

        protected void DetectNpcCollision(Npc npc, ItemManager itemManager, EnemyManager enemyManager)
        {
            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                if (enemyManager.weakEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.weakEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                if (enemyManager.normalEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.normalEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                if (enemyManager.toughEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.toughEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
        }

        protected void DetectDoorCollision(ItemManager itemManager, EnemyManager enemyManager)
        {
            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                if (enemyManager.weakEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.weakEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                if (enemyManager.normalEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.normalEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                if (enemyManager.toughEnemies[i].newEnemyX == itemManager.door.objectX && enemyManager.toughEnemies[i].newEnemyY == itemManager.door.objectY) // enemy-door collision
                {
                    canMove = false;
                }
            }
        }

        // ------------------------- Draw --------------------------------------
        public void Draw(char icon, Render render, Camera camera)
        {
            if (isAlive) render.Draw(enemyX, enemyY, icon, ConsoleColor.DarkRed, camera);
            if (!isAlive)
            {
                enemyX = 2;
                enemyY = 4;
            }
        }
    }
}
