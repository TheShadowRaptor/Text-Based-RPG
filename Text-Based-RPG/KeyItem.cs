using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class KeyItem : GameObject
    {
        public void Start(int keyX, int keyY)
        {
            objectX = keyX;
            objectY = keyY;
        }

        public void Update(Player player)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                isDoorOpen = true;
            }
        }
    }
}
