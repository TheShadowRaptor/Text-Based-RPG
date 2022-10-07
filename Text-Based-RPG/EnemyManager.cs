using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class EnemyManager
    {
        public WeakEnemy[] weakEnemies = new WeakEnemy[25];
        public NormalEnemy[] normalEnemies = new NormalEnemy[10];
        public ToughEnemy[] toughEnemies = new ToughEnemy[3];
        public ThatOneMinion thatOneMinion = new ThatOneMinion();
        public Boss_Enemy bossEnemy = new Boss_Enemy();

        public void Start(QuestOne questOne)
        {
            // loop for creating enemies
            for (int i = 0; i < weakEnemies.Length; i++)
            {
                weakEnemies[i] = new WeakEnemy();
                if (i > 12) weakEnemies[i].Start(15 + i, 15);
                else if (i <= 12) weakEnemies[i].Start(70 + i, 25);
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i] = new NormalEnemy();
                if (i > 3) normalEnemies[i].Start(30 + i, 30);
                else if (i <= 3) normalEnemies[i].Start(65 + i, 30 + i);

            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i] = new ToughEnemy();
                if (i == 0)
                {
                    toughEnemies[i].Start(72, 58);
                }
                else if (i == 1)
                {
                    toughEnemies[i].Start(72, 55);
                }
                else if (i == 2)
                {
                    toughEnemies[i].Start(72, 52);
                }
                
            }

            bossEnemy.Start(58, 22);

            //Quest Spawn-------------------------------------------------
            if (questOne.SpawnEnemy(true)) thatOneMinion.Start(25,22);


        }

        public void Update(Map map, Player player, Shop shop, ItemManager itemManager, Npc npc, QuestOne questOne)
        {
            for (int i = 0; i < weakEnemies.Length; i++)
            {
                weakEnemies[i].Update(map, player, shop, itemManager, this, npc);
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i].Update(map, player, shop, itemManager, this, npc);
            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i].Update(map, player, shop, itemManager, this, npc);
            }

            bossEnemy.Update(map, player, shop, itemManager, this, npc);

            //Quest Spawn-------------------------------------------------
            if (questOne.SpawnEnemy(true)) thatOneMinion.Update(map, player, shop, itemManager, this, npc);
        }

        public void Draw(Render render, Camera camera, QuestOne questOne)
        {
            for (int i = 0; i < weakEnemies.Length; i++)
            {              
                weakEnemies[i].Draw('w', render, camera);
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i].Draw('E', render, camera);
            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i].Draw('T', render, camera);
            }

            bossEnemy.Draw('B', render, camera);

            //Quest Spawn-------------------------------------------------
            if (questOne.SpawnEnemy(true)) thatOneMinion.Draw('!', render, camera);
        }

    }
}
