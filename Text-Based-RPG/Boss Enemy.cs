using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Boss_Enemy : Enemy
    {
        // ----------------------------------- Start ---------------------------------------
        public void Start(int x, int y)
        {
            // establish enemy's world position
            enemyX = x;
            enemyY = y;

            // Health related variables
            health = 300;
            damageDelt = 20;
            isAlive = true;

            // Establish enemy speed / skip distance
            speed = 1;

            // Establish how often enemy moves (set 0 for every turn)
            waitTime = 0;
            waitTimeMax = 0;
        }

        public void Update(Enemy enemy, Map map, Player player, Shop shop, ItemManager itemManager , EnemyManager enemyManager, Npc npc)
        {
            enemy.Update(map, player, shop, itemManager, enemyManager, npc);
        }
    }
}
