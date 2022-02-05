using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter
    {
        int EnemyX = 20;
        int EnemyY = 20;

        int direction;

        Map map = new Map();

        public void Update()
        {
            RandomSelect();
            if (direction == 1)
            {
                EnemyY -= 1;
            }
            else if (direction == 2)
            {
                EnemyY += 1;
            }
            else if (direction == 3)
            {
                EnemyX -= 1;
            }
            else if (direction == 4)
            {
                EnemyX += 1;
            }

            Console.SetCursorPosition(5, 27);
            Console.WriteLine(EnemyX + "," + EnemyY);
        }

        public void Draw()
        {
            char[,] movementZone = new char[map.rows, map.columns];
            Console.SetCursorPosition(EnemyX, EnemyY);
            Console.Write(movementZone[EnemyX, EnemyY] = 'E');
        }

        private void RandomSelect()
        {
            Random random = new Random();
            direction = random.Next(1, 5);
        }
    }
}
