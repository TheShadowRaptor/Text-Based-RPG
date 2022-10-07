using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Camera
    {
        public int preOffSetX;
        public int preOffSetY;
        public int offSetX = 2;
        public int offSetY = 5;

        public Camera(Player player)
        {
            preOffSetX = offSetX;
            preOffSetY = offSetY;
        }

        public void Update(Player player)
        {
            //offSetX = player.playerX;
            //offSetY = player.playerY;
        }
    }
}
