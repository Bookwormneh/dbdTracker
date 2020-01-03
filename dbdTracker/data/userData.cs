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

        public string comments;

        public int stTimesPlayedWith;
        public int stTimesEscaped;
        public int stTimesDied;

        public int timesPlayedAgainst;
        public int timesKilled;
        public int timesEscaped;



        public userData()
        {
            firstTimePlayingAgainst = true;
        }
    }
}
