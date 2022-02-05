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
        public bool isAlive = true;
        int EXP;
        int lives;

        int playerY;
        int playerX;
        

        Map map = new Map();

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
                    playerY -= 1;                                  

                    break;

                case ConsoleKey.S:
                    playerY += 1;

                    break;

                case ConsoleKey.D:
                    playerX += 1;                        

                    break;

                case ConsoleKey.A:
                    playerX -= 1;

                    break;

                default:

                    break;
            }

            Console.SetCursorPosition(0, 27);
            Console.WriteLine(playerX + "," + playerY);
            Console.WriteLine(map.rows + "," + map.columns);
        }

        public void Draw()
        {
            char[,] movementZone = new char[map.rows, map.columns];
            Console.SetCursorPosition(playerX, playerY);  
            Console.Write(movementZone[playerY, playerX] = '@');
        }
    }
}
