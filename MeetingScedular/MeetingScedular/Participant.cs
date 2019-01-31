﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScedular
{
    class Participant
    {
        //variables
        private string name;
        private string email;
        private List<Slot> exclusionSet;
        private List<Slot> preferedSet;
        private int importance = 0;
        //calls

        //constructor
        public Participant()
        {

            exclusionSet = new List<Slot>();
            preferedSet = new List<Slot>();
        }
        //methods
        public string getName()
        {
            return this.name;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public string getEmail(string newEmail)
        {
            return this.name;
        }
        public void setEmail(string newEmail)
        {
            this.email = newEmail;
        }
        public List<Slot> getExSet()
        {
            return exclusionSet;
        }
        public void addExSetSlot(DateTime newDateTime)
        {
            Slot slot = new Slot(newDateTime);
            exclusionSet.Add(slot);
        }
        public void removeExSetSlot(int slotIndex)
        {
            exclusionSet.RemoveAt(slotIndex);
        }
        public List<Slot> getPreSet()
        {
            return preferedSet;
        }
        public void addPreSet(DateTime newDateTime)
        {
            Slot slot = new Slot(newDateTime);
            preferedSet.Add(slot);
        }
        public void removePreSetSlot(int slotIndex)
        {
            preferedSet.RemoveAt(slotIndex);
        }
        public int getImportance()
        {
            return this.importance;
        }
        public void setImportance(int importance)
        {
            this.importance = importance;
        }
        //calculate methods
        //flexibilty

    }

}