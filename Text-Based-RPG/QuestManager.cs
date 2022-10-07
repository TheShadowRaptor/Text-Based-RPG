using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class QuestManager
    {
        public List<QuestObject> quests;

        public int currentQuest;

        public QuestManager()
        {
            quests = new List<QuestObject>();
        }

        public void GiveQuest(QuestObject questObject)
        {
            quests.Add(questObject);
        }

        public void RemoveQuest(QuestObject questObject)
        {
            quests.Remove(quests[currentQuest]);
        }

        public void ShowQuests()
        {
            Console.WriteLine("-------Quests--------");
            if (quests == null) Console.WriteLine("You need some quests bro...");
            else 
            {
                foreach (QuestObject item in quests)
                {                
                    Console.WriteLine(item.name + ": " + item.information);
                }
            }

        }
    }
}
