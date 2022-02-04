using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Player : GameCharacter
    {
        // inherites from GameCharacter
        int EXP;
        int lives;
        protected int playerX;
        protected int playerY;
        public bool isAlive = true;

        // healing

        // lives

        // level up

        // Movement

        public void Update()
        {

            ConsoleKey keyPress = Console.ReadKey(true).Key;
            switch (keyPress)
            {
                // ----------------------- WASD --------------------------
                case ConsoleKey.W:
                    playerX -= 1;
                  // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.S:
                    playerX += 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.D:
                    playerY += 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.A:
                    playerY -= 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                // ----------------- Arrow Keys -------------------------
                case ConsoleKey.UpArrow:
                    playerX -= 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.DownArrow:
                    playerX += 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.RightArrow:
                    playerY += 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.LeftArrow:
                    playerY -= 1;
                   // Console.WriteLine(playerX + "," + playerY);
                    break;

                default:

                    break;
            }
        }

        public void Draw()
        {
            char[,] movementZone = new char[Console.WindowWidth,Console.WindowHeight];
            Console.SetCursorPosition(playerY, playerX);   
            
            // access map or something

            Console.Write(movementZone[playerY, playerX] = '@');

        }

    }
}
