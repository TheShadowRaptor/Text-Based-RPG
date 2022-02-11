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
        public int health;
        public int maxHealth;

      //  Enemy enemy = new Enemy();    // causes a stack-overflow... why?
      //  Player player = new Player();

        protected void TakeDamage(int damage, int health)
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
            Enemy enemy = new Enemy();      // doesn't work. Yes, I know why.
            Player player = new Player();   // No, I don't know how to fix it.

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
          /*  else if (map.printMap[y, x] == map.printMap[enemy.enemyY, enemy.enemyX])
            {
                canMove = false;
                Console.Beep();
                dealDmg = true;
            }
            else if (map.printMap[y,x] == map.printMap[player.playerY, player.playerX])
            {
                canMove = false;
                Console.Beep();
                dealDmg = true;
            } */
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
