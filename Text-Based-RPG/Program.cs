using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Program
    {
        // Declerations
       

        static void Main(string[] args)
        {
            // Initialisation

            Map map = new Map();
            Player player = new Player();

            // Gameplay Loop
            while (player.isAlive)
            {
                map.Draw();
                player.Draw();
                // enemy.Draw();

               // map.Update();
                player.Update();
                // enemy.Update();
            }



            Console.ReadKey(true);

        }
    }
}
