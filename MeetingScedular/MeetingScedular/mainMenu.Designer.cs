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
            this.label1 = new System.Windows.Forms.Label();
            this.ImportanceInputBoxBtn = new System.Windows.Forms.Button();
            this.EmailInputBoxBtn = new System.Windows.Forms.Button();
            this.NameInputBoxBtn = new System.Windows.Forms.Button();
            this.AddLowerTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemovePreSetBtn = new System.Windows.Forms.Button();
            this.AddPreSetBtn = new System.Windows.Forms.Button();
            this.RemoveExSetBtn = new System.Windows.Forms.Button();
            this.ExSetAddBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PreSetListBox = new System.Windows.Forms.ListBox();
            this.ExSetListBox = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.AddNewParticipant = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MainGB = new System.Windows.Forms.GroupBox();
            this.RespondersGB = new System.Windows.Forms.GroupBox();
            this.sceduleMettingBtn = new System.Windows.Forms.Button();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.editparticipant = new System.Windows.Forms.Button();
            this.CanceldDataRequestBtn = new System.Windows.Forms.Button();
            this.participantsResponseListBox = new System.Windows.Forms.ListBox();
            this.selectDateBtn = new System.Windows.Forms.Button();
            this.currentDateRangeLbl = new System.Windows.Forms.Label();
            this.availableDatesListBox = new System.Windows.Forms.ListBox();
            this.addParticipantsCancelBtn = new System.Windows.Forms.Button();
            this.RemoveParticipantBtn = new System.Windows.Forms.Button();
            this.availableDatesGB = new System.Windows.Forms.GroupBox();
            this.LowerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpperDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UpperTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LowerTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preferedDatesListBox = new System.Windows.Forms.ListBox();
            this.AddPartcipantGB.SuspendLayout();
            this.MainGB.SuspendLayout();
            this.RespondersGB.SuspendLayout();
            this.availableDatesGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.allParticipantListBox.Size = new System.Drawing.Size(120, 134);
            this.allParticipantListBox.TabIndex = 1;
            this.allParticipantListBox.SelectedIndexChanged += new System.EventHandler(this.allParticipantListBox_SelectedIndexChanged);
            // 
            // SelectedparticipantsListBox
            // 
            this.SelectedparticipantsListBox.FormattingEnabled = true;
            this.SelectedparticipantsListBox.Location = new System.Drawing.Point(189, 19);
            this.SelectedparticipantsListBox.Name = "SelectedparticipantsListBox";
            this.SelectedparticipantsListBox.Size = new System.Drawing.Size(120, 134);
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
            this.loadFileBtn.Location = new System.Drawing.Point(335, 106);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 9;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // AddPartcipantGB
            // 
            this.AddPartcipantGB.Controls.Add(this.addParticipantsCancelBtn);
            this.AddPartcipantGB.Controls.Add(this.AddLowerTimePicker);
            this.AddPartcipantGB.Controls.Add(this.label1);
            this.AddPartcipantGB.Controls.Add(this.ImportanceInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.EmailInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.NameInputBoxBtn);
            this.AddPartcipantGB.Controls.Add(this.RemovePreSetBtn);
            this.AddPartcipantGB.Controls.Add(this.AddPreSetBtn);
            this.AddPartcipantGB.Controls.Add(this.RemoveExSetBtn);
            this.AddPartcipantGB.Controls.Add(this.ExSetAddBtn);
            this.AddPartcipantGB.Controls.Add(this.dateTimePicker1);
            this.AddPartcipantGB.Controls.Add(this.PreSetListBox);
            this.AddPartcipantGB.Controls.Add(this.ExSetListBox);
            this.AddPartcipantGB.Controls.Add(this.submitBtn);
            this.AddPartcipantGB.Location = new System.Drawing.Point(467, 12);
            this.AddPartcipantGB.Name = "AddPartcipantGB";
            this.AddPartcipantGB.Size = new System.Drawing.Size(380, 235);
            this.AddPartcipantGB.TabIndex = 10;
            this.AddPartcipantGB.TabStop = false;
            this.AddPartcipantGB.Text = "Add Participants";
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
            // AddLowerTimePicker
            // 
            this.AddLowerTimePicker.CustomFormat = "HH:00";
            this.AddLowerTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddLowerTimePicker.Location = new System.Drawing.Point(6, 141);
            this.AddLowerTimePicker.Name = "AddLowerTimePicker";
            this.AddLowerTimePicker.ShowUpDown = true;
            this.AddLowerTimePicker.Size = new System.Drawing.Size(52, 20);
            this.AddLowerTimePicker.TabIndex = 29;
            this.AddLowerTimePicker.Value = new System.DateTime(2019, 1, 31, 1, 0, 0, 0);
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
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(335, 135);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 12;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainGB
            // 
            this.MainGB.Controls.Add(this.RemoveParticipantBtn);
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
            this.MainGB.Size = new System.Drawing.Size(422, 169);
            this.MainGB.TabIndex = 13;
            this.MainGB.TabStop = false;
            this.MainGB.Text = "Main";
            // 
            // RespondersGB
            // 
            this.RespondersGB.Controls.Add(this.sceduleMettingBtn);
            this.RespondersGB.Controls.Add(this.reminderBtn);
            this.RespondersGB.Controls.Add(this.editparticipant);
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
            this.sceduleMettingBtn.Location = new System.Drawing.Point(183, 116);
            this.sceduleMettingBtn.Name = "sceduleMettingBtn";
            this.sceduleMettingBtn.Size = new System.Drawing.Size(85, 51);
            this.sceduleMettingBtn.TabIndex = 17;
            this.sceduleMettingBtn.Text = "Scedule Meeting";
            this.sceduleMettingBtn.UseVisualStyleBackColor = true;
            this.sceduleMettingBtn.Click += new System.EventHandler(this.sceduleMettingBtn_Click);
            // 
            // reminderBtn
            // 
            this.reminderBtn.Location = new System.Drawing.Point(183, 19);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(85, 51);
            this.reminderBtn.TabIndex = 16;
            this.reminderBtn.Text = "Remind Unresponsive Participants";
            this.reminderBtn.UseVisualStyleBackColor = true;
            this.reminderBtn.Click += new System.EventHandler(this.reminderBtn_Click);
            // 
            // editparticipant
            // 
            this.editparticipant.Location = new System.Drawing.Point(183, 76);
            this.editparticipant.Name = "editparticipant";
            this.editparticipant.Size = new System.Drawing.Size(85, 34);
            this.editparticipant.TabIndex = 15;
            this.editparticipant.Text = "Edit/Update participants";
            this.editparticipant.UseVisualStyleBackColor = true;
            this.editparticipant.Click += new System.EventHandler(this.editparticipant_Click);
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
            // selectDateBtn
            // 
            this.selectDateBtn.Location = new System.Drawing.Point(162, 257);
            this.selectDateBtn.Name = "selectDateBtn";
            this.selectDateBtn.Size = new System.Drawing.Size(102, 37);
            this.selectDateBtn.TabIndex = 18;
            this.selectDateBtn.Text = "I CHOose you";
            this.selectDateBtn.UseVisualStyleBackColor = true;
            this.selectDateBtn.Click += new System.EventHandler(this.selectDateBtn_Click);
            // 
            // currentDateRangeLbl
            // 
            this.currentDateRangeLbl.AutoSize = true;
            this.currentDateRangeLbl.Location = new System.Drawing.Point(132, -47);
            this.currentDateRangeLbl.Name = "currentDateRangeLbl";
            this.currentDateRangeLbl.Size = new System.Drawing.Size(102, 13);
            this.currentDateRangeLbl.TabIndex = 17;
            this.currentDateRangeLbl.Text = "Current Date Range";
            // 
            // availableDatesListBox
            // 
            this.availableDatesListBox.FormattingEnabled = true;
            this.availableDatesListBox.Location = new System.Drawing.Point(6, 19);
            this.availableDatesListBox.Name = "availableDatesListBox";
            this.availableDatesListBox.Size = new System.Drawing.Size(120, 95);
            this.availableDatesListBox.TabIndex = 15;
            // 
            // addParticipantsCancelBtn
            // 
            this.addParticipantsCancelBtn.Location = new System.Drawing.Point(6, 196);
            this.addParticipantsCancelBtn.Name = "addParticipantsCancelBtn";
            this.addParticipantsCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.addParticipantsCancelBtn.TabIndex = 34;
            this.addParticipantsCancelBtn.Text = "Cancel";
            this.addParticipantsCancelBtn.UseVisualStyleBackColor = true;
            this.addParticipantsCancelBtn.Click += new System.EventHandler(this.addParticipantsCancelBtn_Click);
            // 
            // RemoveParticipantBtn
            // 
            this.RemoveParticipantBtn.Location = new System.Drawing.Point(335, 77);
            this.RemoveParticipantBtn.Name = "RemoveParticipantBtn";
            this.RemoveParticipantBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveParticipantBtn.TabIndex = 25;
            this.RemoveParticipantBtn.Text = "Remove";
            this.RemoveParticipantBtn.UseVisualStyleBackColor = true;
            this.RemoveParticipantBtn.Click += new System.EventHandler(this.RemoveParticipantBtn_Click);
            // 
            // availableDatesGB
            // 
            this.availableDatesGB.Controls.Add(this.preferedDatesListBox);
            this.availableDatesGB.Controls.Add(this.groupBox2);
            this.availableDatesGB.Controls.Add(this.availableDatesListBox);
            this.availableDatesGB.Controls.Add(this.groupBox1);
            this.availableDatesGB.Controls.Add(this.selectDateBtn);
            this.availableDatesGB.Controls.Add(this.currentDateRangeLbl);
            this.availableDatesGB.Location = new System.Drawing.Point(473, 253);
            this.availableDatesGB.Name = "availableDatesGB";
            this.availableDatesGB.Size = new System.Drawing.Size(374, 316);
            this.availableDatesGB.TabIndex = 19;
            this.availableDatesGB.TabStop = false;
            this.availableDatesGB.Text = "Available Dates";
            // 
            // LowerDatePicker
            // 
            this.LowerDatePicker.Location = new System.Drawing.Point(6, 39);
            this.LowerDatePicker.Name = "LowerDatePicker";
            this.LowerDatePicker.Size = new System.Drawing.Size(188, 20);
            this.LowerDatePicker.TabIndex = 23;
            this.LowerDatePicker.ValueChanged += new System.EventHandler(this.LowerDatePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LowerTimePicker);
            this.groupBox1.Controls.Add(this.LowerDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(162, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lower Date Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpperDatePicker);
            this.groupBox2.Controls.Add(this.UpperTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(162, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upper Date Range";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // UpperDatePicker
            // 
            this.UpperDatePicker.Location = new System.Drawing.Point(6, 39);
            this.UpperDatePicker.Name = "UpperDatePicker";
            this.UpperDatePicker.Size = new System.Drawing.Size(188, 20);
            this.UpperDatePicker.TabIndex = 23;
            this.UpperDatePicker.ValueChanged += new System.EventHandler(this.UpperDatePicker_ValueChanged);
            // 
            // UpperTimePicker
            // 
            this.UpperTimePicker.CustomFormat = "HH:00";
            this.UpperTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UpperTimePicker.Location = new System.Drawing.Point(6, 71);
            this.UpperTimePicker.Name = "UpperTimePicker";
            this.UpperTimePicker.ShowUpDown = true;
            this.UpperTimePicker.Size = new System.Drawing.Size(52, 20);
            this.UpperTimePicker.TabIndex = 29;
            this.UpperTimePicker.Value = new System.DateTime(2019, 1, 31, 1, 0, 0, 0);
            this.UpperTimePicker.ValueChanged += new System.EventHandler(this.UpperTimePicker_ValueChanged);
            // 
            // LowerTimePicker
            // 
            this.LowerTimePicker.CustomFormat = "HH:00";
            this.LowerTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LowerTimePicker.Location = new System.Drawing.Point(6, 65);
            this.LowerTimePicker.Name = "LowerTimePicker";
            this.LowerTimePicker.ShowUpDown = true;
            this.LowerTimePicker.Size = new System.Drawing.Size(52, 20);
            this.LowerTimePicker.TabIndex = 35;
            this.LowerTimePicker.Value = new System.DateTime(2019, 1, 31, 1, 0, 0, 0);
            this.LowerTimePicker.ValueChanged += new System.EventHandler(this.LowerTimePicker_ValueChanged);
            // 
            // preferedDatesListBox
            // 
            this.preferedDatesListBox.FormattingEnabled = true;
            this.preferedDatesListBox.Location = new System.Drawing.Point(6, 126);
            this.preferedDatesListBox.Name = "preferedDatesListBox";
            this.preferedDatesListBox.Size = new System.Drawing.Size(120, 95);
            this.preferedDatesListBox.TabIndex = 34;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 661);
            this.Controls.Add(this.availableDatesGB);
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
            this.availableDatesGB.ResumeLayout(false);
            this.availableDatesGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker AddLowerTimePicker;
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
        private System.Windows.Forms.Button CanceldDataRequestBtn;
        private System.Windows.Forms.ListBox participantsResponseListBox;
        private System.Windows.Forms.Button selectDateBtn;
        private System.Windows.Forms.Label currentDateRangeLbl;
        private System.Windows.Forms.ListBox availableDatesListBox;
        private System.Windows.Forms.Button addParticipantsCancelBtn;
        private System.Windows.Forms.Button RemoveParticipantBtn;
        private System.Windows.Forms.GroupBox availableDatesGB;
        private System.Windows.Forms.DateTimePicker LowerDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker UpperDatePicker;
        private System.Windows.Forms.DateTimePicker UpperTimePicker;
        private System.Windows.Forms.DateTimePicker LowerTimePicker;
        private System.Windows.Forms.ListBox preferedDatesListBox;
    }
}

