using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScedular
{
    public partial class mainMenu : Form
    {
        // variables
        //lists
        private List<Participant> allParticipants;
        private List<Participant> selectedParticipants;

        public mainMenu()
        {
            allParticipants = new List<Participant>();
            selectedParticipants = new List<Participant>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load function
            updateDisplay();
        }

        private void allParticipantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateDisplay()
        {
            allParticipantListBox.Items.Clear();
            SelectedparticipantsListBox.Items.Clear();
            if (allParticipants.Count != 0)
            {
                foreach (Participant participant in allParticipants)
                {
                    allParticipantListBox.Items.Add(participant.getName());
                }
            }
            if (selectedParticipants.Count != 0)
            {
                foreach (Participant participant in selectedParticipants)
                {
                    SelectedparticipantsListBox.Items.Add(participant.getName());
                }
            }

        }

        private void SelectedparticipantsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moveparticipantsLeftBtn_Click(object sender, EventArgs e)
        {
            int currentParticipantIndex = allParticipantListBox.SelectedIndex;
            Participant tempParticipant = allParticipants[currentParticipantIndex];
            if (allParticipantListBox.SelectedItems.Count == 1)
            {
                bool found = false;
                foreach(Participant participant in selectedParticipants)
                {
                    if (tempParticipant == participant)
                    {
                        found = true;
                    }
                    
                }
                if(found == false)
                {
                    selectedParticipants.Add(tempParticipant);
                }
            }
            updateDisplay();
        }

        private void moveparticipantRightBtn_Click(object sender, EventArgs e)
        {
            int currentParticipantIndex = SelectedparticipantsListBox.SelectedIndex;
            selectedParticipants.RemoveAt(currentParticipantIndex);
            updateDisplay();
        }

        private void addparticipantBtn_Click(object sender, EventArgs e)
        {
            addOrEditparticipantsForm addParticipantsForm = new addOrEditparticipantsForm();
            addParticipantsForm.ShowDialog(); // Shows Form2
        }
          void AddToAllParticipants(Participant participant)
        {
            int currentParticipantIndex = allParticipantListBox.SelectedIndex;
            Participant tempParticipant = allParticipants[currentParticipantIndex];
            if (allParticipantListBox.SelectedItems.Count == 1)
            {
                bool found = false;
                foreach (Participant participant in selectedParticipants)
                {
                    if (tempParticipant == participant)
                    {
                        found = true;
                    }

                }
                if (found == false)
                {
                    selectedParticipants.Add(tempParticipant);
                }
            }
            updateDisplay();
        }
    }
}
