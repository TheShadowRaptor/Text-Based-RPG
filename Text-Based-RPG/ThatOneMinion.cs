using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class ThatOneMinion : Enemy
    {
        public void Start(int x, int y)
        {
            // establish enemy's world position
            enemyX = x;
            enemyY = y;

            // Health related variables
            health = 250;
            damageDelt = 40;
            isAlive = true;

            // Establish enemy speed / skip distance
            speed = 1;

            // Establish how often enemy moves
            waitTime = 0;
            waitTimeMax = 2;
        }

        public new void Update(Map map, Player player, Shop shop, ItemManager itemManager, EnemyManager enemyManager, Npc npc)
        {
            // alive check
            if (health <= 0)
            {
                isAlive = false;
                OnDeath(npc);
            }

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

        public void OnDeath(Npc npc)
        {
            npc.FinishedQuest();
        }
    }
}
