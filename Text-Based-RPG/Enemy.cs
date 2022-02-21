using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter // add enemy array for multiple enemies
    {
        public int health;
        public int damageDelt = 10;

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
        public void Update(Map map, Player player)
        {
            newEnemyX = enemyX;
            newEnemyY = enemyY;
            
            // temp random movement? || non-agro state?
            RandomiseInt(1, 5);
            if (randNum == 1)
            {
                newEnemyY -= 1;
                OnCollision(map, newEnemyX, newEnemyY);               

                if (canMove) EnemyCollision(player);
                if (canMove) enemyY -= 1;
           
            }
            else if (randNum == 2)
            {
                newEnemyY += 1;
                OnCollision(map, newEnemyX, newEnemyY);

                if (canMove) EnemyCollision(player);
                if (canMove) enemyY += 1;
            }
            else if (randNum == 3)
            {
                newEnemyX -= 1;
                OnCollision(map, newEnemyX, newEnemyY);

                if (canMove) EnemyCollision(player);
                if (canMove) enemyX -= 1;
            }
            else if (randNum == 4)
            {
                newEnemyX += 1;
                OnCollision(map, newEnemyX, newEnemyY);

                if (canMove) EnemyCollision(player);
                if (canMove) enemyX += 1;
            }          
        }

        void EnemyCollision(Player player)
        {
            // collision with player
            if (newEnemyX == player.playerX && newEnemyY == player.playerY)
            {
                canMove = false;
                Console.Beep();
                player.health = DealDamage(damageDelt, player.health);
            }
            else canMove = true;
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
