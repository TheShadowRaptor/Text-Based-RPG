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
        public void Update(Player player, EnemyManager enemyManager)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                Use(player);
            }
        }

        public void Use(Player player)
        {
            player.damageDelt =+ swordDamage;
        }
    }
}
