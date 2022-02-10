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
        int newPlayerX;
        int newPlayerY;

        // healing

        // lives

        // level up

        public void Start()
        {
            health = 100;
            maxHealth = 100;
        }

        public void Update(Map map)
        {
            newPlayerX = playerX;
            newPlayerY = playerY;
        
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                OnCollision(map, newPlayerX, newPlayerY -= 1);
                if (canMove)
                {
                    playerY -= 1;
                }
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                OnCollision(map, newPlayerX, newPlayerY += 1);
                if (canMove)
                {
                    playerY += 1; // actual move   
                }
            }
            else if (keyPress == ConsoleKey.D)
            {
                OnCollision(map, newPlayerX += 1, newPlayerY);
                if (canMove)
                {
                    playerX += 1;
                }
            }
            else if (keyPress == ConsoleKey.A)
            {
                OnCollision(map, newPlayerX -= 1, newPlayerY);
                if (canMove)
                {
                    playerX -= 1;
                }
            }

            if (canDamage) // combat check
            {
                
            }
        }

        public void Draw(Map map)
        {
            movementArea = new char[map.rows, map.columns];
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(movementArea[playerY, playerX] = '@');

            Console.SetCursorPosition(2, 27);
            Console.WriteLine(playerX + "," + playerY);
        }
    }
}
