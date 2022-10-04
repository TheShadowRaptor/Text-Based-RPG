using System;

namespace Text_Based_RPG
{
    // Declerations    

    class GameCharacter
    {
        // Initialisation
        protected int randNum;

        public bool canMove;
        protected bool canAttack;
        protected bool dealDmg;

        public bool isAlive;

        public static Random random = new Random();

        // meathod that is called on enemy-player collision
        protected float DealDamage(float damage, float health)
        {
            health -= damage;  

            if (health <= 0)
            {
                health = 0;
            }

            return health;
        }

        // generates random int
        protected void RandomiseInt(int min, int max)
        {          
            randNum = random.Next(min, max);
        }

        protected void Movement(Enemy enemy)
        {
            RandomiseInt(1, 5);
            if (randNum == 1)
            {
                enemy.newEnemyY -= enemy.speed;
            }
            else if (randNum == 2)
            {
                enemy.newEnemyY += enemy.speed;
            }
            else if (randNum == 3)
            {
                enemy.newEnemyX -= enemy.speed;
            }
            else if (randNum == 4)
            {
                enemy.newEnemyX += enemy.speed;
            }
        }

        // collision that all game characters adbide by
        protected void OnCollision(Map map, int x, int y, Player player, Shop shop, ItemManager itemManager)
        {
            dealDmg = false;

            if (x < 0 || y < 0)
            {
                canMove = false;
            }
            else if (x > map.columns - 1 || y > map.rows - 1)
            {
                canMove = false;
            }
            else if (map.collisionMap[y][x] == '^')
            {
                canMove = false;
            }
            else if (map.collisionMap[y][x] == '~')
            {
                canMove = false;
            }
            else if (map.collisionMap[y][x] == '=')
            {
                canMove = false;
            }
            else
            {
                canMove = true;
            }
        }

        protected int Clamp(int value, int min, int max) // important for Health and whatnot
        {
            if (value > max)
            {
                value = max;
            }
            if (value < min)
            {
                value = min;
            }

            return value;
        }       

    }  
}
