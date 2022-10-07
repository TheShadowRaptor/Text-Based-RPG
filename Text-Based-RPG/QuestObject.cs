using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class QuestObject
    {
        public string name;
        public string information;

        public void AcceptQuest(QuestManager questManager)
        {
            questManager.GiveQuest(this);
            SpawnEnemy(true);
        }

        public void CompleteQuest(QuestManager questManager)
        {
            SpawnReward(true);
        }

        public bool SpawnEnemy(bool spawn)
        {
            if (spawn == true) return true;
            else return false;
        }

        public bool SpawnReward(bool spawn)
        {
            if (spawn == true) return true;
            else return false;
        }
    }


}
