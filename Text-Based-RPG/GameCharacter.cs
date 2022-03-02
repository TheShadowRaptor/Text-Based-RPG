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

      //  Enemy enemy = new Enemy();    // causes a stack-overflow... why?
      //  Player player = new Player();

        protected int DealDamage(int damage, int health)
        {
            health -= damage;  

            if (health <= 0)
            {
                health = 0;
            }

            return health;
        }

        protected void RandomiseInt(int min, int max)
        {
            Random random = new Random();
            randNum = random.Next(min, max);
        }

        protected void Movement(int x, int y, int state)
        {
            switch (state)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                default:

                    break;
            }
        }

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
            else if (player.newPlayerX == door.objectX && player.newPlayerY == door.objectY)
            {
                canMove = false;
                Console.Beep();
            }
            else if (enemy.newEnemyX == door.objectX && player.newPlayerY == door.objectY)
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
