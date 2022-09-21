using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Render
    {   
        public void Start()
        {
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;
            Console.WindowHeight = 14;
            Console.WindowWidth = 32;
        }

        public void Draw(int x, int y, char character, ConsoleColor color, Camera camera)
        {
            Console.SetCursorPosition(0, 0);

            int screenX = x - camera.cameraX;
            int screenY = y - camera.cameraY;

            // Ceneter Camera
            screenX += Console.WindowWidth / 2;
            screenY += Console.WindowHeight / 2;

            // range check
            if (screenX < 0 || screenY < 0) return;
            if (screenX > Console.WindowWidth || screenY > Console.WindowHeight) return;


            Console.SetCursorPosition(screenX, screenY);
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ResetColor();
        }
    }
}
