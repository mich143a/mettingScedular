namespace MeetingScedular
{
    partial class mainMenu
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
            this.moveparticipantsLeftBtn = new System.Windows.Forms.Button();
            this.allParticipantListBox = new System.Windows.Forms.ListBox();
            this.SelectedparticipantsListBox = new System.Windows.Forms.ListBox();
            this.moveparticipantRightBtn = new System.Windows.Forms.Button();
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.AddPartcipantGB = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.RemovePreSetBtn = new System.Windows.Forms.Button();
            this.AddPreSetBtn = new System.Windows.Forms.Button();
            this.RemoveExSetBtn = new System.Windows.Forms.Button();
            this.ExSetAddBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PreSetListBox = new System.Windows.Forms.ListBox();
            this.ExSetListBox = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.AddNewParticipant = new System.Windows.Forms.Button();
            this.NameInputBoxBtn = new System.Windows.Forms.Button();
            this.EmailInputBoxBtn = new System.Windows.Forms.Button();
            this.ImportanceInputBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MainGB = new System.Windows.Forms.GroupBox();
            this.RespondersGB = new System.Windows.Forms.GroupBox();
            this.sceduleMettingBtn = new System.Windows.Forms.Button();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.editparticipant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countdownDisplayBtn = new System.Windows.Forms.Button();
            this.CanceldDataRequestBtn = new System.Windows.Forms.Button();
            this.participantsResponseListBox = new System.Windows.Forms.ListBox();
            this.AddPartcipantGB.SuspendLayout();
            this.MainGB.SuspendLayout();
            this.RespondersGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveparticipantsLeftBtn
            // 
            this.moveparticipantsLeftBtn.Location = new System.Drawing.Point(139, 48);
            this.moveparticipantsLeftBtn.Name = "moveparticipantsLeftBtn";
            this.moveparticipantsLeftBtn.Size = new System.Drawing.Size(44, 23);
            this.moveparticipantsLeftBtn.TabIndex = 0;
            this.moveparticipantsLeftBtn.Text = ">";
            this.moveparticipantsLeftBtn.UseVisualStyleBackColor = true;
            this.moveparticipantsLeftBtn.Click += new System.EventHandler(this.moveparticipantsLeftBtn_Click);
            // 
            // allParticipantListBox
            // 
            this.allParticipantListBox.FormattingEnabled = true;
            this.allParticipantListBox.Location = new System.Drawing.Point(6, 19);
            this.allParticipantListBox.Name = "allParticipantListBox";
            this.allParticipantListBox.Size = new System.Drawing.Size(120, 108);
            this.allParticipantListBox.TabIndex = 1;
            this.allParticipantListBox.SelectedIndexChanged += new System.EventHandler(this.allParticipantListBox_SelectedIndexChanged);
            // 
            // SelectedparticipantsListBox
            // 
            this.SelectedparticipantsListBox.FormattingEnabled = true;
            this.SelectedparticipantsListBox.Location = new System.Drawing.Point(189, 19);
            this.SelectedparticipantsListBox.Name = "SelectedparticipantsListBox";
            this.SelectedparticipantsListBox.Size = new System.Drawing.Size(120, 108);
            this.SelectedparticipantsListBox.TabIndex = 2;
            this.SelectedparticipantsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedparticipantsListBox_SelectedIndexChanged);
            // 
            // moveparticipantRightBtn
            // 
            this.moveparticipantRightBtn.Location = new System.Drawing.Point(139, 77);
            this.moveparticipantRightBtn.Name = "moveparticipantRightBtn";
            this.moveparticipantRightBtn.Size = new System.Drawing.Size(44, 23);
            this.moveparticipantRightBtn.TabIndex = 3;
            this.moveparticipantRightBtn.Text = "<";
            this.moveparticipantRightBtn.UseVisualStyleBackColor = true;
            this.moveparticipantRightBtn.Click += new System.EventHandler(this.moveparticipantRightBtn_Click);
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Location = new System.Drawing.Point(335, 19);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseFormBtn.TabIndex = 7;
            this.CloseFormBtn.Text = "Close";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(335, 77);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 9;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // AddPartcipantGB
            // 
            this.AddPartcipantGB.Controls.Add(this.label1);
            this.AddPartcipantGB.Controls.Add(this.ImportanceInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.EmailInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.NameInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.dateTimePicker2);
            this.AddPartcipantGB.Controls.Add(this.RemovePreSetBtn);
            this.AddPartcipantGB.Controls.Add(this.AddPreSetBtn);
            this.AddPartcipantGB.Controls.Add(this.RemoveExSetBtn);
            this.AddPartcipantGB.Controls.Add(this.ExSetAddBtn);
            this.AddPartcipantGB.Controls.Add(this.dateTimePicker1);
            this.AddPartcipantGB.Controls.Add(this.PreSetListBox);
            this.AddPartcipantGB.Controls.Add(this.ExSetListBox);
            this.AddPartcipantGB.Controls.Add(this.submitBtn);
            this.AddPartcipantGB.Location = new System.Drawing.Point(440, 12);
            this.AddPartcipantGB.Name = "AddPartcipantGB";
            this.AddPartcipantGB.Size = new System.Drawing.Size(380, 235);
            this.AddPartcipantGB.TabIndex = 10;
            this.AddPartcipantGB.TabStop = false;
            this.AddPartcipantGB.Text = "Add Participants";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:00";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(52, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.Value = new System.DateTime(2019, 1, 31, 1, 0, 0, 0);
            // 
            // RemovePreSetBtn
            // 
            this.RemovePreSetBtn.Location = new System.Drawing.Point(294, 167);
            this.RemovePreSetBtn.Name = "RemovePreSetBtn";
            this.RemovePreSetBtn.Size = new System.Drawing.Size(75, 23);
            this.RemovePreSetBtn.TabIndex = 26;
            this.RemovePreSetBtn.Text = "Remove";
            this.RemovePreSetBtn.UseVisualStyleBackColor = true;
            this.RemovePreSetBtn.Click += new System.EventHandler(this.RemovePreSetBtn_Click);
            // 
            // AddPreSetBtn
            // 
            this.AddPreSetBtn.Location = new System.Drawing.Point(294, 138);
            this.AddPreSetBtn.Name = "AddPreSetBtn";
            this.AddPreSetBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPreSetBtn.TabIndex = 25;
            this.AddPreSetBtn.Text = "Add";
            this.AddPreSetBtn.UseVisualStyleBackColor = true;
            this.AddPreSetBtn.Click += new System.EventHandler(this.AddPreSetBtn_Click);
            // 
            // RemoveExSetBtn
            // 
            this.RemoveExSetBtn.Location = new System.Drawing.Point(213, 167);
            this.RemoveExSetBtn.Name = "RemoveExSetBtn";
            this.RemoveExSetBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveExSetBtn.TabIndex = 24;
            this.RemoveExSetBtn.Text = "Remove";
            this.RemoveExSetBtn.UseVisualStyleBackColor = true;
            this.RemoveExSetBtn.Click += new System.EventHandler(this.RemoveExSetBtn_Click);
            // 
            // ExSetAddBtn
            // 
            this.ExSetAddBtn.Location = new System.Drawing.Point(213, 137);
            this.ExSetAddBtn.Name = "ExSetAddBtn";
            this.ExSetAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ExSetAddBtn.TabIndex = 23;
            this.ExSetAddBtn.Text = "Add";
            this.ExSetAddBtn.UseVisualStyleBackColor = true;
            this.ExSetAddBtn.Click += new System.EventHandler(this.ExSetAddBtn_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // PreSetListBox
            // 
            this.PreSetListBox.FormattingEnabled = true;
            this.PreSetListBox.Location = new System.Drawing.Point(294, 27);
            this.PreSetListBox.Name = "PreSetListBox";
            this.PreSetListBox.Size = new System.Drawing.Size(75, 95);
            this.PreSetListBox.TabIndex = 21;
            // 
            // ExSetListBox
            // 
            this.ExSetListBox.FormattingEnabled = true;
            this.ExSetListBox.Location = new System.Drawing.Point(213, 27);
            this.ExSetListBox.Name = "ExSetListBox";
            this.ExSetListBox.Size = new System.Drawing.Size(75, 95);
            this.ExSetListBox.TabIndex = 20;
            this.ExSetListBox.SelectedIndexChanged += new System.EventHandler(this.ExSetListBox_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(294, 196);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddNewParticipant
            // 
            this.AddNewParticipant.Location = new System.Drawing.Point(335, 48);
            this.AddNewParticipant.Name = "AddNewParticipant";
            this.AddNewParticipant.Size = new System.Drawing.Size(75, 23);
            this.AddNewParticipant.TabIndex = 11;
            this.AddNewParticipant.Text = "Add";
            this.AddNewParticipant.UseVisualStyleBackColor = true;
            this.AddNewParticipant.Click += new System.EventHandler(this.AddNewParticipant_Click);
            // 
            // NameInputBoxBtn
            // 
            this.NameInputBoxBtn.Location = new System.Drawing.Point(6, 27);
            this.NameInputBoxBtn.Name = "NameInputBoxBtn";
            this.NameInputBoxBtn.Size = new System.Drawing.Size(75, 23);
            this.NameInputBoxBtn.TabIndex = 30;
            this.NameInputBoxBtn.Text = "Name";
            this.NameInputBoxBtn.UseVisualStyleBackColor = true;
            this.NameInputBoxBtn.Click += new System.EventHandler(this.NameInputBoxBtn_Click);
            // 
            // EmailInputBoxBtn
            // 
            this.EmailInputBoxBtn.Location = new System.Drawing.Point(6, 56);
            this.EmailInputBoxBtn.Name = "EmailInputBoxBtn";
            this.EmailInputBoxBtn.Size = new System.Drawing.Size(75, 23);
            this.EmailInputBoxBtn.TabIndex = 31;
            this.EmailInputBoxBtn.Text = "Email";
            this.EmailInputBoxBtn.UseVisualStyleBackColor = true;
            this.EmailInputBoxBtn.Click += new System.EventHandler(this.EmailInputBoxBtn_Click);
            // 
            // ImportanceInputBoxBtn
            // 
            this.ImportanceInputBoxBtn.Location = new System.Drawing.Point(6, 85);
            this.ImportanceInputBoxBtn.Name = "ImportanceInputBoxBtn";
            this.ImportanceInputBoxBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportanceInputBoxBtn.TabIndex = 32;
            this.ImportanceInputBoxBtn.Text = "Importance";
            this.ImportanceInputBoxBtn.UseVisualStyleBackColor = true;
            this.ImportanceInputBoxBtn.Click += new System.EventHandler(this.ImportanceInputBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Extra Display Vars";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(335, 106);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainGB
            // 
            this.MainGB.Controls.Add(this.SelectedparticipantsListBox);
            this.MainGB.Controls.Add(this.StartBtn);
            this.MainGB.Controls.Add(this.moveparticipantsLeftBtn);
            this.MainGB.Controls.Add(this.AddNewParticipant);
            this.MainGB.Controls.Add(this.allParticipantListBox);
            this.MainGB.Controls.Add(this.moveparticipantRightBtn);
            this.MainGB.Controls.Add(this.loadFileBtn);
            this.MainGB.Controls.Add(this.CloseFormBtn);
            this.MainGB.Location = new System.Drawing.Point(12, 12);
            this.MainGB.Name = "MainGB";
            this.MainGB.Size = new System.Drawing.Size(422, 139);
            this.MainGB.TabIndex = 13;
            this.MainGB.TabStop = false;
            this.MainGB.Text = "Main";
            // 
            // RespondersGB
            // 
            this.RespondersGB.Controls.Add(this.sceduleMettingBtn);
            this.RespondersGB.Controls.Add(this.reminderBtn);
            this.RespondersGB.Controls.Add(this.editparticipant);
            this.RespondersGB.Controls.Add(this.label2);
            this.RespondersGB.Controls.Add(this.countdownDisplayBtn);
            this.RespondersGB.Controls.Add(this.CanceldDataRequestBtn);
            this.RespondersGB.Controls.Add(this.participantsResponseListBox);
            this.RespondersGB.Location = new System.Drawing.Point(18, 253);
            this.RespondersGB.Name = "RespondersGB";
            this.RespondersGB.Size = new System.Drawing.Size(416, 237);
            this.RespondersGB.TabIndex = 14;
            this.RespondersGB.TabStop = false;
            this.RespondersGB.Text = "Responders";
            // 
            // sceduleMettingBtn
            // 
            this.sceduleMettingBtn.Location = new System.Drawing.Point(283, 145);
            this.sceduleMettingBtn.Name = "sceduleMettingBtn";
            this.sceduleMettingBtn.Size = new System.Drawing.Size(85, 51);
            this.sceduleMettingBtn.TabIndex = 17;
            this.sceduleMettingBtn.Text = "Scedule Meeting";
            this.sceduleMettingBtn.UseVisualStyleBackColor = true;
            // 
            // reminderBtn
            // 
            this.reminderBtn.Location = new System.Drawing.Point(283, 48);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(85, 51);
            this.reminderBtn.TabIndex = 16;
            this.reminderBtn.Text = "Remind Unresponsive Patrcipants";
            this.reminderBtn.UseVisualStyleBackColor = true;
            // 
            // editparticipant
            // 
            this.editparticipant.Location = new System.Drawing.Point(283, 105);
            this.editparticipant.Name = "editparticipant";
            this.editparticipant.Size = new System.Drawing.Size(85, 34);
            this.editparticipant.TabIndex = 15;
            this.editparticipant.Text = "Edit/Update participants";
            this.editparticipant.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Response Timer";
            // 
            // countdownDisplayBtn
            // 
            this.countdownDisplayBtn.Location = new System.Drawing.Point(283, 19);
            this.countdownDisplayBtn.Name = "countdownDisplayBtn";
            this.countdownDisplayBtn.Size = new System.Drawing.Size(85, 23);
            this.countdownDisplayBtn.TabIndex = 13;
            this.countdownDisplayBtn.TabStop = false;
            this.countdownDisplayBtn.Text = "5:00";
            this.countdownDisplayBtn.UseVisualStyleBackColor = true;
            // 
            // CanceldDataRequestBtn
            // 
            this.CanceldDataRequestBtn.Location = new System.Drawing.Point(19, 173);
            this.CanceldDataRequestBtn.Name = "CanceldDataRequestBtn";
            this.CanceldDataRequestBtn.Size = new System.Drawing.Size(75, 23);
            this.CanceldDataRequestBtn.TabIndex = 12;
            this.CanceldDataRequestBtn.Text = "Cancel";
            this.CanceldDataRequestBtn.UseVisualStyleBackColor = true;
            this.CanceldDataRequestBtn.Click += new System.EventHandler(this.CanceldDataRequestBtn_Click);
            // 
            // participantsResponseListBox
            // 
            this.participantsResponseListBox.FormattingEnabled = true;
            this.participantsResponseListBox.HorizontalScrollbar = true;
            this.participantsResponseListBox.Location = new System.Drawing.Point(19, 19);
            this.participantsResponseListBox.Name = "participantsResponseListBox";
            this.participantsResponseListBox.Size = new System.Drawing.Size(158, 147);
            this.participantsResponseListBox.TabIndex = 11;
            this.participantsResponseListBox.SelectedIndexChanged += new System.EventHandler(this.participantsResponseListBox_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 661);
            this.Controls.Add(this.RespondersGB);
            this.Controls.Add(this.MainGB);
            this.Controls.Add(this.AddPartcipantGB);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddPartcipantGB.ResumeLayout(false);
            this.AddPartcipantGB.PerformLayout();
            this.MainGB.ResumeLayout(false);
            this.RespondersGB.ResumeLayout(false);
            this.RespondersGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveparticipantsLeftBtn;
        private System.Windows.Forms.ListBox allParticipantListBox;
        private System.Windows.Forms.ListBox SelectedparticipantsListBox;
        private System.Windows.Forms.Button moveparticipantRightBtn;
        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.GroupBox AddPartcipantGB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button RemovePreSetBtn;
        private System.Windows.Forms.Button AddPreSetBtn;
        private System.Windows.Forms.Button RemoveExSetBtn;
        private System.Windows.Forms.Button ExSetAddBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox PreSetListBox;
        private System.Windows.Forms.ListBox ExSetListBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button AddNewParticipant;
        private System.Windows.Forms.Button NameInputBoxBtn;
        private System.Windows.Forms.Button EmailInputBoxBtn;
        private System.Windows.Forms.Button ImportanceInputBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox MainGB;
        private System.Windows.Forms.GroupBox RespondersGB;
        private System.Windows.Forms.Button sceduleMettingBtn;
        private System.Windows.Forms.Button reminderBtn;
        private System.Windows.Forms.Button editparticipant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button countdownDisplayBtn;
        private System.Windows.Forms.Button CanceldDataRequestBtn;
        private System.Windows.Forms.ListBox participantsResponseListBox;
    }
}

