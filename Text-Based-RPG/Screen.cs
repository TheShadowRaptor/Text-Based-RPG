using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    class Screen
    {
        public void Start()
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(100, 100);
            Console.SetWindowSize(80, 30);
        }

        // -------------------------------- Camera ------------------------------
        public void MoveCamera(ConsoleKey keyPress)
        {
            // check inputs to move screen
            if (keyPress == ConsoleKey.W && Console.WindowTop > 0)
            {
                Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop - 1);
            }
            else if (keyPress == ConsoleKey.S && Console.WindowTop < (Console.BufferHeight - Console.WindowHeight))
            {
                Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop + 1);
            }
            else if (keyPress == ConsoleKey.D && Console.WindowLeft < (Console.BufferWidth - Console.WindowWidth))
            {
                Console.SetWindowPosition(Console.WindowLeft + 1, Console.WindowTop);
            }
            else if (keyPress == ConsoleKey.A && Console.WindowLeft > 0)
            {
                Console.SetWindowPosition(Console.WindowLeft - 1, Console.WindowTop);
            }
        }

    }
}
