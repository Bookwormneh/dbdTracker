using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker
{
    class userData
    {
        public bool firstTimePlayingAgainst;

        public string steamID;
        public string dbdID;

        public int rating;

        public String comments;

        public int timesPlayedWith;


        public int timesPlayedAgainst;
        public int timesKilled;

        public userData()
        {
            firstTimePlayingAgainst = true;
        }
    }
}
