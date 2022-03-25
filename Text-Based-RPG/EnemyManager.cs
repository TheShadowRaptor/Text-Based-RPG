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
        public ToughEnemy[] toughEnemies = new ToughEnemy[2];

        public void Start()
        {
            // loop for creating enemies
            for (int i = 0; i < weakEnemies.Length; i++)
            {
                weakEnemies[i] = new WeakEnemy();
                if (i > 12) weakEnemies[i].Start(-10 + i, 5);
                else if (i <= 12) weakEnemies[i].Start(45 + i, 15);
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i] = new NormalEnemy();
                if (i > 3) normalEnemies[i].Start(5 + i, 20);
                else if (i <= 3) normalEnemies[i].Start(40 + i, 20 + i);

            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i] = new ToughEnemy();
                toughEnemies[i].Start(45, 20 + i);
            }
        }

        public void Update(Map map, Player player, Door door)
        {
            for (int i = 0; i < weakEnemies.Length; i++)
            {
                weakEnemies[i].Update(map, player, door, this);
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i].Update(map, player, door, this);
            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i].Update(map, player, door, this);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < weakEnemies.Length; i++)
            {              
                weakEnemies[i].Draw('w');
            }
            for (int i = 0; i < normalEnemies.Length; i++)
            {
                normalEnemies[i].Draw('E');
            }
            for (int i = 0; i < toughEnemies.Length; i++)
            {
                toughEnemies[i].Draw('T');
            }
        }

    }
}
