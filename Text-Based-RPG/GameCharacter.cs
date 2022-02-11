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

        public int health;
        public int maxHealth;

        protected void TakeDamage(int damage, int health)
        {
            health -= damage;              
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
            Enemy enemy = new Enemy();          
            Enemy enemy = new Enemy();          


            canDamage = false;

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
           // else if (player.newPlayerX == enemy.enemyX && player.newPlayerY == enemy.enemyY) // currently reads orgin point
           // {
           //     Console.Beep();       // having issues with this, this is the best idea I have to get this to work
           // }                         // however it only recognises it's initial values of 0, 0,
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
               Console.Beep();
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
