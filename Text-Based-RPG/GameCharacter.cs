using System;

namespace Text_Based_RPG
{
    // Declerations    

    class GameCharacter
    {
        // Initialisation
        protected int randNum;
        protected bool canMove;
        protected bool canDamage;

        protected int health;
        protected int maxHealth;

        protected char[,] movementArea;

        protected void TakeDamage(int damage, int health, int shield)
        {
            shield -= damage;

            if (shield <= 0)
            {
                health += shield;
                shield = 0;
            }                    
        }

        protected void RandomiseInt(int min, int max)
        {
            Random random = new Random();
            randNum = random.Next(min, max);
        }

        protected void OnCollision(Map map, int x, int y)
        {
            Player player = new Player(); // this feels gross, but it'll do for now.
            Enemy enemy = new Enemy();

            if (x < 0 || y < 0)
            {
                canMove = false;
                canDamage = false;
            }
            else if (x > map.columns - 1 || y > map.rows - 1)
            {
                canMove = false;
                canDamage = false;
            }
            else if (map.printMap[y, x] == '^')
            {
                canMove = false;
                canDamage = false;
            }
            else if (map.printMap[y, x] == '~')
            {
                canMove = false;
                canDamage = false;
            }
            else if (player.movementArea[y, x] == 'E' || enemy.movementArea[y, x] == '@') // doesn't work / null refrence
            {
                canMove = false;
                canDamage = true;
            }
            else
            {
                canMove = true;
                canDamage = false;
            }

            checkDamage();
        }

        private void checkDamage()
        {
            if (canDamage)
            {

            }
            else
            {
                return;
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
