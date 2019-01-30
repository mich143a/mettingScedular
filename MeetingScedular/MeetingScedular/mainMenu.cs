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
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load function
        }

        private void allParticipantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateDisplay()
        {
            /*lstActiveTickets.Items.Clear();
            List<Ticket> tickets = activeTickets.GetTickets();
            foreach (Ticket ticket in tickets)
            {
                lstActiveTickets.Items.Add("#" + ticket.GetHashCode() + ": " + ticket.IsPaid().ToString() + ": Bay " + ticket.GetParkingSpace().GetId().ToString());
            }
            */
        }
    }
}
