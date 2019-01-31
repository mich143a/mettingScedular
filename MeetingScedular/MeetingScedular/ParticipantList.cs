using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScedular
{
    class ParticipantList
    {
        private List<Participant> participantsList;

        public ParticipantList()
        {
            participantsList = new List<Participant>();
        }
        public List<Participant> getParticipants()
        {
            return participantsList;
        }
        public void addParticipant(Participant newParticipant)
        {
            participantsList.Add(newParticipant);
        }
        public void removeParticipant(int participantIndex)
        {
            participantsList.RemoveAt(participantIndex);
        }
    }
}
