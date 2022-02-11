using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter
    {
        public int enemyX;
        public int enemyY;
        public int newEnemyX;
        public int newEnemyY;

        public void Start()
        {
            enemyX = 15;
            enemyY = 15;
        }

        // ---------------------------------------- Update --------------------------------
        public void Update(Map map)
        {
            newEnemyX = enemyX;
            newEnemyY = enemyY;
            
            // temp random movement? || non-agro state?
            RandomiseInt(1, 5);
            if (randNum == 1)
            {
                newEnemyY -= 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    enemyY -= 1;
                }              
            }
            else if (randNum == 2)
            {
                newEnemyY += 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    enemyY += 1;
                }               
            }
            else if (randNum == 3)
            {
                newEnemyX -= 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    enemyX -= 1;
                }              
            }
            else if (randNum == 4)
            {
                newEnemyX += 1;
                OnCollision(map, newEnemyX, newEnemyY);
                if (canMove)
                {
                    enemyX += 1;
                }              
            }

            // if (dealDmg)
            // {
            //     TakeDamage(damage, player.health);
            // }
        }

        // ------------------------- Draw --------------------------------------
        public void Draw()
        {
            
            Console.SetCursorPosition(enemyX, enemyY);           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('E');
            Console.SetCursorPosition(0, 0);
        }
    }
}
