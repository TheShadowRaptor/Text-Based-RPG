using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class PowerUp : GameObject
    {
        public void Update(Player player, Enemy enemy)
        {
            if (player.playerX == objectX && player.playerY == objectY)
            {
                isPickedUp = true;
                enemy.isTimeStopped = true;
                countDownTimer = 5;
            }
            if (enemy.isTimeStopped == true)
            {
                if (countDownTimer <= 0)
                {
                    enemy.isTimeStopped = false;
                    countDownTimer = 0;
                }

                countDownTimer--;
            }
        }
    }
}
