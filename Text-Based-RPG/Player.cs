using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Text_Based_RPG
{
    class Player : GameCharacter
    {
        public float health;
        public float maxHealth;

        public float damageDelt = 25;

        public int playerY;
        public int playerX;
        public int newPlayerX;
        public int newPlayerY;

        public int xOffset = 25;
        public int yOffset = 10;

        public ConsoleKey keyPressed;

        public Player()
        {

        }

        public void Start()
        {
            playerX = 40;
            playerY = 20;
            isAlive = true;

            health = 100;
            health = 100;
            maxHealth = 100;
        }
        // while console.keyavailable console.reakey(true)
        // ---------------------------------- Update ----------------------------------
        public void Update(Map map, EnemyManager enemyManager, ItemManager itemManager, Shop shop, Inventory inventory, GameObject gameObject)
        {
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            keyPressed = keyPress;
            newPlayerX = playerX;
            newPlayerY = playerY;
            canAttack = false;

            // ----------------------- WASD --------------------------

            if (keyPress == ConsoleKey.W)
            {
                newPlayerY -= 1;
            }
            else if (keyPress == ConsoleKey.S) // decision to move
            {
                newPlayerY += 1;
            }
            else if (keyPress == ConsoleKey.D)
            {
                newPlayerX += 1;
            }
            else if (keyPress == ConsoleKey.A)
            {
                newPlayerX -= 1;
            }   
            
            // ---------------------- Inventory ---------------------

            else if (keyPress == ConsoleKey.I)
            {
                inventory.ShowInventory();
            }

            OnCollision(map, newPlayerX, newPlayerY, this, shop, itemManager);
            if (canMove)
            {
                DetectEnemyCollision(enemyManager);
                DetectShopCollision(shop, enemyManager, inventory);
                DoorCollision(itemManager);
            }

            if (canMove)
            {
                playerX = newPlayerX;
                playerY = newPlayerY;
            }
        }

        void DetectEnemyCollision(EnemyManager enemyManager)
        {          
            // player collision
            for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
            {
                enemyManager.weakEnemies[i].isHit = false;
                if (newPlayerX == enemyManager.weakEnemies[i].enemyX && newPlayerY == enemyManager.weakEnemies[i].enemyY)
                {
                    canAttack = true;
                    canMove = false;
                    enemyManager.weakEnemies[i].isHit = true;
                    Console.Beep(1000, 500);
                    enemyManager.weakEnemies[i].health = DealDamage(damageDelt, enemyManager.weakEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
            {
                enemyManager.normalEnemies[i].isHit = false;
                if (newPlayerX == enemyManager.normalEnemies[i].enemyX && newPlayerY == enemyManager.normalEnemies[i].enemyY)
                {
                    enemyManager.normalEnemies[i].isHit = true;
                    canAttack = true;
                    canMove = false;                  
                    Console.Beep(1000, 500);
                    enemyManager.normalEnemies[i].health = DealDamage(damageDelt, enemyManager.normalEnemies[i].health);
                }
            }

            for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
            {
                enemyManager.toughEnemies[i].isHit = false;
                if (newPlayerX == enemyManager.toughEnemies[i].enemyX && newPlayerY == enemyManager.toughEnemies[i].enemyY)
                {
                    enemyManager.toughEnemies[i].isHit = true;
                    canAttack = true;
                    canMove = false;
                    Console.Beep(1000, 500);
                    enemyManager.toughEnemies[i].health = DealDamage(damageDelt, enemyManager.toughEnemies[i].health);
                }
            }

            enemyManager.bossEnemy.isHit = false;
            if (newPlayerX == enemyManager.bossEnemy.enemyX && newPlayerY == enemyManager.bossEnemy.enemyY)
            {
                enemyManager.bossEnemy.isHit = true;
                canAttack = true;
                canMove = false;
                Console.Beep(1000, 500);
                enemyManager.bossEnemy.health = DealDamage(damageDelt, enemyManager.bossEnemy.health);
            }

            if (health <= 0)
            {
                isAlive = false;
            }
        }

        void DetectShopCollision(Shop shop, EnemyManager enemyManager, Inventory inventory)
        {
            if (newPlayerX == shop.x && newPlayerY == shop.y)
            {
                shop.Update(enemyManager, this, damageDelt, inventory);
                canMove = false;
            }
        }

        void DoorCollision(ItemManager itemManager)
        {
            if (newPlayerX == itemManager.door.objectX && newPlayerY == itemManager.door.objectY)
            {
                Console.Beep();
                canMove = false;
            }          
        }

        // -------------------------------- Draw -------------------------------
        public void Draw(Render render, Camera camera)
        {
            render.Draw(playerX, playerY, '@', ConsoleColor.Magenta, camera);
        }
    }
}
