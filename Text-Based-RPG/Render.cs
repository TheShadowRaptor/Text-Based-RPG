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
            Console.BufferHeight = 500;
            Console.BufferWidth = 500;
        }

        public void Draw(int x, int y, char character, ConsoleColor color, Camera camera)
        {
            int screenX = x - camera.cameraX;
            int screenY = y - camera.cameraY;

            // Ceneter Camera
            screenX += Console.WindowWidth / 2;
            screenY += Console.WindowHeight / 2;

            // range check
            if (screenX < 0) return;
            if (screenY < 0) return;
            if (screenX > Console.WindowWidth) return;
            if (screenY > Console.WindowHeight) return;

            Console.SetCursorPosition(screenX, screenY);
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ResetColor();
        }
    }
}
