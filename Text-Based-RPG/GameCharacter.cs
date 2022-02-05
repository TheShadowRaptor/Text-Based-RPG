using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    // Declerations    

    class GameCharacter
    {
        // Initialisation
        int health;
        int shield;

        Map map = new Map();

        protected void TakeDamage()
        {

        }

        protected void Collision(int x, int y)
        {
            if (map.printMap[x, y] == '^')
            {

            }
        }

    }  
}
