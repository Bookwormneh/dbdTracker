using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.data
{
    class spaceTimeArray
    {
        private List<int[]> timeLine;
        private int indexOfCurrentEvent = -1;

        public spaceTimeArray()
        {
            timeLine = new List<int[]>();
        }

        public void addEvent(int eventTime)
        {
            timeLine.Add(new int[]{ eventTime });
        }

        public void startEvent(int eventTime)
        {
            timeLine.Add(new int[] { eventTime , -1});
            indexOfCurrentEvent = timeLine.Count - 1;
        }

        public void endEvent(int eventTime)
        {
            timeLine[indexOfCurrentEvent][1] = eventTime;
        }

        public int getTotalEvents()
        {
            return timeLine.Count;
        }
    }
}
