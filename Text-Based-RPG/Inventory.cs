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
            Console.WriteLine("------Inventory------");
            if (space == null) Console.WriteLine("You have no items bro...");
            else
            {
                foreach (GameObject item in space)
                {
                    Console.WriteLine(item.name);
                }
            }
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
