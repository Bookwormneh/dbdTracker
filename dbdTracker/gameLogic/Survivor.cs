using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker
{
    class Survivor
    {
        public int dataIndex;
        public string steamID = null;
        public string dbdID = null;

        public bool modelsAdded = false;
        public string modelName = null;

        public string playerName = null;

        public List<string> logAchievements = new List<string>();

        public Survivor(string dbdID, string steamID, string playerName)
        {
            this.steamID = steamID;
            this.dbdID = dbdID;
            this.playerName = playerName.ToLower();
        }
    }
}
