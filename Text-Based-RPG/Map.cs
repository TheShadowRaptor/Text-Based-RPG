using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    class Map
    {
        // init         // string[i] // map[x,y] = mapData[y][x]
        static string mapPath = @"map.txt";
        static string[] newMap = File.ReadAllLines(mapPath);
        public string[] collisionMap;

        public int rows = newMap.Length;
        public int columns = newMap[0].Length;

        public int mapX;
        public int mapY;
        public int screenX;
        public int screenY;

        public void Start()
        {

        }

        public void Draw(Player player) // creates the map
        {
            //Console.Clear();
            for (int x = 0; x <= rows - 1; x++)
            {
                for (int y = 0; y <= columns - 1; y++)
                {
                    mapX = x;
                    mapY = y;
                    screenX = mapX - player.playerY;
                    screenY = mapY - player.playerX;

                    if (MapDrawCheck() == true)
                    {
                        Console.SetCursorPosition(mapY, mapX);
                        SetMapColor(mapX, mapY);
                        Console.Write(newMap[x][y]);
                    }                                                                   
                }              
               // Console.WriteLine();
            }
            collisionMap = newMap;
        }

        public void Update()
        {
            
        }

        private bool MapDrawCheck()
        {
            // checks screen for drawing map
            if (mapX < 0 || mapY < 0) return false;
            else if (mapX >= rows - 1 || mapY >= columns - 1) return false;
            else return true;
        }

        private void SetMapColor(int x, int y)
        {
            if (newMap[mapX][mapY] == '.')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (newMap[mapX][mapY] == '^')
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (newMap[mapX][mapY] == '~')
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }           
        }
        // map  bool IsWallAt(map[x,y])  determins walls 
    }
}