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

        public void Update(Inventory inventory)
        {
            inventory.currentCurrency = + 1;
        }
    }
}
