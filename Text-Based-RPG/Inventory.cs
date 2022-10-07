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
        public int currentSpace;

        public List<GameObject> space; 
        public Inventory()
        {
            space = new List<GameObject>(6);
        }

        public void ShowInventory()
        {           
            foreach (GameObject item in space)
            {
                if (item == null) break;
                Console.WriteLine("------Inventory------");
                Console.WriteLine(item.name);
            }
            

            ConsoleKey keyPress = Console.ReadKey(true).Key;
        }

        public void AddItem(GameObject gameObject)
        {
            space.Add(gameObject);
        }

        public void RemoveItem(GameObject gameObject)
        {
            space.Remove(space[currentSpace]);
        }
    }
}
