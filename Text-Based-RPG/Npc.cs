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

        int currentDialogueNumber;

        public Npc()
        {
            name = "QuestGiver1 the third";

            icon = 'Q';

            npcX = 25;
            npcY = 20;
        }

        public void Start(int x, int y)
        {
            // establish enemy's world position
            npcX = x;
            npcY = y;
        }

        public void Draw(Render render, Camera camera)
        {
            render.Draw(npcX, npcY, 'Q', ConsoleColor.Magenta, camera);
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
            DialogueList(questOne, questManager);

            Decision(questOne, questManager);
        }


        void DialogueList(QuestOne questOne, QuestManager questManager)
        {
            if (currentDialogueNumber == 0)
            {
                Console.WriteLine("Hello Adventurer");
                Console.WriteLine("Do you mind taking my epic quest?");
                Console.WriteLine("");
                Console.WriteLine("[1]Yes");
                Console.WriteLine("[2]No");
            }

            if (currentDialogueNumber == 1)
            {
                Console.WriteLine("Good job, Here is the key...");
                Console.WriteLine("Why Do I have it?");
                Console.WriteLine("No idea...");
            }
        }
        void Decision(QuestOne questOne, QuestManager questManager)
        {
            bool inDialogue = true;

            while (inDialogue)
            {
                ConsoleKey keyPress = Console.ReadKey(true).Key;

                if (currentDialogueNumber == 0)
                {
                    if (keyPress == ConsoleKey.D1)
                    {
                        questOne.AcceptQuest(questManager);
                        Console.Clear();
                        break;
                    }

                    if (keyPress == ConsoleKey.D2)
                    {
                        Console.Clear();
                        break;
                    }
                }

                else if (currentDialogueNumber == 1)
                {
                    int currentNumber = 0;
                    foreach (QuestObject item in questManager.quests)
                    {
                        if (item.name == "Evil a Foot")
                        {
                            questManager.RemoveQuest(questManager.quests[currentNumber]);
                            Console.Beep(50, 50);
                            break;
                        }                        
                        currentNumber += 1;
                    }
                    questOne.CompleteQuest(questManager);
                }


            }
        }

        public void FinishedQuest()
        {
            currentDialogueNumber = 1;
        }
    }
}
