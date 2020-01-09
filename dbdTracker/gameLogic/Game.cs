﻿using dbdTracker.data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker
{
    class Game
    {
        public List<string> dbdIDs = new List<string>();
        public List<string> steamIDs = new List<string>();
        public List<string> userNames = new List<string>();

        public Killer killer;
        public Survivor[] survivors;
        public gameData gameData;

        public Game()
        {
            killer = null;
            survivors = new Survivor[4];
            gameData = new gameData();
            
        }

        public void addSurvivor(string dbdID, string steamID, string userName)
        {
            for (int i = 0; i < survivors.Length; i++)
            {
                if (survivors[i] == null)
                {
                    Console.WriteLine("Adding new surivor: " + dbdID + "|" + steamID);
                    survivors[i] = new Survivor(dbdID, steamID, userName);

                    /*
                    if ((survivors[i].dataIndex = dataHandler.findData(survivors[i].steamID)) == -1)
                    {
                        survivors[i].dataIndex = dataHandler.addData(survivors[i].steamID);
                        dataHandler.data[survivors[i].dataIndex].timesPlayedAgainst++;
                    }
                    */
                    
                    return;

                }
            }

            Console.WriteLine("Something went wrong - tried to add a survivor but there was no room?");
        }

        public void addKiller(string dbdID, string steamID, string userName)
        {
            if (killer == null)
            {
                Console.WriteLine("Adding new killer: " + dbdID + "|" + steamID);
                killer = new Killer(dbdID, steamID, userName);
                gameData.slasherCharacter = "hag";

                /*
                if ((killer.dataIndex = dataHandler.findData(killer.steamID)) == -1)
                {
                    killer.dataIndex = dataHandler.addData(killer.steamID);
                }
                else
                {
                    
                }
                */
                
            }
            else
            {
                Console.WriteLine("Something went wrong - tried to add a killer but there already was one?");
            }
            
        }

        int modelsAdded = 0;
        public void setModels(string s)
        {
            
            if (modelsAdded < 5)
            {
                
                if (s.Contains("InteractionHandler: Verbose:") && s.Contains("[AddInteraction]"))
                {
                    // Console.WriteLine(s);
                    string name = util.util.substring(s, " - ", "Verbose:", "][");
                    // name = name.ToLower();
                    
                    if (killer == null && s.Contains("Slasher"))
                    {
                        //string killerName = util.util.substring(s, " - ", "]");
                        Console.WriteLine(">" + name + "<");
                        addKiller(dbdIDs[userNames.IndexOf(name)], steamIDs[userNames.IndexOf(name)], name);
                        userNames[userNames.IndexOf(name)] = null;

                        killer.modelName = util.util.substring(s, "Verbose: [", " -");
                        // killer.playerName = s.Substring(s.IndexOf("-", s.IndexOf("Verbose:")) + 2, s.IndexOf("]", s.IndexOf("Verbose:")) - s.IndexOf("-", s.IndexOf("Verbose:")) - 2);

                        Console.WriteLine("Added names: >" + killer.modelName + "|" + killer.playerName + "<");

                        killer.modelsAdded = true;

                        modelsAdded++;
                        return;
                    }
                    for (int i = 0; i < survivors.Length; i++)
                    {
                        // Console.WriteLine("Hit: " + name);
                        if (survivors[i] == null && userNames.IndexOf(name) != -1)
                        {
                            //string survivorName = util.util.substring(s, " - ", "]");
                            Console.WriteLine(">" + name + "<");

                            addSurvivor(dbdIDs[userNames.IndexOf(name)], steamIDs[userNames.IndexOf(name)], name);
                            userNames[userNames.IndexOf(name)] = null;

                            survivors[i].modelName = util.util.substring(s, "Verbose: [", " -");
                            // survivors[i].playerName = s.Substring(s.IndexOf("-", s.IndexOf("Verbose:")) + 2, s.IndexOf("]", s.IndexOf("Verbose:")) - s.IndexOf("-", s.IndexOf("Verbose:")) - 2);

                            Console.WriteLine("Added names: >" + survivors[i].modelName + "|" + survivors[i].playerName + "<");

                            survivors[i].modelsAdded = true;

                            modelsAdded++;
                            return;
                        }
                    }
                }
            }
            
        }

        public void setAcheivements(string s)
        {
            if (s.Contains("LogAchievement"))
            {
                string instigator = util.util.substring(s, "Instigator: ", " Target: ");
                Console.WriteLine(instigator);
                if (instigator.Contains(killer.modelName))
                {
                    killer.logAchievements.Add(s);
                    return;
                }
                for (int i = 0; i < survivors.Length; i++)
                {
                    if (instigator.Contains(survivors[i].modelName))
                    {
                        survivors[i].logAchievements.Add(s);
                        return;
                    }
                }
                Console.WriteLine(s);
            }

            if (s.Contains("Hag Hit"))
            {

            }
        }

        

        

        /*
        public Killer getKiller()
        {
            return killer;
        }

        public Survivor[] getSurvivors()
        {
            return survivors;
        }
        */
    }
}
