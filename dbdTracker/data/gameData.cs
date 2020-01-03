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

        public static bool SWF;
        public static bool fullSWF;

        public static int killerBloodpointsEarned = 0;
        public static string slasherCharacter = "";

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public static bool[] sacrificed = { false, false, false, false };
        public static spaceTimeArray[] timesHooked = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] timesHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] protectionHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray[] timeOnGen = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] timeOnGenCoop = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] skillCheckMissed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] skillCheckGood = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] skillCheckGreat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray[] palletsThrown = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] killerStuns = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] killerBlinds = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] flashlightSaves = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] bloodpointsEarned = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static double[] genProgress = { 0, 0, 0, 0 };

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public static spaceTimeArray trapperTrapsPlaced = new spaceTimeArray();
        public static spaceTimeArray[] trapperSurvivorsTrapped = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] trapperTrapsDisarmed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray wraithTimeCloaked = new spaceTimeArray();

        public static spaceTimeArray hillbillyChainsawRev = new spaceTimeArray();
        public static spaceTimeArray hillbillyChainsawSprint = new spaceTimeArray();
        public static spaceTimeArray hillbillyChainsawMiss = new spaceTimeArray();
        public static spaceTimeArray[] hillbillyChainsawHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray nurseBlinkCharge = new spaceTimeArray();
        public static spaceTimeArray nurseBlinkSprint = new spaceTimeArray();
        public static spaceTimeArray nurseBlinkCooldown = new spaceTimeArray();
        public static spaceTimeArray[] nursePostBlinkHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray shapeTierOne = new spaceTimeArray();
        public static spaceTimeArray shapeTierTwo = new spaceTimeArray();
        public static spaceTimeArray shapeTierThree = new spaceTimeArray();
        public static spaceTimeArray[] shapeTierThreeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] shapeStalk = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray hagTrapsPlaced = new spaceTimeArray();
        public static spaceTimeArray[] hagTrapsTriggered = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] hagTeleportHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray doctorTreatmentMode = new spaceTimeArray();
        public static spaceTimeArray doctorPunishmentMode = new spaceTimeArray();
        public static spaceTimeArray doctorShockCharge = new spaceTimeArray();
        public static spaceTimeArray doctorShock = new spaceTimeArray();
        public static spaceTimeArray[] doctorShockHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] doctorMaddnessOne = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] doctorMaddnessTwo = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] doctorMaddnessThree = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray huntressHatchetCharge = new spaceTimeArray();
        public static spaceTimeArray huntressHatchetThrown = new spaceTimeArray();
        public static spaceTimeArray[] huntressHatchetHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray cannibalChainsawRev = new spaceTimeArray();
        public static spaceTimeArray cannibalChainsawSprint = new spaceTimeArray();
        public static spaceTimeArray cannibalChainsawMiss = new spaceTimeArray();
        public static spaceTimeArray[] cannibalChainsawHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray nightmareSnareCharged = new spaceTimeArray();
        public static spaceTimeArray nightmareSnarePlaced = new spaceTimeArray();
        public static spaceTimeArray[] nightmareDreaming = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] nightmareClockWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] nightmareGenWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] nightmareSurvivorWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray pigCrouched = new spaceTimeArray();
        public static spaceTimeArray pigLungeAttack = new spaceTimeArray();
        public static spaceTimeArray[] pigLungeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] pigTrapped = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] pigPuzzleBoxSearch = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray clownBottlesThrown = new spaceTimeArray();
        public static spaceTimeArray[] clownBottlesDirectHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public static spaceTimeArray[] clownSurvivorsIntoxicated = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public static spaceTimeArray spiritPhaseCharge = new spaceTimeArray();
        public static spaceTimeArray spiritPhaseSprint = new spaceTimeArray();
        public static spaceTimeArray spiritGlitchAppearance = new spaceTimeArray();
        public static spaceTimeArray[] spiritPhaseHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray legionFrenzy = new spaceTimeArray();
        public static spaceTimeArray[] legionFrenzyHeartbeat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] legionFrenzyHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray plagueVomitCharge = new spaceTimeArray();
        public static spaceTimeArray plagueVomitSpit = new spaceTimeArray();
        public static spaceTimeArray[] plagueVomitInfect = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray plaguePurge = new spaceTimeArray();
        public static spaceTimeArray plaguePurgeCharge = new spaceTimeArray();
        public static spaceTimeArray plaguePurgeSpit = new spaceTimeArray();
        public static spaceTimeArray[] plaguePurgeInfect = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray ghostfaceCrouched = new spaceTimeArray();
        public static spaceTimeArray ghostfaceStalk = new spaceTimeArray();
        public static spaceTimeArray[] ghostfaceStalked = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] ghostfaceExposed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] ghostfaceRevealed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray demogorgonRev = new spaceTimeArray();
        public static spaceTimeArray demogorgonLunge = new spaceTimeArray();
        public static spaceTimeArray demogorgonPlacePortal = new spaceTimeArray();
        public static spaceTimeArray demogorgonPortalTravel = new spaceTimeArray();
        public static spaceTimeArray[] demogorgonLungeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] demogorgonPortalHeartbeat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray[] demogorgonPortalClense = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public static spaceTimeArray oniCollectBlood = new spaceTimeArray();
        public static spaceTimeArray oniEnrage = new spaceTimeArray();
        public static spaceTimeArray oniChargeDemonDash = new spaceTimeArray();
        public static spaceTimeArray oniDemonDash = new spaceTimeArray();
        public static spaceTimeArray[] oniDashHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public static spaceTimeArray oniChargeSmash = new spaceTimeArray();
        public static spaceTimeArray[] oniSmashHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public static spaceTimeArray ruinTime = new spaceTimeArray();

    }
}
