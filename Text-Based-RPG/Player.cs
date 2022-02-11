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
        int EXP;
        int lives;

        public int playerY;
        public int playerX;
        public int newPlayerX;
        public int newPlayerY;

        // healing

        // lives

        // level up

        public void Start()
        {
            playerX = 1;
            playerY = 1;
            isAlive = true;

            health = 100;
            maxHealth = 100;
        }

        // ---------------------------------- Update ----------------------------------
        public void Update(Map map)
        {             
            newPlayerX = playerX;
            newPlayerY = playerY;
        
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                newPlayerY -= 1;
                OnCollision(map, newPlayerX, newPlayerY); // check if future space can be moved into
                if (canMove)
                {
                    playerY -= 1;
                }
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                newPlayerY += 1;
                OnCollision(map, newPlayerX, newPlayerY);
                if (canMove)
                {
                    playerY += 1; // actual move      ----->         Matt wants this seperate
                }
            }
            else if (keyPress == ConsoleKey.D)
            {
                newPlayerX += 1;
                OnCollision(map, newPlayerX, newPlayerY);
                if (canMove)
                {
                    playerX += 1;
                }
            }
            else if (keyPress == ConsoleKey.A)
            {
                newPlayerX -= 1;
                OnCollision(map, newPlayerX, newPlayerY);
                if (canMove)
                {
                    playerX -= 1;
                }
            }

           // if (dealDmg)
           // {
           //     TakeDamage(damage, enemy.health);
           // }
        }

        // -------------------------------- Draw -------------------------------
        public void Draw()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write('@'); // might be able to write these directly to the map and use them for collision?
            Console.SetCursorPosition(0, 0);
        }
    }
}
