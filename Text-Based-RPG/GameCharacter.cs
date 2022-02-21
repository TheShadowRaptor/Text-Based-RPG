using System;

namespace Text_Based_RPG
{
    // Declerations    

    class GameCharacter
    {
        // Initialisation
        protected int randNum;
        protected bool canMove;
        protected bool dealDmg;

        public bool isAlive;

      //  Enemy enemy = new Enemy();    // causes a stack-overflow... why?
      //  Player player = new Player();

        protected void DealDamage(int damage, int health)
        {
            health -= damage;  

            if (health <= 0)
            {
                health = 0;
                isAlive = false;
            }
        }

        protected void RandomiseInt(int min, int max)
        {
            Random random = new Random();
            randNum = random.Next(min, max);
        }

        protected void OnCollision(Map map, int x, int y)
        {
            Enemy enemy = new Enemy();
            Player player = new Player();

            dealDmg = false;

            if (x < 0 || y < 0)
            {
                canMove = false;
            }
            else if (x > map.columns - 1 || y > map.rows - 1)
            {
                canMove = false;
            }
            else if (map.printMap[y, x] == '^')
            {
                canMove = false;
            }
            else if (map.printMap[y, x] == '~')
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
