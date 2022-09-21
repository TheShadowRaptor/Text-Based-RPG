using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Soul : GameObject
    {
        public Soul()
        {
            name = "Souls";
        }

        public void Update(Inventory inventory, Player player)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                Console.Beep(); // add pickup Beep 
                inventory.currentCurrency = inventory.currentCurrency + 1;
            }
        }
    }
}
