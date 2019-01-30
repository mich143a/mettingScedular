using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScedular
{
    class participantList
    {
        private List<participant> participantsList;

        public participantList()
        {
            participantsList = new List<participant>();
        }
        public List<participant> getparticipants()
        {
            return participantsList;
        }
        public void addparticipant(participant newparticipant)
        {
            participantsList.Add(newparticipant);
        }
        public void removeparticipant(int participantIndex)
        {
            participantsList.RemoveAt(participantIndex);
        }
    }
}
