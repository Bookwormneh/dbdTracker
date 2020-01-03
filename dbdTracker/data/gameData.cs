using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.data
{
    class gameData
    {
        public Killer killer;
        public Survivor[] survivors = new Survivor[4];

        public bool SWF;
        public bool fullSWF;

        public int killerBloodpointsEarned = 0;
        public string slasherCharacter = "";

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public bool[] sacrificed = { false, false, false, false };
        public spaceTimeArray[] timesHooked = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] timesHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] protectionHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray[] timeOnGen = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] timeOnGenCoop = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] skillCheckMissed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] skillCheckGood = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] skillCheckGreat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray[] palletsThrown = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] killerStuns = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] killerBlinds = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] flashlightSaves = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] bloodpointsEarned = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public double[] genProgress = { 0, 0, 0, 0 };

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public spaceTimeArray trapperTrapsPlaced = new spaceTimeArray();
        public spaceTimeArray[] trapperSurvivorsTrapped = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] trapperTrapsDisarmed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray wraithTimeCloaked = new spaceTimeArray();

        public spaceTimeArray hillbillyChainsawRev = new spaceTimeArray();
        public spaceTimeArray hillbillyChainsawSprint = new spaceTimeArray();
        public spaceTimeArray hillbillyChainsawMiss = new spaceTimeArray();
        public spaceTimeArray[] hillbillyChainsawHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray nurseBlinkCharge = new spaceTimeArray();
        public spaceTimeArray nurseBlinkSprint = new spaceTimeArray();
        public spaceTimeArray nurseBlinkCooldown = new spaceTimeArray();
        public spaceTimeArray[] nursePostBlinkHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray shapeTierOne = new spaceTimeArray();
        public spaceTimeArray shapeTierTwo = new spaceTimeArray();
        public spaceTimeArray shapeTierThree = new spaceTimeArray();
        public spaceTimeArray[] shapeTierThreeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] shapeStalk = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray hagTrapsPlaced = new spaceTimeArray();
        public spaceTimeArray[] hagTrapsTriggered = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public spaceTimeArray[] hagTeleportHits = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public spaceTimeArray doctorTreatmentMode = new spaceTimeArray();
        public spaceTimeArray doctorPunishmentMode = new spaceTimeArray();
        public spaceTimeArray doctorShockCharge = new spaceTimeArray();
        public spaceTimeArray doctorShock = new spaceTimeArray();
        public spaceTimeArray[] doctorShockHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] doctorMaddnessOne = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] doctorMaddnessTwo = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] doctorMaddnessThree = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray huntressHatchetCharge = new spaceTimeArray();
        public spaceTimeArray huntressHatchetThrown = new spaceTimeArray();
        public spaceTimeArray[] huntressHatchetHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray cannibalChainsawRev = new spaceTimeArray();
        public spaceTimeArray cannibalChainsawSprint = new spaceTimeArray();
        public spaceTimeArray cannibalChainsawMiss = new spaceTimeArray();
        public spaceTimeArray[] cannibalChainsawHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray nightmareSnareCharged = new spaceTimeArray();
        public spaceTimeArray nightmareSnarePlaced = new spaceTimeArray();
        public spaceTimeArray[] nightmareDreaming = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] nightmareClockWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] nightmareGenWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] nightmareSurvivorWakeUp = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray pigCrouched = new spaceTimeArray();
        public spaceTimeArray pigLungeAttack = new spaceTimeArray();
        public spaceTimeArray[] pigLungeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] pigTrapped = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] pigPuzzleBoxSearch = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray clownBottlesThrown = new spaceTimeArray();
        public spaceTimeArray[] clownBottlesDirectHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};
        public spaceTimeArray[] clownSurvivorsIntoxicated = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray()};

        public spaceTimeArray spiritPhaseCharge = new spaceTimeArray();
        public spaceTimeArray spiritPhaseSprint = new spaceTimeArray();
        public spaceTimeArray spiritGlitchAppearance = new spaceTimeArray();
        public spaceTimeArray[] spiritPhaseHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray legionFrenzy = new spaceTimeArray();
        public spaceTimeArray[] legionFrenzyHeartbeat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] legionFrenzyHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray plagueVomitCharge = new spaceTimeArray();
        public spaceTimeArray plagueVomitSpit = new spaceTimeArray();
        public spaceTimeArray[] plagueVomitInfect = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray plaguePurge = new spaceTimeArray();
        public spaceTimeArray plaguePurgeCharge = new spaceTimeArray();
        public spaceTimeArray plaguePurgeSpit = new spaceTimeArray();
        public spaceTimeArray[] plaguePurgeInfect = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray ghostfaceCrouched = new spaceTimeArray();
        public spaceTimeArray ghostfaceStalk = new spaceTimeArray();
        public spaceTimeArray[] ghostfaceStalked = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] ghostfaceExposed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] ghostfaceRevealed = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray demogorgonRev = new spaceTimeArray();
        public spaceTimeArray demogorgonLunge = new spaceTimeArray();
        public spaceTimeArray demogorgonPlacePortal = new spaceTimeArray();
        public spaceTimeArray demogorgonPortalTravel = new spaceTimeArray();
        public spaceTimeArray[] demogorgonLungeHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] demogorgonPortalHeartbeat = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray[] demogorgonPortalClense = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        public spaceTimeArray oniCollectBlood = new spaceTimeArray();
        public spaceTimeArray oniEnrage = new spaceTimeArray();
        public spaceTimeArray oniChargeDemonDash = new spaceTimeArray();
        public spaceTimeArray oniDemonDash = new spaceTimeArray();
        public spaceTimeArray[] oniDashHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };
        public spaceTimeArray oniChargeSmash = new spaceTimeArray();
        public spaceTimeArray[] oniSmashHit = { new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray(), new spaceTimeArray() };

        /* --------------------------------------------------------------------------------------------------------------------------------------- */

        public spaceTimeArray ruinTime = new spaceTimeArray();

    }
}
