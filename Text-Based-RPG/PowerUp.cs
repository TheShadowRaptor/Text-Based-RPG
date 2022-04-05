using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class PowerUp : GameObject
    {
        public void Update(Player player, EnemyManager enemyManager)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                countDownTimer = 5;
            }

            if (countDownTimer <= 0)
            {

                // weak enemies
                for (int i = 0; i < enemyManager.weakEnemies.Length; i++)
                {
                    enemyManager.weakEnemies[i].isTimeStopped = true;                   

                    if (enemyManager.weakEnemies[i].isTimeStopped == true)
                    {
                        if (countDownTimer <= 0)
                        {
                            enemyManager.weakEnemies[i].isTimeStopped = false;
                            countDownTimer = 0;
                        }
                    }
                }
                // normal enemies
                for (int i = 0; i < enemyManager.normalEnemies.Length; i++)
                {
                    enemyManager.normalEnemies[i].isTimeStopped = true;

                    if (enemyManager.normalEnemies[i].isTimeStopped == true)
                    {
                        if (countDownTimer <= 0)
                        {
                            enemyManager.normalEnemies[i].isTimeStopped = false;
                            countDownTimer = 0;
                        }
                    }
                }
                // tough enemies
                for (int i = 0; i < enemyManager.toughEnemies.Length; i++)
                {
                    enemyManager.toughEnemies[i].isTimeStopped = true;

                    if (enemyManager.toughEnemies[i].isTimeStopped == true)
                    {
                        if (countDownTimer <= 0)
                        {
                            enemyManager.toughEnemies[i].isTimeStopped = false;
                            countDownTimer = 0;
                        }
                    }
                }
                // boss enemy
                enemyManager.bossEnemy.isTimeStopped = true;
                if (countDownTimer <= 0)
                {
                    enemyManager.bossEnemy.isTimeStopped = false;
                }

                countDownTimer--;
            }

        }
    }
}
