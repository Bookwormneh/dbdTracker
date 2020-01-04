using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.util
{
    class util
    {

        // This method returns a string that starts at the end of "startString", and ends at the start of "endString"
        public static string substring(string s, string startString, string endString)
        {
            // Console.WriteLine(s + Environment.NewLine + ">" + startString + "< to >" + endString + "<");
            return s.Substring(s.IndexOf(startString) + startString.Length, s.IndexOf(endString) - s.IndexOf(startString) - startString.Length);
        }

        public static string substring(string s, string startString, string startFrom, string endString)
        {
            // Console.WriteLine(s + Environment.NewLine + ">" + startString + "< to >" + endString + "< start from >" + startFrom + "<");
            return s.Substring(s.IndexOf(startString, s.IndexOf(startFrom)) + startString.Length, s.IndexOf(endString, s.IndexOf(startString, s.IndexOf(startFrom)) + 1) - s.IndexOf(startString, s.IndexOf(startFrom)) - startString.Length);
        }

        public static string substring(string s, string startString, int startIndex, string endString)
        {
            // Console.WriteLine(s + Environment.NewLine + ">" + startString + "< to >" + endString + "<");
            return s.Substring(s.IndexOf(startString, startIndex) + startString.Length, s.IndexOf(endString, startIndex) - s.IndexOf(startString, startIndex) - startString.Length);
        }

        public static string removeFirstOccurence(string s, string toRemove)
        {
            return s.Remove(s.IndexOf(toRemove), toRemove.Length).Insert(s.IndexOf(toRemove), "");
            
        }

        public static bool containsTag(string s, string contain)
        {
            if (splitTag(s).Contains(contain))
            {
                return true;
            }
            return false;
        }

        public static List<string> splitTag(string s)
        {
            List<string> hold = new List<string>();
            
            while (s.IndexOf('[') != -1)
            {
                hold.Add(substring(s, "[", "]"));
                s = s.Remove(s.IndexOf(hold[hold.Count - 1]) - 1, hold[hold.Count - 1].Length + 2);
            }

            return hold;
        }

        private static char[] seperators = { '.', '-', ':'};
        public static DateTime getTime(string s)
        {
            // [2020.01.02-02.50.54:641]

            string[] hold = substring(s, "[", "]").Split(seperators);



            //Console.WriteLine(new DateTime(Int32.Parse(hold[0]), Int32.Parse(hold[1]), Int32.Parse(hold[2]), Int32.Parse(hold[3]), Int32.Parse(hold[4]), Int32.Parse(hold[5]), Int32.Parse(hold[6])).ToString());

            return new DateTime(Int32.Parse(hold[0]), Int32.Parse(hold[1]), Int32.Parse(hold[2]), Int32.Parse(hold[3]), Int32.Parse(hold[4]), Int32.Parse(hold[5]), Int32.Parse(hold[6]));

            /*
            
            string[] hold = { "", "", "", "", "", "", "" };
            // DateTime hold = DateTime.MinValue;
            hold[0] = (substring(s, "[", "."));
            
            hold[1] = (substring(s, ".", hold[0] + ".", "."));

            hold[2] = (substring(s, ".", hold[0] + "." + hold[1] + ".", "-"));

            hold[3] = (substring(s, "-", hold[0] + "." + hold[1] + "." + hold[2] + "-", "."));

            hold[4] = (substring(s, ".", hold[0] + "." + hold[1] + "." + hold[2] + "-" + hold[3] + ".", "."));

            hold[5] = (substring(s, ".", hold[0] + "." + hold[1] + "." + hold[2] + "-" + hold[3] + "." + hold[4] + ".", ":"));

            hold[6] = (substring(s, ":", hold[0] + "." + hold[1] + "." + hold[2] + "-" + hold[3] + "." + hold[4] + "." + hold[5] + ":", "]"));


            //Console.WriteLine(new DateTime(Int32.Parse(hold[0]), Int32.Parse(hold[1]), Int32.Parse(hold[2]), Int32.Parse(hold[3]), Int32.Parse(hold[4]), Int32.Parse(hold[5]), Int32.Parse(hold[6])).ToString());
            
            return new DateTime(Int32.Parse(hold[0]), Int32.Parse(hold[1]), Int32.Parse(hold[2]), Int32.Parse(hold[3]), Int32.Parse(hold[4]), Int32.Parse(hold[5]), Int32.Parse(hold[6]));
            */
        }
    }
}
