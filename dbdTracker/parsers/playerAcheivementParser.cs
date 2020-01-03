using dbdTracker.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.parsers
{
    class playerAcheivementParser
    {
        public static void parse(gameData data, string s)
        {
            parseSurvivor(data, s);
            parseKiller(data, s);
        }

        public static void parseSurvivor(gameData data, string s)
        {

        }

        public static void parseKiller(gameData data, string s)
        {
            switch (data.slasherCharacter)
            {
                case "trapper": parseTrapper(data, s); break;
                case "waith": parseWraith(data, s); break;
                case "hillbilly": parseHillbilly(data, s); break;
                case "nurse": parseNurse(data, s); break;
                case "shape": parseShape(data, s); break;
                case "hag": parseHag(data, s); break;
                case "doctor": parseDoctor(data, s); break;
                case "huntress": parseHuntress(data, s); break;
                case "cannible": parseCannibal(data, s); break;
                case "nightmare": parseNightmare(data, s); break;
                case "pig": parsePig(data, s); break;
                case "clown": parseClown(data, s); break;
                case "spirit": parseSpirit(data, s); break;
                case "legion": parseLegion(data, s); break;
                case "plauge": parsePlague(data, s); break;
                case "ghostface": parseGhostFace(data, s); break;
                case "demogorgon": parseDemogorgon(data, s); break;
                case "oni": parseOni(data, s); break;
            }
        }

        public static void parseTrapper(gameData data, string s)
        {

        }

        public static void parseWraith(gameData data, string s)
        {

        }

        public static void parseHillbilly(gameData data, string s)
        {

        }

        public static void parseNurse(gameData data, string s)
        {

        }

        public static void parseShape(gameData data, string s)
        {

        }

        public static void parseHag(gameData data, string s)
        {

        }

        public static void parseDoctor(gameData data, string s)
        {

        }

        public static void parseHuntress(gameData data, string s)
        {

        }

        public static void parseCannibal(gameData data, string s)
        {

        }

        public static void parseNightmare(gameData data, string s)
        {

        }

        public static void parsePig(gameData data, string s)
        {

        }

        public static void parseClown(gameData data, string s)
        {

        }

        public static void parseSpirit(gameData data, string s)
        {

        }

        public static void parseLegion(gameData data, string s)
        {

        }

        public static void parsePlague(gameData data, string s)
        {

        }

        public static void parseGhostFace(gameData data, string s)
        {

        }

        public static void parseDemogorgon(gameData data, string s)
        {

        }

        public static void parseOni(gameData data, string s)
        {

        }

    }
}
