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

            // Gameplay Loop
            // while loop

            map.DrawMap();

            Console.ReadKey(true);

        }
    }
}
