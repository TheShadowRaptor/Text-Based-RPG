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

        public void Update(Player player)
        {
            // check if player is on Item
            if (player.playerX == objectX && player.playerY == objectY)
            {
                Console.Beep(); // add pickup Beep               
            }
        }       
    }
}
