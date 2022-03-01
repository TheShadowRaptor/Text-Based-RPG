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

        public int rows = newMap.Length;
        public int columns = newMap[0].Length;

        int mapX;
        int mapY;

        public void Start()
        {

        }

        public void Draw() // creates the map
        {

            printMap = newMap[rows][columns];
            Console.SetCursorPosition(0, 0);

            for (int x = 0; x <= rows - 1; x++)
            {
                for (int y = 0; y <= columns - 1; y++)
                {
                    mapX = x;
                    mapY = y;

                    ColorMap(mapX, mapY);
                    Console.Write(newMap[x][y]);                  
                }
               
                Console.WriteLine();
            }
        }

        public void Update()
        {
            
        }

        private void ColorMap(int x, int y)
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