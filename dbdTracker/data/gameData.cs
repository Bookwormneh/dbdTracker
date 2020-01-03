using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.data
{
    class gameData
    {
        public static Killer killer;
        public static Survivor[] survivors = new Survivor[4];

        public static int killerBloodpointsEarned = 0;
        public static string slasherCharacter = "";

        public static spaceTimeArray huntressHatchetsThrown = new spaceTimeArray();
        public static spaceTimeArray[] huntressHatchetsHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray hagTrapsPlaced = new spaceTimeArray();
        public static spaceTimeArray[] hagTrapsTriggered = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] hagTeleportHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray trapperTrapsPlaced = new spaceTimeArray();
        public static spaceTimeArray[] trapperSurvivorsTrapped = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] trapperTrapsDisarmed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray clownBottlesThrown = new spaceTimeArray();
        public static spaceTimeArray[] clownBottlesDirectHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] clownSurvivorsIntoxicated = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};


        public static bool[] sacrificed = {false, false, false, false};
        public static spaceTimeArray[] timesHooked = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] timesHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] protectionHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray[] palletsThrown = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] killerStuns = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] killerBlinds = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] flashlightSaves = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] bloodpointsEarned = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static double[] genProgress = {0, 0, 0, 0};

    }
}
