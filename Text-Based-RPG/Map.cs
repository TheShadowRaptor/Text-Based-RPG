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

        ConsoleColor mapColor;
        char mapChar;

        int mapX;
        int mapY;

        public void Start()
        {

        }

        public void Draw(Render render, Camera camera) // creates the map
        {
            for (int x = 0; x <= rows - 1; x++)
            {
                for (int y = 0; y <= columns - 1; y++)
                {
                    mapX = x;
                    mapY = y;

                    //Console.SetCursorPosition(mapY, mapX);
                    SetMapColor(mapX, mapY);
                    //Console.Write(newMap[mapX][mapY]);                   
                    mapChar = newMap[x][y];
                    render.Draw(mapY, mapX, mapChar, mapColor, camera);

                }              
                Console.WriteLine();
            }
            collisionMap = newMap;
        }

        public void Update()
        {
            
        }

        private void SetMapColor(int x, int y)
        {
            if (newMap[x][y] == '.')
            {
                mapColor = ConsoleColor.Green;
                Console.ForegroundColor = mapColor;
            }
            else if (newMap[x][y] == '^')
            {
                mapColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = mapColor;
            }
            else if (newMap[x][y] == '~')
            {
                mapColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = mapColor;
            }           
        }
        // map  bool IsWallAt(map[x,y])  determins walls 
    }
}