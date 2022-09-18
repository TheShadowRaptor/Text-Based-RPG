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

        public void Update()
        {

        }

        private void ShowShop()
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("= [1] Powerups $2 = = [2] ShellArmor 10$ = = [3] SteelSword 10$ = =");
            Console.WriteLine("= [4] Exit                                                        =");
            Console.WriteLine("===================================================================");

        }
    }
}
