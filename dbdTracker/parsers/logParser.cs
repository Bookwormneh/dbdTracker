using dbdTracker.parsers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker
{
    class logParser
    {
        /*
         *    [2020.01.02-02.47.16:403][139]LogOnline: Verbose: Mirrors: AddSessionPlayer Session:GameSession PlayerId:950c3540-988f-11e7-a71c-59cd2675d463|76561198121486579
         * 
         * 
         * 
         * UDBDGameInstance::StartOfferingSequence
         * OnlineContextComponent::SendOfferingsDataToUI --> Sending to UI offering Sweet William Sachet
         * GameFlow: GameState : Level is ready to play; map theme name: Junkyard
         * Collected received : BP_Toolbox_002_C_0.
         * 
         * 
         * [619]LogOnlineFriend: STEAM: [MirrorsSocialPresence::UpdateMyPresence] Updating presence status: InMatch
         * 
         * GameFlow: Verbose: ^^^ OnEnteringOnlineMultiplayer ^^^
         * 
         * InteractionHandler: Verbose: [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [TryInteraction SUCCESS] - [PlacePhantomTrap][PhantomTrapSpawner_C_0]
         * 
         * InteractionHandler: Verbose: [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [AddInteraction] - [SearchEmpty][ClosetStandard_C_13]
         * 
         * InteractionHandler: Verbose: [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [AddInteraction] - [FrenzySlasherVaultOverPulldownRight][Bookshelf_C_0]
         * 
         * 
         * [216]InteractionHandler: Verbose: [BP_CamperMale02_Character_C_0 - bman675][CLIENT SLAVE] - [Multicast_StoreInteraction_Implementation] - [CleanseTotem][BP_TotemBase_C_4]
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_PhantomTrapSet Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * Interaction: Verbose: [Vault1][WindowStandard_C_10] - [BP_CamperMale02_Character_C_0 - bman675][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * LogSM: [BP_CamperMale02_Character_C_0][CLIENT SLAVE] <Entering state Navigation>
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_PhantomTrapTrigger Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * InteractionHandler: Verbose: [BP_CamperMale02_Character_C_0 - bman675][CLIENT SLAVE] - [Multicast_StoreInteraction_Implementation] - [CamperStun][BP_PhantomTrap_C_2]
         * 
         * AuthoritativeMovement: BP_CamperMale02_Character_C_0 AuthoritativeMovement set to True
         * 
         * Interaction: Verbose: [TeleportToPhantomTrap][BP_PhantomTrap_C_2] - [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [==> Interaction Enter]
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_TeleportToPhantomTrap Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * LogSM: [BP_Slasher_Character_05_C_0][CLIENT MASTER] <Exiting state Navigation>
[2020.01.02-02.49.46:194][795]LogSM: [BP_Slasher_Character_05_C_0][CLIENT MASTER] <Entering state AttackPounce>
[2020.01.02-02.49.46:194][795]AnimLeader: BP_Slasher_Character_05_C_0 Requested to Play: Attack_Slash_Open Witch AnimTag_FPV.

        Interaction: Player [BP_CamperMale02_Character_C_0] is in chase.
         * 
         * InteractionHandler: Verbose: [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [AddInteraction] - [HagKill_C_0][BP_CamperInteractable_C_1]
         * 
         * AnimLeader: BP_CamperMale02_Character_C_0 Requested to Play: HitHealthyToInjuredB AnimTag_Male.
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_AttackDeviousness Value: 0.000000 Instigator: BP_Slasher_Character_05_C_0 Target: BP_CamperMale02_Character_C_0
[2020.01.02-02.49.46:743][828]LogAchievement: ReceiveGameEvent Type: DBDGameEvent_SurvivorDamaged Value: 1.000000 Instigator: BP_CamperMale02_Character_C_0 Target: <None>
[2020.01.02-02.49.46:745][828]LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_PhantomTrapTriggerAttack Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
[2020.01.02-02.49.46:745][828]LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_PhantomTrapTeleportAttack Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * 
         * LogDBDGeneral: On Hit Sprint Effect [BP_CamperMale02_Character_C_0 - bman675]: On
         * 
         * AnimLeader: BP_Slasher_Character_05_C_0 Requested to Play: Attack_Slash_Succeed Witch AnimTag_FPV.
         * 
         * InteractionHandler: Verbose: [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [AddInteraction] - [GeneratorDamage4][GeneratorStandard_C_5]
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDCamperScore_SprintingNearSlasherPerSecond Value: 0.301002 Instigator: BP_CamperMale02_Character_C_0 Target: <None>
         * 
         * Interaction: Player [BP_CamperMale02_Character_C_0] is not in chase anymore.
         * 
         * AnimLeader: BP_CamperFemale02_Character_C_0 Requested to Play: HitHealthyToInjuredR AnimTag_Crouched AnimTag_Female.
         * 
         * Interaction: Player [BP_CamperFemale02_Character_C_0] is in chase.   
         * 
         * LogDBDGeneral: On Hit Sprint Effect [BP_CamperFemale02_Character_C_0 - NLE Gekyume]: Off
         * 
         * AnimLeader: BP_CamperFemale02_Character_C_0 Requested to Play: HitInjuredToCrawlR AnimTag_Injured AnimTag_Female.
[2020.01.02-02.50.02:608][780]LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_AttackDeviousness Value: 0.000000 Instigator: BP_Slasher_Character_05_C_0 Target: BP_CamperFemale02_Character_C_0
[2020.01.02-02.50.02:609][780]LogAchievement: ReceiveGameEvent Type: DBDCamperScore_FirstTimeDying Value: 1.000000 Instigator: BP_CamperFemale02_Character_C_0 Target: BP_CamperFemale02_Character_C_0
[2020.01.02-02.50.02:609][780]LogAchievement: ReceiveGameEvent Type: DBDGameEvent_SurvivorDamaged Value: 1.000000 Instigator: BP_CamperFemale02_Character_C_0 Target: <None>
[2020.01.02-02.50.02:612][780]LogAchievement: ReceiveGameEvent Type: DBDCamperScore_ChasePerSecond Value: 6.021173 Instigator: BP_CamperFemale02_Character_C_0 Target: <None>
[2020.01.02-02.50.02:616][780]LogDBDGeneral: On Hit Sprint Effect [BP_CamperFemale02_Character_C_0 - NLE Gekyume]: On
[2020.01.02-02.50.02:624][781]Interaction: Player [BP_CamperFemale02_Character_C_0] is not in chase anymore.

         * Interaction: Verbose: [Recover][BP_CamperInteractable_C_2] - [BP_CamperFemale02_Character_C_0 - NLE Gekyume][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDCamperScore_SprintingNearSlasherPerSecond Value: 2.776246 Instigator: BP_CamperMale02_Character_C_0 Target: <None>
         * 
         * Interaction: Verbose: [Pickup][BP_CamperInteractable_C_2] - [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [==> Interaction Enter]
         * 
         * Interaction: Verbose: [GeneratorToolkitRepair1][GeneratorStandard_C_2] - [BP_CamperMale11_Character_C_0 - iSkys][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * Interaction: Verbose: [Wiggle][BP_CamperInteractable_C_2] - [BP_CamperFemale02_Character_C_0 - NLE Gekyume][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * Interaction: Verbose: [HangSurvivor][BP_SmallMeatLocker_Banshee_C_2] - [BP_Slasher_Character_05_C_0 - KingmakerN™][CLIENT MASTER] - [==> Interaction Enter]
         * 
         * AnimLeader: BP_CamperFemale02_Character_C_0 Requested to Play: HookCamperOut AnimTag_Female.
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDCamperScore_BeginQuickVault Value: 1.000000 Instigator: BP_CamperMale03_Character_C_0 Target: <None>
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_MissedAttackInChase Value: 1.000000 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDCamperScore_FirstRepairSkillCheck Value: 1.000000 Instigator: BP_CamperMale11_Character_C_0 Target: <None>
         * 
         * InteractionHandler: Verbose: [BP_CamperFemale02_Character_C_0 - NLE Gekyume][CLIENT SLAVE] - [Multicast_StoreInteraction_Implementation] - [Escape][BP_SmallMeatLocker_Banshee_C_2]
         * 
         * Interaction: Verbose: [Unhook][BP_SmallMeatLocker_Banshee_C_2] - [BP_CamperMale02_Character_C_0 - bman675][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * LogAchievement: ReceiveGameEvent Type: DBDSlasherScore_SacrificePercent Value: 0.053515 Instigator: BP_Slasher_Character_05_C_0 Target: <None>
         * 
         * Interaction: Verbose: [Struggle][BP_SmallMeatLocker_Banshee_C_7] - [BP_CamperMale03_Character_C_0 - The BOI][CLIENT SLAVE] - [<!> Interaction Event OnInteractionExitStart]
         * 
         * Interaction: Verbose: [SacrificeSurvivor][BP_SmallMeatLocker_Banshee_C_7] - [BP_CamperMale03_Character_C_0 - The BOI][CLIENT SLAVE] - [==> Interaction Enter]
         * 
         * 
         * 
         * [503]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: Can_Self_Heal_No_Medkit, Status Owner: BP_CamperMale03_Character_C_0 - The BOI, Originating Player: BP_CamperMale03_Character_C_0 - The BOI, Custom Param: 0.000000, Originating Effect: None, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:678][503]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: Efficient_Medkit_SelfHeal_3, Status Owner: BP_CamperMale03_Character_C_0 - The BOI, Originating Player: BP_CamperMale03_Character_C_0 - The BOI, Custom Param: 0.000000, Originating Effect: None, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:680][503]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: ResilienceEffect, Status Owner: BP_CamperFemale02_Character_C_0 - NLE Gekyume, Originating Player: BP_CamperFemale02_Character_C_0 - NLE Gekyume, Custom Param: 0.000000, Originating Effect: Resilience, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:681][503]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: ExhaustedEffect_Activatable, Status Owner: BP_CamperMale11_Character_C_0 - iSkys, Originating Player: BP_CamperMale11_Character_C_0 - iSkys, Custom Param: 0.000000, Originating Effect: Sprint_Burst, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:681][503]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: SpineChillEffect, Status Owner: BP_CamperMale11_Character_C_0 - iSkys, Originating Player: BP_CamperMale11_Character_C_0 - iSkys, Custom Param: 0.000000, Originating Effect: Spine_Chill, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:707][505]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: StaggerReductionEffect, Status Owner: BP_CamperMale02_Character_C_0 - bman675, Originating Player: BP_CamperMale02_Character_C_0 - bman675, Custom Param: 0.000000, Originating Effect: Balanced_Landing, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:707][505]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: ExhaustedEffect_Activatable, Status Owner: BP_CamperMale02_Character_C_0 - bman675, Originating Player: BP_CamperMale02_Character_C_0 - bman675, Custom Param: 0.000000, Originating Effect: Balanced_Landing, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
[2020.01.02-02.48.50:708][505]LogDBDGeneral: StatusEffect::Multicast_InitializeStatusEffect - Id: Bloodlust, Status Owner: BP_Slasher_Character_05_C_0 - KingmakerN™, Originating Player: BP_Slasher_Character_05_C_0 - KingmakerN™, Custom Param: 0.000000, Originating Effect: None, Is Lifetime Initialized: False, Remaining Lifetime: -1.000000, Lifetime Duration: -1.000000
         
             MatchMembersA=["950c3540-988f-11e7-a71c-59cd2675d463"] : OnlineService
[2020.01.02-02.47.09:290][742]LogOnlineSession: Verbose: OSS: 		MatchMembersB=["24a4c1db-95ca-4596-81a7-cd916f372d05","490ad17a-8fe9-4cf1-a7e1-cfd08ce4bd1d","d4f80504-4d73-4c8d-b502-458958ac1c0e","3e3f9066-3d70-45f6-b3e4-e19b265e6204"] : OnlineService
[2020.01.02-02.47.09:290][742]LogOnlineSession: Verbose: OSS: 		CountA=1 : OnlineService
             
             */

        public static Game parse()
        {
            Console.WriteLine("Begining parse...");

            string hold = "";
            bool lobbyEntered = false;
            bool gameStarted = false;
            Game currentGame = null;

            dataHandler.getData();

        // var fs = new FileStream(@"C:\Users\Noah\AppData\Local\DeadByDaylight\Saved\Logs\DeadByDaylight.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        
            var fs = new FileStream(@"C:\Users\Noah\source\repos\dbdTracker\dbdTracker\DeadByDaylightOriginOneGame.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (StreamReader sr = new StreamReader(fs))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Contains("GameFlow: Joining sesion : GameSession"))
                    {
                        Console.WriteLine("Game found - creating new game.");

                        lobbyEntered = true;
                        currentGame = new Game();
                    }

                    if (lobbyEntered)
                    {
                        // Console.WriteLine(s);
                        if (s.Contains("Session:GameSession PlayerId"))
                        {
                            // Console.WriteLine("Found player ID");
                            if (currentGame.killer == null)
                            {
                                currentGame.addKiller(util.util.substring(s, "PlayerId:", "|"), s.Substring(s.IndexOf("|") + 1)); ;
                                
                            }
                            else
                            {
                                currentGame.addSurvivor(util.util.substring(s, "PlayerId:", "|"), s.Substring(s.IndexOf("|") + 1));
                                
                            }
                        }

                        currentGame.setModels(s);

                        if (s.Contains("GameFlow: Verbose: ^^^ OnEnteringOnlineMultiplayer ^^^"))
                        {
                            lobbyEntered = false;
                            gameStarted = true;
                        }
                    }

                    if (gameStarted)
                    {
                        // currentGame.setAcheivements(s);
                        
                        playerAcheivementParser.parse(currentGame.gameData, s);
                        if (s.Contains("GameFlow: Verbose: vvv OnLeavingOnlineMultiplayer vvv"))
                        {
                            gameStarted = false;
                        }
                        
                    }

                }
            }

            dataHandler.writeData();

            Console.WriteLine("Parse finnished.");

            return currentGame;
        }

        public static string parseTime(string s)
        {
            return "";
        }


    }
}
