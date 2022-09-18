﻿using System;

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
            randNum = random.Next(min, max);
        }

        protected void EnemyMovement(Enemy enemy)
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
        protected void OnCollision(Map map, int x, int y, Player player, Door door)
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
            else if (player.newPlayerX == door.objectX && player.newPlayerY == door.objectY) // player-door collison
            {
                canMove = false;
                Console.Beep();
            }
            else
            {
                canMove = true;
            }
        }

        protected void ReDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('.');
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
