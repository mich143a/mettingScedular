namespace MeetingScedular
{
    partial class responseMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countdownDisplayBtn = new System.Windows.Forms.Button();
            this.CanceldDataRequestBtn = new System.Windows.Forms.Button();
            this.participantsResponseListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editparticipant = new System.Windows.Forms.Button();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.sceduleMettingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countdownDisplayBtn
            // 
            this.countdownDisplayBtn.Location = new System.Drawing.Point(276, 16);
            this.countdownDisplayBtn.Name = "countdownDisplayBtn";
            this.countdownDisplayBtn.Size = new System.Drawing.Size(85, 23);
            this.countdownDisplayBtn.TabIndex = 6;
            this.countdownDisplayBtn.TabStop = false;
            this.countdownDisplayBtn.Text = "5:00";
            this.countdownDisplayBtn.UseVisualStyleBackColor = true;
            // 
            // CanceldDataRequestBtn
            // 
            this.CanceldDataRequestBtn.Location = new System.Drawing.Point(12, 170);
            this.CanceldDataRequestBtn.Name = "CanceldDataRequestBtn";
            this.CanceldDataRequestBtn.Size = new System.Drawing.Size(75, 23);
            this.CanceldDataRequestBtn.TabIndex = 5;
            this.CanceldDataRequestBtn.Text = "Cancel";
            this.CanceldDataRequestBtn.UseVisualStyleBackColor = true;
            // 
            // participantsResponseListBox
            // 
            this.participantsResponseListBox.FormattingEnabled = true;
            this.participantsResponseListBox.HorizontalScrollbar = true;
            this.participantsResponseListBox.Location = new System.Drawing.Point(12, 16);
            this.participantsResponseListBox.Name = "participantsResponseListBox";
            this.participantsResponseListBox.Size = new System.Drawing.Size(158, 147);
            this.participantsResponseListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Response Timer";
            // 
            // editparticipant
            // 
            this.editparticipant.Location = new System.Drawing.Point(276, 102);
            this.editparticipant.Name = "editparticipant";
            this.editparticipant.Size = new System.Drawing.Size(85, 34);
            this.editparticipant.TabIndex = 8;
            this.editparticipant.Text = "Edit/Update participants";
            this.editparticipant.UseVisualStyleBackColor = true;
            // 
            // reminderBtn
            // 
            this.reminderBtn.Location = new System.Drawing.Point(276, 45);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(85, 51);
            this.reminderBtn.TabIndex = 9;
            this.reminderBtn.Text = "Remind Unresponsive Patrcipants";
            this.reminderBtn.UseVisualStyleBackColor = true;
            // 
            // sceduleMettingBtn
            // 
            this.sceduleMettingBtn.Location = new System.Drawing.Point(276, 142);
            this.sceduleMettingBtn.Name = "sceduleMettingBtn";
            this.sceduleMettingBtn.Size = new System.Drawing.Size(85, 51);
            this.sceduleMettingBtn.TabIndex = 10;
            this.sceduleMettingBtn.Text = "Scedule Meeting";
            this.sceduleMettingBtn.UseVisualStyleBackColor = true;
            // 
            // responseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 235);
            this.Controls.Add(this.sceduleMettingBtn);
            this.Controls.Add(this.reminderBtn);
            this.Controls.Add(this.editparticipant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countdownDisplayBtn);
            this.Controls.Add(this.CanceldDataRequestBtn);
            this.Controls.Add(this.participantsResponseListBox);
            this.Name = "responseMenu";
            this.Text = "Response Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button countdownDisplayBtn;
        private System.Windows.Forms.Button CanceldDataRequestBtn;
        private System.Windows.Forms.ListBox participantsResponseListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editparticipant;
        private System.Windows.Forms.Button reminderBtn;
        private System.Windows.Forms.Button sceduleMettingBtn;
    }
}