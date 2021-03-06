﻿using System;
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
        public Killer killer;
        public Survivor[] survivors;

        public Game()
        {
            killer = null;
            survivors = new Survivor[4];
            
        }

        public void addSurvivor(string dbdID, string steamID)
        {
            for (int i = 0; i < survivors.Length; i++)
            {
                if (survivors[i] == null)
                {
                    Console.WriteLine("Adding new surivor: " + dbdID + "|" + steamID);
                    survivors[i] = new Survivor(dbdID, steamID, getUserFromId(steamID));
                    survivors[i].data = dataHandler.getData(survivors[i].steamID);
                    return;
                }
            }

            Console.WriteLine("Something went wrong - tried to add a survivor but there was no room?");
        }

        public void addKiller(string dbdID, string steamID)
        {
            if (killer == null)
            {
                Console.WriteLine("Adding new killer: " + dbdID + "|" + steamID);
                killer = new Killer(dbdID, steamID, getUserFromId(steamID));
                killer.data = dataHandler.getData(killer.steamID);
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
                    string name = s.Substring(s.IndexOf("-", s.IndexOf("Verbose:")) + 2, s.IndexOf("]", s.IndexOf("Verbose:")) - s.IndexOf("-", s.IndexOf("Verbose:")) - 2);
                    name = name.ToLower();
                    
                    if (name.Contains(killer.playerName) && !killer.modelsAdded)
                    {
                        killer.modelName = s.Substring(s.IndexOf("Verbose:") + "Verbose:".Length + 2, s.IndexOf("-", s.IndexOf("Verbose:")) - s.IndexOf("Verbose:") - "Verbose:".Length - 3);
                        // killer.playerName = s.Substring(s.IndexOf("-", s.IndexOf("Verbose:")) + 2, s.IndexOf("]", s.IndexOf("Verbose:")) - s.IndexOf("-", s.IndexOf("Verbose:")) - 2);

                        Console.WriteLine("Added names: >" + killer.modelName + "|" + killer.playerName + "<");

                        killer.modelsAdded = true;

                        modelsAdded++;
                        return;
                    }
                    for (int i = 0; i < survivors.Length; i++)
                    {
                        if (name.Contains(survivors[i].playerName) && !survivors[i].modelsAdded)
                        {
                            survivors[i].modelName = s.Substring(s.IndexOf("Verbose:") + "Verbose:".Length + 2, s.IndexOf("-", s.IndexOf("Verbose:")) - s.IndexOf("Verbose:") - "Verbose:".Length - 3);
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
                string instigator = s.Substring(s.IndexOf("Instigator: ") + "Instigator: ".Length, s.IndexOf("Target: ", s.IndexOf("Instigator: ") + "Instigator: ".Length + 1) - s.IndexOf("Instigator: ") - "Instigator: ".Length - 1);
                // Console.WriteLine(instigator);
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
        }

        public static string getUserFromId(string id)
        {
            string hold;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://steamcommunity.com/profiles/" + id);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                //hold = response.ResponseUri.ToString();
                hold = reader.ReadToEnd();
            }
            // hold = hold.Substring(hold.IndexOf("id") + "id".Length + 1, hold.IndexOf("/", hold.IndexOf("id") + "id".Length + 1) - hold.IndexOf("id") - "id".Length - 1);
            // Console.WriteLine(">" + hold + "<");
            hold = hold.Substring(hold.IndexOf("<title>Steam Community :: ") + "<title>Steam Community :: ".Length, hold.IndexOf("</title>", hold.IndexOf("<title>Steam Community :: ") + "<title>Steam Community :: ".Length) - hold.IndexOf("<title>Steam Community :: ") - "<title>Steam Community :: ".Length);


            Console.WriteLine(">" + hold + "<");



            return hold;
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
