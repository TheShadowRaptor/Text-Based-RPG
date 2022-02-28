using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class HealthPotion : GameObject
    {
        int healing = 30;

        public void Start(int x, int y)
        {
            objectX = x;
            objectY = y;
        }

        public void Update(Player player)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                player.health += healing;
                
                if (player.health > player.maxHealth)
                {
                    player.health = player.maxHealth;
                }
            }
        }
    }
}
