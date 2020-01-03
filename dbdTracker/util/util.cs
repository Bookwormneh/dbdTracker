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
            return s.Substring(s.IndexOf(startString) + startString.Length, s.IndexOf(endString) - s.IndexOf(startString) - startString.Length);
        }
    }
}
