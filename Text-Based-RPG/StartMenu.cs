using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class StartMenu
    {
        bool startGame = false;

        public void StartGame()
        {
            Console.CursorVisible = false;
            while(startGame == false)
            {
                Title();
                Console.WriteLine("Press Enter to start the Game");

                ConsoleKey keyPress = Console.ReadKey(true).Key;

                switch (keyPress)
                {
                    case ConsoleKey.Enter:

                        startGame = true;
                        break;

                    default:

                        Console.WriteLine(keyPress + " Is not recognised, press any key to select again");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                }
            }
            Console.Clear();
            LoreDump();
        }

        public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ____            _                    __  __        __         ");
            Console.WriteLine(" |  _ \\ ___  __ _| |_ __ ___     ___  / _| \\ \\      / /_ _ _ __ ");
            Console.WriteLine(" | |_) / _ \\/ _` | | '_ ` _ \\   / _ \\| |_   \\ \\ /\\ / / _` | '__|");
            Console.WriteLine(" |  _ <  __/ (_| | | | | | | | | (_) |  _|   \\ V  V / (_| | |   ");
            Console.WriteLine(" |_| \\_\\___|\\__,_|_|_| |_| |_|  \\___/|_|      \\_/\\_/ \\__,_|_|   ");
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void LoreDump()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Year is 1357...");
            Console.WriteLine(" ");
            Console.WriteLine("An ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Evil Tyrant ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("known simply as ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The Big Bad Evil Guy ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("has Sealed himself into the mountain, only a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("key");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" hidden in a dungeon to the South can open the gate, are you a bad enough dude to kill the " +
                "Big Bad Evil Guy?");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Start");

            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
