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

        HealthPotion[] healthPotion = new HealthPotion[25];
        PowerUp[] powerUp = new PowerUp[2];
       // KeyItem[] keyItem = new KeyItem[10];
       // need to change key functionality for future use

        public void Start()
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
            
        }
        public void Update(Player player, Enemy enemy)
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Update(player);
            }

            for (int i = 0; i < powerUp.Length; i++)
            {
                powerUp[i].Update(player, enemy);
            }
        }
        public void Draw(Render render, Camera camera)
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Draw('P', render, camera);
            }

            for (int i = 0; i < powerUp.Length; i++)
            {
                powerUp[i].Draw('#', render, camera);
            }
        }

        protected void RandomiseInt(int min, int max)
        {
            randNum = random.Next(1, 5);
        }
    }
}
