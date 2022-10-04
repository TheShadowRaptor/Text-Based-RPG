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

        public HealthPotion item1;
        public StrengthPotion item2;

        public ConsoleColor shopColor = ConsoleColor.Yellow;

        public void Start()
        {
            x = 22;
            y = 29;

            item1 = new HealthPotion();
            item2 = new StrengthPotion();
            
        }

        public void Update(EnemyManager enemyManager, Player player, float damageDelt, Inventory inventory)
        {
            ShowShop(enemyManager, player, damageDelt, inventory);
        }

        public void Draw(Render render, Camera camera)
        {
            render.Draw(x, y, shopIcon, shopColor, camera);
        }

        public void ShowShop(EnemyManager enemyManager, Player player, float damageDelt, Inventory inventory)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("============- Shop -===============");
            Console.WriteLine("                                   ");
            Console.WriteLine(" = [1] " + item1.name + ": " + item1.price +"$             ");
            Console.WriteLine("                                ");
            Console.WriteLine(" = [2] " + item2.name + ": " + item2.price +"$             ");
            Console.WriteLine("                                   ");    
            Console.WriteLine(" = [3] Exit                        ");
            Console.WriteLine("                                   ");                                                        
            Console.WriteLine("===================================");
            Decision(enemyManager, player, damageDelt, inventory);
        }

        private void Decision(EnemyManager enemyManager, Player player, float damageDelt, Inventory inventory)
        {
            bool inShop = true; 

            while (inShop)
            {
                ConsoleKey keyPress = Console.ReadKey(true).Key;

                if (keyPress == ConsoleKey.D1 && inventory.currentCurrency >= item1.price)
                {
                    inventory.currentCurrency -= item1.price;
                    item1.Use(player);
                    break;
                }

                if (keyPress == ConsoleKey.D2 && inventory.currentCurrency >= item2.price)
                {
                    inventory.currentCurrency -= item2.price;
                    item2.Use(player);
                    break;
                }

                if (keyPress == ConsoleKey.D3)
                {
                    inShop = false;
                    break;
                }
            }         
        }
    }
}
