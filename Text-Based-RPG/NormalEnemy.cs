using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class NormalEnemy :  Enemy
    {
        // ----------------------------------- Start ---------------------------------------
        public void Start(int x, int y)
        {
            // establish enemy's world position
            enemyX = x;
            enemyY = y;

            // Health related variables
            health = 100;
            damageDelt = 15;
            isAlive = true;

            // Establish enemy speed / skip distance
            speed = 1;

            // Establish how often enemy moves
            waitTime = 0;
            waitTimeMax = 0;
        }
    }
}
