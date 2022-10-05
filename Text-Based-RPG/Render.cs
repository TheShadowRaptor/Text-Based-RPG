using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Render
    {
        int screenX;
        int screenY;

        public Camera camera;

        public Render(Camera camera)
        {
            this.camera = camera;
        }

        public void Draw(int x, int y, char character, ConsoleColor color, Camera camera)
        {
            int posX = x - camera.offSetY;
            int posY = y - camera.offSetX;

            if (posX < screenX + 2 && posX > 0 && posY < screenY + 2 && posY > 0)
            {
                Console.SetCursorPosition(posX + 1, posY + 1);
                Console.ForegroundColor = color;
                Console.Write(character);
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }
        }

        public void MapDraw(int worldX, int worldY, char character)
        {
            screenX = worldX;
            screenY = worldY;

            Console.SetCursorPosition(screenX + 1, screenY + 1);
            Console.Write(character);
        }
    }
}
