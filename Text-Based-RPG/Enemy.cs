using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter
    {
        public int EnemyX = 15;
        public int EnemyY = 15;
        public int newEnemyX;
        public int newEnemyY;

        public void Update(Map map)
        {
            newEnemyX = EnemyX;
            newEnemyY = EnemyY;
            
            // temp random movement? || non-agro state?
            RandomiseInt(1, 5);
            if (randNum == 1)
            {
                newEnemyY -= 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    EnemyY -= 1;
                }              
            }
            else if (randNum == 2)
            {
                newEnemyY += 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    EnemyY += 1;
                }               
            }
            else if (randNum == 3)
            {
                newEnemyX -= 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    EnemyX -= 1;
                }              
            }
            else if (randNum == 4)
            {
                newEnemyX += 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    EnemyX += 1;
                }              
            }

            if (canDamage) // combat check
            {

            }           
        }

        public void Draw()
        {
            
            Console.SetCursorPosition(EnemyX, EnemyY);           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('E');
            Console.SetCursorPosition(0, 0);
        }
    }
}
