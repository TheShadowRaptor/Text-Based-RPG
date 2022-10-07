using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class KeyItem : GameObject
    {
        public KeyItem()
        {
            name = "Key";
        }

        public void Update(Player player, Inventory inventory)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                inventory.AddItem(this);
                isPickedUp = true;                   
            }          
        }

        //11,22
    }
}
