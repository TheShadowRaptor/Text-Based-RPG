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
        static string name = "BadLand";
        static string[] newMap = File.ReadAllLines(mapPath);
        public string[] collisionMap;

        public int rows = newMap.Length;
        public int columns = newMap[0].Length;

        ConsoleColor mapColor;

        public int mapRenderSizeX = 17;
        public int mapRenderSizeY = 37;

        //char mapChar;
        int mapX;
        int mapY;

        public void Start()
        {
  
        }

        public void Draw(Render render, Camera camera) // creates the map
        {
            // resets cursor
            Console.SetCursorPosition(0, 0);

            //------------------Top Map Border--------------------
            Console.Write("╔");
            for (int i = 0; i < mapRenderSizeY; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");
            Console.WriteLine("");
            //----------------------------------------------------

            //------------------------Map-------------------------     
            for (int x = 0; x < mapRenderSizeX; x++)
            {
                Console.Write("║");
                for (int y = 0; y < mapRenderSizeY; y++)
                {
                    SetMapColor(x, y, camera);
                    render.MapDraw(y, x, newMap[x + camera.offSetX][y + camera.offSetY]);                    
                }              
                Console.WriteLine("║");
            }
            //----------------------------------------------------

            //------------------Bottom Map Border-----------------
            Console.Write("╚");
            for (int i = 0; i < mapRenderSizeY; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
            Console.WriteLine("");
            Console.WriteLine("Map name = " + "{" + name + "}");
            //----------------------------------------------------
            collisionMap = newMap;
        }

        public void Update()
        {
            
        }

        private void SetMapColor(int x, int y, Camera camera)
        {
            if (newMap[x + camera.offSetX][y + camera.offSetY] == '.')
            {
                mapColor = ConsoleColor.Green;
                Console.ForegroundColor = mapColor;
            }
            else if (newMap[x + camera.offSetX][y + camera.offSetY] == '^')
            {
                mapColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = mapColor;
            }
            else if (newMap[x + camera.offSetX][y + camera.offSetY] == '~')
            {
                mapColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = mapColor;
            }
            else if (newMap[x + camera.offSetX][y + camera.offSetY] == '=')
            {
                mapColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = mapColor;
            }
        }
        // map  bool IsWallAt(map[x,y])  determins walls 
    }
}