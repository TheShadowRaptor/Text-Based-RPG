using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Door : GameObject
    {       
        protected bool isDoorOpen = false;

        public void Update(Player player, Inventory inventory)
        {
            // check if player is on Item
            if (player.newPlayerX == objectX && player.newPlayerY == objectY)
            {
                int currentNumber = 0;
                foreach (GameObject item in inventory.space)
                {                                       
                    if (item.name == "Key")
                    {
                        isPickedUp = true;
                        inventory.RemoveItem(inventory.space[currentNumber]);
                        Console.Beep(50, 50);
                        break;
                    }
                    else Console.Beep();
                    currentNumber += 1;
                }                             
            }
        }       
    }
}
