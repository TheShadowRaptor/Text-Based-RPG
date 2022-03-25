using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    class Program
    {        
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();         

            gameManager.GameLoop();

            Console.ReadKey(true);
        }
    }
}
