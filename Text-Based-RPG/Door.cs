using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Door : GameObject
    {
        public void Start(int x, int y)
        {
            countDownTimer = 0;
            objectX = x;
            objectY = y;
        }
    }
}
