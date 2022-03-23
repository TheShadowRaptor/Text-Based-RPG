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
        PowerUp[] powerUp = new PowerUp[6];
       // KeyItem[] keyItem = new KeyItem[10];
       // need to change key functionality for future use

        public void Start()
        {           
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i] = new HealthPotion();
                if (i < 12) healthPotion[i].Start(10 + i, 15);
                else if (i >= 12) healthPotion[i].Start(35 + i, 16);
            }
        }
        public void Update(Player player)
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Update(player);
            }
        }
        public void Draw()
        {
            for (int i = 0; i < healthPotion.Length; i++)
            {
                healthPotion[i].Draw('P');
            }
        }

        protected void RandomiseInt(int min, int max)
        {
            randNum = random.Next(1, 5);
        }
    }
}
