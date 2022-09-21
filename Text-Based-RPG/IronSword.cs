using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class IronSword : GameObject
    {
        private float swordDamage = 25;

        public IronSword()
        {
            name = "IronSword";
        }
        public void Update(Player player, EnemyManager enemyManager, float damageDelt)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                Use(damageDelt);
            }
        }

        public void Use(float damageDelt)
        {
            damageDelt =+ swordDamage;
        }
    }
}
