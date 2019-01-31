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

//Allows for use of email
using System.Net;
using System.Net.Mail;


namespace MeetingScedular
{
    public partial class mainMenu : Form
    {
        // variables
        string name = "error";
        string email = "error";
        int importance = 5;
        private Participant newParticipant;
        //lists
        private ParticipantList allParticipants;
        private ParticipantList selectedParticipants;
        private List<Slot> MeetingScedule = new List<Slot>();
        private List<Slot> availableDates = new List<Slot>();
        private List<Slot> preferedDates = new List<Slot>();

        //EMAIL
        private ParticipantList participantsResponses;
        public mainMenu()
        {

            participantsResponses = new ParticipantList();

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
            Participant loadParticipant = new Participant();
            loadParticipant.setName("bob");
            loadParticipant.setEmail("mich143a@gmail.com");
            allParticipants.addParticipant(loadParticipant);
            loadParticipant = new Participant();
            loadParticipant.setName("alan");
            loadParticipant.setEmail("mich143a@gmail.com");
            allParticipants.addParticipant(loadParticipant);
            RespondersGB.Visible = false;
            AddPartcipantGB.Visible = false;
            availableDatesGB.Visible = false;
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
                    allParticipantListBox.Items.Add(participant.getName() + " : " + participant.getEmail());
                }
            }
            if (selectedParticipants.getParticipants().Count != 0)
            {
                foreach (Participant participant in selectedParticipants.getParticipants())
                {
                    SelectedparticipantsListBox.Items.Add(participant.getName() + " : " + participant.getEmail());
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
            participantsResponseListBox.Items.Clear();
            if (participantsResponses.getParticipants().Count != 0)
            {
                foreach (Participant participant in participantsResponses.getParticipants())
                {
                    participantsResponseListBox.Items.Add(participant.getName() + " : " + participant.getResponded());
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
                foreach (Participant participant in selectedParticipants.getParticipants())
                {
                    if (tempParticipant == participant)
                    {
                        found = true;
                    }

                }
                if (found == false)
                {
                    selectedParticipants.addParticipant(tempParticipant);
                }
            }
            updateDisplay();
        }

        private void moveparticipantRightBtn_Click(object sender, EventArgs e)
        {
            if (SelectedparticipantsListBox.SelectedItems.Count == 1)
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
                newParticipant = new Participant();

            }

            AddPartcipantGB.Visible = false;
            MainGB.Visible = true;
            ExSetListBox.Items.Clear();
            PreSetListBox.Items.Clear();
            updateDisplay();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            AddLowerTimePicker.Value.AddMinutes(60);
        }

        private void AddPreSetBtn_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = AddLowerTimePicker.Value.Hour + ":00:00";
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
            else
            {
                System.Windows.Forms.MessageBox.Show("This date and slot have already been added to either your exclusion or preffered list.");
            }


            updateDisplay();
        }

        private void ExSetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExSetAddBtn_Click_1(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = AddLowerTimePicker.Value.Hour + ":00:00";
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
            else
            {
                System.Windows.Forms.MessageBox.Show("This date and slot have already been added to either your exclusion or preffered list.");
            }

            updateDisplay();
        }

        private void startSceduleBtn_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string tempTime = AddLowerTimePicker.Value.Hour + ":00:00";
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
            MainGB.Visible = false;


        }

        private void NameInputBoxBtn_Click(object sender, EventArgs e)
        {
            this.name = Microsoft.VisualBasic.Interaction.InputBox("Enter the participants name here", "Name Input", "", -1, -1);
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
            foreach (Participant addparticipant in selectedParticipants.getParticipants())
            {
                participantsResponses.addParticipant(addparticipant);
            }
            foreach (Participant participant in participantsResponses.getParticipants())
            {
                if (participant.getResponded() == false)
                {
                    var fromAddress = new MailAddress("meetingschedularsystem@gmail.com", "From Meeting Scedular System");
                    var toAddress = new MailAddress(participant.getEmail(), participant.getName());
                    const string fromPassword = "Meetings91";
                    const string subject = "Respond with meeting constraints";
                    const string body = "You have been invited to a meeting please respond with your meeting your preferred and excluded dates and times.";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    
                }
            }

            System.Windows.Forms.MessageBox.Show("Participants have been informed via their email");
            MainGB.Visible = false;
            RespondersGB.Visible = true;
            updateDisplay();

        }

        private void participantsResponseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CanceldDataRequestBtn_Click(object sender, EventArgs e)
        {
            participantsResponses = new ParticipantList();
            MainGB.Visible = true;
            RespondersGB.Visible = false;
            updateDisplay();
        }




        // Email
        private void reminderBtn_Click(object sender, EventArgs e)
        {
            foreach (Participant participant in participantsResponses.getParticipants())
            {
                if(participant.getResponded() == false)
                {
                    var fromAddress = new MailAddress("meetingschedularsystem@gmail.com", "From Meeting Scedular System");
                    var toAddress = new MailAddress(participant.getEmail(), participant.getName());
                    const string fromPassword = "Meetings91";
                    const string subject = "Respond with meeting constraints";
                    const string body = "This is a reminder to respond to your meeting initiator with your preferred and excluded date sets for ";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    System.Windows.Forms.MessageBox.Show("Participants have been reminded via theiur email");
                }
            }

        }

        private void editparticipant_Click(object sender, EventArgs e)
        {
            if (participantsResponseListBox.SelectedItems.Count == 1)
            {
                int currentParticipantIndex = participantsResponseListBox.SelectedIndex;

                participantsResponses.setTrueParticipant(currentParticipantIndex);
            }
            updateDisplay();
        }

        private void addParticipantsCancelBtn_Click(object sender, EventArgs e)
        {
            newParticipant = new Participant();
            MainGB.Visible = true;
            AddPartcipantGB.Visible = false;
            updateDisplay();
        }

        private void RemoveParticipantBtn_Click(object sender, EventArgs e)
        {

            if (SelectedparticipantsListBox.SelectedItems.Count == 1)
            {
                int currentIndex = SelectedparticipantsListBox.SelectedIndex;
                Participant temp = selectedParticipants.getParticipant(currentIndex);
                foreach (Participant participant in allParticipants.getParticipants()) {
                    if(participant == temp)
                    {
                        //allParticipantListBox.removeParticipant();
                    }
                }
                selectedParticipants.removeParticipant(currentIndex);
            }
            if (allParticipantListBox.SelectedItems.Count == 1)
            {
                int currentIndex = allParticipantListBox.SelectedIndex;
                allParticipants.removeParticipant(currentIndex);
            }
            updateDisplay();
        }

        private void sceduleMettingBtn_Click(object sender, EventArgs e)
        {
            if (participantsResponses.getParticipants().Count != 0)
            {
                int index = 0;
                foreach (Participant participant in participantsResponses.getParticipants())
                {
                    if (participant.getResponded() == true)
                    {
                        index++;
                    }
                }

                if (index == participantsResponses.getParticipants().Count)
                {
                    RespondersGB.Visible = false;
                    availableDatesGB.Visible = true;
                    updateAvailableList();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void selectDateBtn_Click(object sender, EventArgs e)
        {
            /*if (availableDatesListBox.SelectedItems.Count == 1)
            {
                int currentParticipantIndex = availableDatesListBox.SelectedIndex;
                Slot tempSlot = availableDates.currentParticipantIndex];

                bool found = false;
                foreach (Participant participant in selectedParticipants.getParticipants())
                {
                    if (tempParticipant == participant)
                    {
                        found = true;
                    }

                }
                if (found == false)
                {
                    selectedParticipants.addParticipant(tempParticipant);
                }
            }*/
            updateDisplay();

        }

        private void updateAvailableList()
        {

            string tempDate = LowerDatePicker.Value.Year + "-" + LowerDatePicker.Value.Month + "-" + LowerDatePicker.Value.Day;
            string tempTime =LowerTimePicker.Value.Hour + ":00:00";
            DateTime newDate = DateTime.Parse(tempDate + " " + tempTime);

            string temDate = UpperDatePicker.Value.Year + "-" + UpperDatePicker.Value.Month + "-" + UpperDatePicker.Value.Day;
            string temTime = UpperTimePicker.Value.Hour + ":00:00";
            DateTime anewDate = DateTime.Parse(temDate + " " + temTime);

            while (newDate <= anewDate)
            {
                Slot newslot = new Slot(newDate);
                availableDates.Add(newslot);
                newDate = newDate.AddHours(1);


            }

            foreach (Slot slot in availableDates)
            {
                availableDatesListBox.Items.Add(slot.getStartTime());          
            }



        }

        private void UpperDatePicker_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableList();
        }

        private void UpperTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableList();
        }

        private void LowerDatePicker_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableList();
        }

        private void LowerTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableList();
        }
    }



     }
