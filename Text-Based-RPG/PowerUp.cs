using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class PowerUp : GameObject
    {
        int countDownTimer;

        public void Start(int x, int y)
        {
            countDownTimer = 0;
            objectX = x;
            objectY = y;           
        }

        public void Update(Player player, Enemy enemy)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                enemy.isTimeStopped = true;
                countDownTimer = 3;
            }
            if (enemy.isTimeStopped = true)
            {
                if (countDownTimer <= 0)
                {
                    enemy.isTimeStopped = false;
                }

                countDownTimer--;
            }
        }
    }
}
