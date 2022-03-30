﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Camera
    {
        public int cameraX;
        public int cameraY;
        public int xOffSet = 37;
        public int yOffSet = 17;

        public void Update(Player player)
        {
            cameraX = player.playerX;
            cameraY = player.playerY;
        }
    }
}
