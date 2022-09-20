using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Shop
    {
        private char shopChar = 'S';

        public float x;
        public float y;

        public GameObject item1;
        public GameObject item2;
        public GameObject item3;
        public GameObject item4;

        public void Start()
        {
            x = 22;
            y = 30;

            item1 = new PowerUp();
            item2 = new IronSword();
            item3 = new SteelSword();
            
        }
        public void Update()
        {
            
        }

        private void ShowShop()
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("= [1] " + item1 + " $2 = = [2] " + item2 + " 10$ = = [3] + " + item3 + " 10$ = =");
            Console.WriteLine("= [4] Exit                                                        =");
            Console.WriteLine("===================================================================");
        }

        private void Decision()
        {
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            if (keyPress == ConsoleKey.D1)
            {
                
            }

            if (keyPress == ConsoleKey.D2)
            {

            }

            if (keyPress == ConsoleKey.D3)
            {

            }

            if (keyPress == ConsoleKey.D4)
            {

            }
        }
    }
}
