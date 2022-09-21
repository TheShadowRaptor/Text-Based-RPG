using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class SteelSword : GameObject
    {
        private float swordDamage = 50;
        public SteelSword()
        {
            name = "SteelSword";
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
