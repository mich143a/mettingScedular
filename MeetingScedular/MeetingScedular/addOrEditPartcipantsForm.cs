using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MeetingScedular
{
    public partial class addOrEditparticipantsForm : Form
    {
        string name;
        string email;
        int importance;
        Participant newParticipant = new Participant();
        public addOrEditparticipantsForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            newParticipant.setName(name);
            newParticipant.setEmail(email);
            newParticipant.setImportance(importance);

            this.Close();
        }

        private void inputBox1_TextSubmitted(object sender, string e)
        {
            this.name = e;
        }

        private void ExSetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateDisplay()
        {
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

        private void addOrEditparticipantsForm_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void EmailInputBox_TextChanged(object sender, EventArgs e)
        {
        }
        //needs scrubing
        private void EmailInputBox_TextSubmitted(object sender, string e)
        {
            email = e;
        }
        //done
        private void ImportanceInputBox_TextSubmitted(object sender, string e)
        {
            int x = 0;

            if (Int32.TryParse(e, out x))
            {
                importance = x;
            }
            else
            {
                ImportanceInputBox.Clear();
                System.Windows.Forms.MessageBox.Show("Importance value inputted is not a number");
            }


        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker2.Value.AddMinutes(60);
        }

        private void ExSetAddBtn_Click(object sender, EventArgs e)
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

        private void RemoveExSetBtn_Click(object sender, EventArgs e)
        {
            int currentExIndex = ExSetListBox.SelectedIndex;
            if (ExSetListBox.SelectedItems.Count == 1)
            {
                newParticipant.removeExSetSlot(currentExIndex);
            }
            updateDisplay();
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
            if (found == false)
            {
                newParticipant.addPreSet(newDate);
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

    }
}
