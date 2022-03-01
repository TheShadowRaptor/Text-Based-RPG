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

        protected int countDownTimer;

        protected int objectType;

        public bool isPickedUp = false;
        protected bool isDoorOpen = false;

        public void Start(int x, int y)
        {
            countDownTimer = 0;
            objectX = x;
            objectY = y;
        }

        public void Draw(char itemIcon)
        {
            Console.SetCursorPosition(objectX, objectY);
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (!isPickedUp) Console.Write(itemIcon);
            if (isPickedUp)
            {
                objectX = 2;
                objectY = 4;
            }
            Console.SetCursorPosition(0, 0);
        }

        // Health potion
        // greater health potion
        // key item
        // door object
    }
}
