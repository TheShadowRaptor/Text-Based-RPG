using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Inventory
    {
        public float currentCurrency;

        List<GameObject> inventorySpace = new List<GameObject>(6);
        public Inventory()
        {
            
        }

        public void ShowInventory()
        {
            Console.WriteLine("------Inventory------");
            Console.WriteLine(inventorySpace[0].name);

            ConsoleKey keyPress = Console.ReadKey(true).Key;
        }
    }
}
