using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter
    {
        int EnemyX = 15;
        int EnemyY = 15;

        public void Update()
        {
            // temp random movement? || non-agro state?
            RandomInt(1, 5);
            if (randNum == 1)
            {
                EnemyY -= 1;
            }
            else if (randNum == 2)
            {
                EnemyY += 1;
            }
            else if (randNum == 3)
            {
                EnemyX -= 1;
            }
            else if (randNum == 4)
            {
                EnemyX += 1;
            }

            // combat check?
        }

        public void Draw(Map map)
        {
            Console.SetCursorPosition(EnemyX, EnemyY);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(map.printMap[EnemyY + 1, EnemyX + 1] = 'E');
        }
    }
}
