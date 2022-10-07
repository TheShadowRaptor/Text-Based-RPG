using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class ItemManager
    {
        public static Random random = new Random();
        int randNum;
        public Door door = new Door();

        HealthPotion[] healthPotion = new HealthPotion[25];
        PowerUp[] powerUp = new PowerUp[2];
        Soul[] soul = new Soul[31];
        KeyItem key = new KeyItem();
       // KeyItem[] keyItem = new KeyItem[10];
       // need to change key functionality for future use

        public void Start(QuestOne questOne)
        {           
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i] = new HealthPotion();
                if (i <= 6) healthPotion[i].Start(35 + i, 25);
                else if (i == 7) healthPotion[i].Start(48, 64);
                else if (i == 8) healthPotion[i].Start(32, 60);
                else if (i == 9) healthPotion[i].Start(34, 52);
                else if (i == 10) healthPotion[i].Start(55, 22); 
                else if (i == 11) healthPotion[i].Start(63, 22);
                else if (i >= 12) healthPotion[i].Start(60 + i, 20);
            }

            for (int i = 0; i < powerUp.Length; i++)
            {
                powerUp[i] = new PowerUp();

                if (i > 0) powerUp[i].Start(58, 20);
                else if (i <= 1) powerUp[i].Start(58, 25);
            }

            for (int i = 0; i < soul.Length; i++)
            {
                soul[i] = new Soul();

                if (i > 0) soul[i].Start(30, 30);
                
            }
            door.Start(46, 20);
            if (questOne.SpawnReward(true)) key.Start(26, 13); //92, 55
        }
        public void Update(Player player, Enemy enemy, EnemyManager enemyManager, Inventory inventory, QuestOne questOne)
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Update(player);
            }

            for (int i = 0; i < powerUp.Length; i++)
            {
                powerUp[i].Update(player, enemyManager);
            }

            for (int i = 0; i < soul.Length; i++)
            {
                soul[i].Update(inventory, player);
            }

            door.Update(player, inventory);
            if (questOne.SpawnReward(true)) key.Update(player, inventory);
        }
        public void Draw(Render render, Camera camera, QuestOne questOne)
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Draw('P', render, camera);
            }

            for (int i = 0; i < powerUp.Length; i++)
            {
                powerUp[i].Draw('#', render, camera);
            }

            for (int i = 0; i < soul.Length; i++)
            {
                soul[i].Draw('&', render, camera);
            }
            door.Draw('▓', render, camera);

            if (questOne.SpawnReward(true)) key.Draw('K', render, camera);
        }

        protected void RandomiseInt(int min, int max)
        {
            randNum = random.Next(1, 5);
        }
    }
}


