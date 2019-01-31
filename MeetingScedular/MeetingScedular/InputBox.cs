using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScedular
{
    class InputBox : TextBox
    {
        public event EventHandler<string> TextSubmitted;
        public bool SubmitOnEnter { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            //if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                //e.SuppressKeyPress = true;

                if (TextSubmitted != null)
                    TextSubmitted(this, this.Text);

                
            }


        }
    }
}
