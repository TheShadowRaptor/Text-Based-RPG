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
        public static int saveBufferWidth;
        public static int saveBufferHeight;
        public static int saveWindowHeight;
        public static int saveWindowWidth;

        public void Start()
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(250, 90);
            Console.SetWindowSize(50, 26);
        }

        public void MoveCamera(ConsoleKey keypress)
        {
            saveBufferWidth = Console.BufferWidth;
            saveBufferHeight = Console.BufferHeight;
            saveWindowHeight = Console.WindowHeight;
            saveWindowWidth = Console.WindowWidth;

            
            switch (keypress)
            {
                case ConsoleKey.W:
                    if (Console.WindowTop > 0) Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop - 1);
                    break;

                case ConsoleKey.S:
                    if (Console.WindowTop < (Console.BufferHeight - Console.WindowHeight)) Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop + 1);
                    break;

                case ConsoleKey.A:
                    if (Console.WindowLeft > 0) Console.SetWindowPosition(Console.WindowLeft - 1, Console.WindowTop);
                    break;

                case ConsoleKey.D:
                    if (Console.WindowLeft < (Console.BufferWidth - Console.WindowWidth)) Console.SetWindowPosition(Console.WindowLeft + 1, Console.WindowTop);
                    break;
            }

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(saveBufferWidth, saveBufferHeight);
            Console.SetWindowSize(saveWindowWidth, saveWindowHeight);
            Console.SetCursorPosition(saveWindowWidth, saveWindowHeight);
        }
    }
}
