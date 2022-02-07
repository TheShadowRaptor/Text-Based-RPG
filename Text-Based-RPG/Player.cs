using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Text_Based_RPG
{
    class Player : GameCharacter
    {
        // inherites from GameCharacter
        public bool isAlive = true;
        int EXP;
        int lives;

        int playerY = 1;
        int playerX = 1;

        // healing

        // lives

        // level up

        public void Update()
        {    
            ConsoleKey keyPress = Console.ReadKey(true).Key;

                // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                    playerY -= 1;                      
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                    playerY += 1; // actual move                          
            }
            else if (keyPress == ConsoleKey.D)
            {
                    playerX += 1;                            
            }
            else if (keyPress == ConsoleKey.A)
            {
                    playerX -= 1;                      
            }

            // combat check?
        }

        public void Draw(Map map)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(playerX, playerY);            
            Console.Write(map.printMap[playerY + 1, playerX + 1] = '@');
        }
    }
}
