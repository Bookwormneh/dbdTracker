using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker.data
{
    class spaceTimeArray
    {
        private List<DateTime[]> timeLine;
        private int indexOfCurrentEvent = -1;

        public spaceTimeArray()
        {
            timeLine = new List<DateTime[]>();
        }

        public void addEvent(DateTime eventTime)
        {
            timeLine.Add(new DateTime[]{ eventTime });
        }

        public void startEvent(DateTime eventTime)
        {
            timeLine.Add(new DateTime[] { eventTime , DateTime.MinValue});
            indexOfCurrentEvent = timeLine.Count - 1;
        }

        public void endEvent(DateTime eventTime)
        {
            timeLine[indexOfCurrentEvent][1] = eventTime;
        }

        public int getTotalEvents()
        {
            return timeLine.Count;
        }
    }
}
