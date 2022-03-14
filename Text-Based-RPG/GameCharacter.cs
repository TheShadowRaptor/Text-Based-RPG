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

        // meathod that is called on enemy-player collision
        protected int DealDamage(int damage, int health)
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
            Random random = new Random();
            randNum = random.Next(1, 5);
        }

        protected void MoveCharacter(int newX, int newY, int X, int Y)
        {
            X = newX;
            Y = newY;
        }

        // collision that all game characters adbide by
        protected void OnCollision(Map map, int x, int y, Player player, Enemy enemy, Door door)
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
            else if (player.newPlayerX == door.objectX && player.newPlayerY == door.objectY) // player-door collison
            {
                canMove = false;
                Console.Beep();
            }
            else if (enemy.newEnemyX == door.objectX && player.newPlayerY == door.objectY) // enemy-door collision
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
