using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScedular
{
    class Slot
    {
        private DateTime startTime;
        public Slot(DateTime newDateTime)
        {
            this.startTime = newDateTime;
        }
        public DateTime getStartTime()
        {
            return this.startTime;
        }
        public DateTime getEndTime()
        {
            DateTime endTime = startTime.AddMinutes(60);
            return endTime;
        }
    }
}
