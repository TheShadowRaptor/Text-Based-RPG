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
        int newEnemyX;
        int newEnemyY;

        public void Update(Map map)
        {
            newEnemyX = EnemyX;
            newEnemyY = EnemyY;
            
            // temp random movement? || non-agro state?
            RandomiseInt(1, 5);
            if (randNum == 1)
            {
                OnCollision(map, newEnemyX, newEnemyY -= 1);
                if (canMove)
                {
                    EnemyY -= 1;
                }              
            }
            else if (randNum == 2)
            {
                OnCollision(map, newEnemyX, newEnemyY += 1);
                if (canMove)
                {
                    EnemyY += 1;
                }               
            }
            else if (randNum == 3)
            {
                OnCollision(map, newEnemyX -= 1, newEnemyY);
                if (canMove)
                {
                    EnemyX -= 1;
                }              
            }
            else if (randNum == 4)
            {
                OnCollision(map, newEnemyX += 1, newEnemyY);
                if (canMove)
                {
                    EnemyX += 1;
                }              
            }

            // combat check?
        }

        public void Draw(Map map)
        {
            char[,] movementArea = new char[map.rows, map.columns];
            Console.SetCursorPosition(EnemyX, EnemyY);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(movementArea[EnemyY, EnemyX] = 'E');
        }
    }
}
