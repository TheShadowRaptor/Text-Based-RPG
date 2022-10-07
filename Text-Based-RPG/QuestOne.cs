using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class QuestOne : QuestObject
    {
        public QuestOne()
        {
            name = "Evil A Foot";

            information = "Defeat The powerful (That One Minion)";
        }

        public void AcceptQuest(QuestManager questManager)
        {
            questManager.GiveQuest(this);
        }
    }
}
