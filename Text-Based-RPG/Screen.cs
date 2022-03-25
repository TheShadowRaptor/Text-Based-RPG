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
            // declaration
           // saveBufferWidth = Console.BufferWidth;
           // saveBufferHeight = Console.BufferHeight;
           // saveWindowHeight = Console.WindowHeight;
           // saveWindowWidth = Console.WindowWidth;

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(80, 30);
        }

        // -------------------------------- Camera ------------------------------
        public void MoveCamera(ConsoleKey keyPress)
        {
            // check inputs to move screen
            switch (keyPress)
            {
                case ConsoleKey.W:
                    if (Console.WindowTop > 0)
                    {
                        Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop - 1);
                    }
                    break;

                case ConsoleKey.S:
                    if (Console.WindowTop < (Console.BufferHeight - Console.WindowHeight))
                    {
                        Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop + 1);
                    }                     
                    break;

                case ConsoleKey.A:
                    if (Console.WindowLeft > 0) 
                    {
                        Console.SetWindowPosition(Console.WindowLeft - 1, Console.WindowTop);
                    }
                    break;  

                case ConsoleKey.D:
                    if (Console.WindowLeft < (Console.BufferWidth - Console.WindowWidth))
                    {
                        Console.SetWindowPosition(Console.WindowLeft + 1, Console.WindowTop);
                    }
                        
                    break;
            }
        }

    }
}
