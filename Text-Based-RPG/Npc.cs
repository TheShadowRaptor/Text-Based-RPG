using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Npc : GameCharacter
    {
        public char icon;

        public int npcX;
        public int npcY;
        public Npc()
        {
            name = "QuestGiver1 the third";

            icon = 'Q';

            npcX = 25;
            npcY = 16;
        }

        public void Start(int x, int y)
        {
            // establish enemy's world position
            npcX = x;
            npcY = y;
        }

        public void Draw(Render render, Camera camera)
        {
            render.Draw(npcX, npcY, '@', ConsoleColor.Magenta, camera);
        }

        public void Update(Player player, QuestOne questOne, QuestManager questManager)
        {
            DetectPlayerChar(player, questOne, questManager);
        }

        protected void DetectPlayerChar(Player player, QuestOne questOne, QuestManager questManager)
        {
            // collision with player
            if (npcX == player.newPlayerX && npcY == player.newPlayerY)
            {
                NpcDialogue(questOne, questManager);
            }
        }

        void NpcDialogue(QuestOne questOne, QuestManager questManager)
        {
            Console.WriteLine("Hello Adventurer");
            Console.WriteLine("Do you mind taking my epic quest?");
            Console.WriteLine("");
            Console.WriteLine("[1]Yes");
            Console.WriteLine("[2]No");

            Decision(questOne, questManager);
        }

        void Decision(QuestOne questOne, QuestManager questManager)
        {
            bool inDialogue = true;

            while (inDialogue)
            {
                ConsoleKey keyPress = Console.ReadKey(true).Key;

                if (keyPress == ConsoleKey.D1)
                {
                    questOne.AcceptQuest(questManager);
                    break;
                }

                if (keyPress == ConsoleKey.D2) break;
            }
        }

        void FinishedQuest()
        {

        }
    }
}
