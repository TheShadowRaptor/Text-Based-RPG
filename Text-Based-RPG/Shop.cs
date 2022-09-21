using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Shop
    {
        private char shopIcon = 'S';

        public int x;
        public int y;

        public PowerUp item1;
        public IronSword item2;
        public SteelSword item3;

        public ConsoleColor shopColor = ConsoleColor.Yellow;

        public void Start()
        {
            x = 22;
            y = 29;

            item1 = new PowerUp();
            item2 = new IronSword();
            item3 = new SteelSword();
            
        }

        public void Update(EnemyManager enemyManager, float damageDelt)
        {
            ShowShop(enemyManager, damageDelt);
        }

        public void Draw(Render render, Camera camera)
        {
            render.Draw(x, y, shopIcon, shopColor, camera);
        }

        public void ShowShop(EnemyManager enemyManager, float damageDelt)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("========- Shop -=======");
            Console.WriteLine("=======================");
            Console.WriteLine(" = [1] " + item1.name + " $2  ");
            Console.WriteLine(" = [2] " + item2.name + " 10$ ");
            Console.WriteLine(" = [3] " + item3.name + " 25$ ");
            Console.WriteLine(" = [4] Exit ");
            Console.WriteLine("=======================");
            Decision(enemyManager, damageDelt);
        }

        private void Decision(EnemyManager enemyManager, float damageDelt)
        {
            bool inShop = true; 

            while (inShop)
            {
                ConsoleKey keyPress = Console.ReadKey(true).Key;

                if (keyPress == ConsoleKey.D1)
                {
                    item1.Use(enemyManager);
                }

                if (keyPress == ConsoleKey.D2)
                {
                    item2.Use(damageDelt);
                }

                if (keyPress == ConsoleKey.D3)
                {
                    item3.Use(damageDelt);

                }

                if (keyPress == ConsoleKey.D4)
                {
                    inShop = false;
                    break;
                }
            }         
        }
    }
}
