using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameObject
    {
        protected int objectX;
        protected int objectY;

        protected int objectType;

        protected char itemIcon;

        protected bool isPickedUp;

        void Start(int x, int y)
        {
            x = objectX;
            y = objectY;
        }

        void Draw(char icon)
        {
            Console.SetCursorPosition(objectX, objectY);
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (isPickedUp) Console.Write(itemIcon);
            if (!isPickedUp)
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
