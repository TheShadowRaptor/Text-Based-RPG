using System;

namespace Text_Based_RPG
{
    // Declerations    

    class GameCharacter
    {
        // Initialisation
        protected int randNum;
        protected bool canMove;

        protected void TakeDamage(int damage, int health, int shield)
        {
            shield -= damage;

            if (shield <= 0)
            {
                health += shield;
                shield = 0;
            }                    
        }

        protected void RandomInt(int min, int max)
        {
            Random random = new Random();
            randNum = random.Next(min, max);
        }

        protected void DetectCollision(Map map, int x, int y)
        {    
            if (map.printMap[x,y] == '^')
            {
                canMove = false;
            }
            else if (map.printMap[x,y] == '~')
            {
                canMove = false;
            }
        }

        protected int Clamp(int value, int min, int max)
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
