using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameObject
    {
        public int objectX;
        public int objectY;

        public string name;

        protected int countDownTimer;

        public bool isPickedUp = false;
        protected bool isDoorOpen = false;

        public void Start(int x, int y)
        {
            countDownTimer = 0;
            objectX = x;
            objectY = y;
        }

        public void Draw(char itemIcon, Render render, Camera camera)
        {
            if (!isPickedUp) render.Draw(objectX, objectY, itemIcon, ConsoleColor.Cyan, camera);
            //Console.SetCursorPosition(objectX, objectY);
            //if (!isPickedUp) Console.Write(itemIcon);
            if (isPickedUp)
            {
                objectX = 2;
                objectY = 4;
            }
        }
    }
}
