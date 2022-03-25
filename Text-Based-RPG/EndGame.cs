using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class EndGame
    {
        // ---------------------- Determine win/lose --------------------------------------
        public void GameOver(Player player, Boss_Enemy bossEnemy)
        {
            Console.Clear();
            if (player.isAlive != false)
            {
                LooseGame();
            }
            else if (bossEnemy.isAlive != false)
            {
                WinGame();
            }
        }

        // --------------------- win / loose screen -----------------------------------
        private void LooseGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                  ________                               ________                                       ");
            Console.WriteLine("                 /  _____/_____    ____   _____   ____   \\_____  \\___  __ ___________                   ");
            Console.WriteLine("______   ______ /   \\  ___\\__  \\  /    \\ /     \\_ / __ \\   /   |   \\  \\/ // __ \\_  __ \\  ______   ______");
            Console.WriteLine("/_____/  /_____/ \\    \\_\\  \\/ __ \\|   |  \\  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/ /_____/  /_____/");
            Console.WriteLine("                  \\______  (____  /___|  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|                     ");
            Console.WriteLine("                         \\/     \\/     \\/      \\/     \\/          \\/          \\/                         ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit...");
        }

        private void WinGame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("____    ____  ______    __    __     ____    __    ____  __  .__   __.     __ ");
            Console.WriteLine("\\   \\  /   / /  __  \\  |  |  |  |    \\   \\  /  \\  /   / |  | |  \\ |  |    |  |");
            Console.WriteLine(" \\   \\/   / |  |  |  | |  |  |  |     \\   \\/    \\/   /  |  | |   \\|  |    |  | ");
            Console.WriteLine("  \\_    _/  |  |  |  | |  |  |  |      \\            /   |  | |  . `  |    |  |");
            Console.WriteLine("    |  |    |  `--'  | |  `--'  |       \\    /\\    /    |  | |  |\\   |    |__|");
            Console.WriteLine("    |__|     \\______/   \\______/         \\__/  \\__/     |__| |__| \\__|    (__) ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You've defeated the Big Bad Evil Guy and saved the day!");
            Console.WriteLine("Press any key to exit.");
        }
    }
}
