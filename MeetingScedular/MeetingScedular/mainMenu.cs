using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace MeetingScedular
{
    public partial class mainMenu : Form
    {
        // variables
        string name ="error";
        string email = "error";
        int importance = 5;
        Participant newParticipant;
        //lists
        private ParticipantList allParticipants;
        private ParticipantList selectedParticipants;

        public mainMenu()
        {
            allParticipants = new ParticipantList();
            selectedParticipants = new ParticipantList();
            newParticipant = new Participant();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //DateTime dateTime = DateTime.ParseExact("2009-12-01 23:12:10", "yyyy-MM-dd HH:mm:ss", null);
            string[] lines = System.IO.File.ReadAllLines(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "allParticipants.txt"));

            // Display the file contents by using a foreach loop.
            int lineNum = 1;
            foreach (string line in lines)
            {
                if(line == "#")
                {
                    Participant loadParticipant = new Participant();
                    lineNum = 0;
                }
                //while (nextParticipant == false)
                
                    if (lineNum == 1)
                    {
                        loadParticipant.setName(line);
                        lineNum++;
                    }
                    if (lineNum == 2)
                    {
                        loadParticipant.setEmail(line);
                        lineNum++;
                    }
                    if (lineNum == 3)
                    {
                        //importance = line;
                        lineNum++;
                    }
                    if(lineNum == 4 && line == "ex")
                    {
                        lineNum++;
                    }
                    if(lineNum == 5)
                    {
                        if (line == "pre")
                        {
                            lineNum++;
                        }
                        else
                        {
                            DateTime newDate = DateTime.Parse(line);
                            loadParticipant.addExSetSlot(newDate);
                        }
                        
                    }
                    if(lineNum == 6)
                    {
                        if(line == "#")
                        {
                            lineNum++;
                        }
                        else
                        {
                            DateTime newDate = DateTime.Parse(line);
                            loadParticipant.addPreSet(newDate);
                        }
                    }
                    if (lineNum == 7)
                    {
                        allParticipants.addParticipant(loadParticipant);
                        lineNum = 1;
                    }
                    
                
                // Use a tab to indent each line of the file.
                
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();*/
            //load function
            RespondersGB.Visible = false;
            AddPartcipantGB.Visible = false;
            updateDisplay();
        }

        private void allParticipantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateDisplay()
        {
            allParticipantListBox.Items.Clear();
            SelectedparticipantsListBox.Items.Clear();
            if (allParticipants.getParticipants().Count != 0)
            {
                foreach (Participant participant in allParticipants.getParticipants())
                {
                    allParticipantListBox.Items.Add(participant.getName()+ " \n " + participant.getEmail());
                }
            }
            if (selectedParticipants.getParticipants().Count != 0)
            {
                foreach (Participant participant in selectedParticipants.getParticipants())
                {
                    SelectedparticipantsListBox.Items.Add(participant.getName());
                }
            }
            ExSetListBox.Items.Clear();
            PreSetListBox.Items.Clear();
            List<Slot> ex = newParticipant.getExSet();
            List<Slot> pre = newParticipant.getPreSet();
            if (ex.Count != 0)
            {
                foreach (Slot slot in ex)
                {
                    ExSetListBox.Items.Add(slot.getStartTime());
                }
            }
            if (pre.Count != 0)
            {
                foreach (Slot slot in pre)
                {
                    PreSetListBox.Items.Add(slot.getStartTime());
                }
            }

        }

        private void SelectedparticipantsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moveparticipantsLeftBtn_Click(object sender, EventArgs e)
        {
            if (allParticipantListBox.SelectedItems.Count == 1)
            {
                int currentParticipantIndex = allParticipantListBox.SelectedIndex;
            Participant tempParticipant = allParticipants.getParticipants()[currentParticipantIndex];
            
                bool found = false;
                foreach(Participant participant in selectedParticipants.getParticipants())
                {
                    if (tempParticipant == participant)
                    {
                        found = true;
                    }
                    
                }
                if(found == false)
                {
                    newParticipant = new Participant();
                    selectedParticipants.addParticipant(tempParticipant);
                }
            }
            updateDisplay();
        }

        private void moveparticipantRightBtn_Click(object sender, EventArgs e)
        {
            if (allParticipantListBox.SelectedItems.Count == 1)
            {
                int currentParticipantIndex = SelectedparticipantsListBox.SelectedIndex;
                selectedParticipants.removeParticipant(currentParticipantIndex);
            }
            updateDisplay();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            newParticipant.setName(name);
            newParticipant.setEmail(email);
            newParticipant.setImportance(importance);
            bool found = false;
            foreach (Participant participant in allParticipants.getParticipants())
            {
                if (newParticipant == participant)
                {
                    found = true;
                }

            }
            if (found == false)
            {
                allParticipants.addParticipant(newParticipant);
            }
            AddPartcipantGB.Visible = false;
            ExSetListBox.Items.Clear();
            PreSetListBox.Items.Clear();
            updateDisplay();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker2.Value.AddMinutes(60);
        }

        private void AddPreSetBtn_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = dateTimePicker2.Value.Hour + ":00:00";
            DateTime newDate = DateTime.Parse(tempDate + " " + tempTime);

            bool found = false;
            //List<Slot> TempSlotList = newParticipant.getExSet
            foreach (Slot slot in newParticipant.getPreSet())
            {
                if (newDate == slot.getStartTime())
                {
                    found = true;
                }

            }
            foreach (Slot slot in newParticipant.getExSet())
            {

                if (newDate == slot.getStartTime())
                {
                    found = true;
                }

            }
            if (found == false)
            {
                newParticipant.addPreSet(newDate);
            }

            updateDisplay();
        }

        private void ExSetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExSetAddBtn_Click_1(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = dateTimePicker2.Value.Hour + ":00:00";
            DateTime newDate = DateTime.Parse(tempDate + " " + tempTime);

            bool found = false;
            //List<Slot> TempSlotList = newParticipant.getExSet
            foreach (Slot slot in newParticipant.getExSet())
            {

                if (newDate == slot.getStartTime())
                {
                    found = true;
                }

            }
            foreach (Slot slot in newParticipant.getPreSet())
            {

                if (newDate == slot.getStartTime())
                {
                    found = true;
                }

            }
            if (found == false)
            {
                newParticipant.addExSetSlot(newDate);
            }

            updateDisplay();
        }

        private void startSceduleBtn_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = dateTimePicker2.Value.Hour + ":00:00";
            DateTime newDate = DateTime.Parse(tempDate + " " + tempTime);

            bool found = false;
            //List<Slot> TempSlotList = newParticipant.getExSet
            foreach (Slot slot in newParticipant.getExSet())
            {
                if (newDate == slot.getStartTime())
                {
                    found = true;
                }

            }
            if (found == false)
            {
                newParticipant.addExSetSlot(newDate);
            }
            updateDisplay();
        }

        private void RemovePreSetBtn_Click(object sender, EventArgs e)
        {
            int currentPreIndex = PreSetListBox.SelectedIndex;
            if (PreSetListBox.SelectedItems.Count == 1)
            {
                newParticipant.removePreSetSlot(currentPreIndex);
            }
            updateDisplay();
        }

        private void RemoveExSetBtn_Click(object sender, EventArgs e)
        {
            int currentExIndex = ExSetListBox.SelectedIndex;
            if (ExSetListBox.SelectedItems.Count == 1)
            {
                newParticipant.removeExSetSlot(currentExIndex);
            }
            updateDisplay();
        }

        private void AddNewParticipant_Click(object sender, EventArgs e)
        {
            AddPartcipantGB.Visible = true;
        }

        private void NameInputBoxBtn_Click(object sender, EventArgs e)
        {
            this.name= Microsoft.VisualBasic.Interaction.InputBox("Enter the participants name here", "Name Input", "", -1, -1);
        }

        private void EmailInputBoxBtn_Click(object sender, EventArgs e)
        {
            this.email = Microsoft.VisualBasic.Interaction.InputBox("Enter the participants email here", "Email Input", "", -1, -1);

        }

        private void ImportanceInputBoxBtn_Click(object sender, EventArgs e)
        {
            bool inputOk = false;
            while (inputOk == false)
            {
                int x = 0;

                if (Int32.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter the participants email here", "Email Input", "", -1, -1), out x))
                {
                    importance = x;
                    inputOk = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Importance value inputted is not a number");
                }
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (selectedParticipants.getParticipants().Count != 0)
            {
                foreach (Participant participant in selectedParticipants.getParticipants())
                {
                    participantsResponseListBox.Items.Add(participant.getName());
                }
            }
            RespondersGB.Visible = true;
        }

        private void participantsResponseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CanceldDataRequestBtn_Click(object sender, EventArgs e)
        {
            RespondersGB.Visible = false;
        }
    }
}
