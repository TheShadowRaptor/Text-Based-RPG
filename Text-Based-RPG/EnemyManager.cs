using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class EnemyManager
    {
        WeakEnemy[] weakEnemies = new WeakEnemy[25];
        NormalEnemy[] normalEnemies = new NormalEnemy[10];
        ToughEnemy[] toughEnemies = new ToughEnemy[2];

        public void Start()
        {
            // loop for creating Weak enimes
            for (int i = 0; i < weakEnemies.Length; i++)
            {
                weakEnemies[i] = new WeakEnemy();
                weakEnemies[i].Start(0 + i, 15);
            }            
        }

        public void Update()
        {

        }

    }
}
