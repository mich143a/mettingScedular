namespace MeetingScedular
{
    partial class addOrEditparticipantsForm
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.EmailTag = new System.Windows.Forms.Label();
            this.ExSetListBox = new System.Windows.Forms.ListBox();
            this.PreSetListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ExSetAddBtn = new System.Windows.Forms.Button();
            this.RemoveExSetBtn = new System.Windows.Forms.Button();
            this.RemovePreSetBtn = new System.Windows.Forms.Button();
            this.AddPreSetBtn = new System.Windows.Forms.Button();
            this.ImportanceLbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ImportanceInputBox = new MeetingScedular.InputBox();
            this.EmailInputBox = new MeetingScedular.InputBox();
            this.inputBox1 = new MeetingScedular.InputBox();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 29);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Location = new System.Drawing.Point(538, 294);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // EmailTag
            // 
            this.EmailTag.AutoSize = true;
            this.EmailTag.Location = new System.Drawing.Point(15, 63);
            this.EmailTag.Name = "EmailTag";
            this.EmailTag.Size = new System.Drawing.Size(32, 13);
            this.EmailTag.TabIndex = 3;
            this.EmailTag.Text = "Email";
            // 
            // ExSetListBox
            // 
            this.ExSetListBox.FormattingEnabled = true;
            this.ExSetListBox.Location = new System.Drawing.Point(337, 26);
            this.ExSetListBox.Name = "ExSetListBox";
            this.ExSetListBox.Size = new System.Drawing.Size(103, 95);
            this.ExSetListBox.TabIndex = 5;
            this.ExSetListBox.SelectedIndexChanged += new System.EventHandler(this.ExSetListBox_SelectedIndexChanged);
            // 
            // PreSetListBox
            // 
            this.PreSetListBox.FormattingEnabled = true;
            this.PreSetListBox.Location = new System.Drawing.Point(473, 26);
            this.PreSetListBox.Name = "PreSetListBox";
            this.PreSetListBox.Size = new System.Drawing.Size(120, 95);
            this.PreSetListBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ExSetAddBtn
            // 
            this.ExSetAddBtn.Location = new System.Drawing.Point(337, 137);
            this.ExSetAddBtn.Name = "ExSetAddBtn";
            this.ExSetAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ExSetAddBtn.TabIndex = 8;
            this.ExSetAddBtn.Text = "Add";
            this.ExSetAddBtn.UseVisualStyleBackColor = true;
            this.ExSetAddBtn.Click += new System.EventHandler(this.ExSetAddBtn_Click);
            // 
            // RemoveExSetBtn
            // 
            this.RemoveExSetBtn.Location = new System.Drawing.Point(337, 167);
            this.RemoveExSetBtn.Name = "RemoveExSetBtn";
            this.RemoveExSetBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveExSetBtn.TabIndex = 9;
            this.RemoveExSetBtn.Text = "Remove";
            this.RemoveExSetBtn.UseVisualStyleBackColor = true;
            this.RemoveExSetBtn.Click += new System.EventHandler(this.RemoveExSetBtn_Click);
            // 
            // RemovePreSetBtn
            // 
            this.RemovePreSetBtn.Location = new System.Drawing.Point(473, 167);
            this.RemovePreSetBtn.Name = "RemovePreSetBtn";
            this.RemovePreSetBtn.Size = new System.Drawing.Size(75, 23);
            this.RemovePreSetBtn.TabIndex = 11;
            this.RemovePreSetBtn.Text = "Remove";
            this.RemovePreSetBtn.UseVisualStyleBackColor = true;
            this.RemovePreSetBtn.Click += new System.EventHandler(this.RemovePreSetBtn_Click);
            // 
            // AddPreSetBtn
            // 
            this.AddPreSetBtn.Location = new System.Drawing.Point(473, 137);
            this.AddPreSetBtn.Name = "AddPreSetBtn";
            this.AddPreSetBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPreSetBtn.TabIndex = 10;
            this.AddPreSetBtn.Text = "Add";
            this.AddPreSetBtn.UseVisualStyleBackColor = true;
            this.AddPreSetBtn.Click += new System.EventHandler(this.AddPreSetBtn_Click);
            // 
            // ImportanceLbl
            // 
            this.ImportanceLbl.AutoSize = true;
            this.ImportanceLbl.Location = new System.Drawing.Point(13, 101);
            this.ImportanceLbl.Name = "ImportanceLbl";
            this.ImportanceLbl.Size = new System.Drawing.Size(60, 13);
            this.ImportanceLbl.TabIndex = 13;
            this.ImportanceLbl.Text = "Importance";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:00";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(58, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2019, 1, 31, 1, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // ImportanceInputBox
            // 
            this.ImportanceInputBox.Location = new System.Drawing.Point(80, 101);
            this.ImportanceInputBox.Name = "ImportanceInputBox";
            this.ImportanceInputBox.Size = new System.Drawing.Size(240, 20);
            this.ImportanceInputBox.SubmitOnEnter = true;
            this.ImportanceInputBox.TabIndex = 12;
            this.ImportanceInputBox.TextSubmitted += new System.EventHandler<string>(this.ImportanceInputBox_TextSubmitted);
            // 
            // EmailInputBox
            // 
            this.EmailInputBox.Location = new System.Drawing.Point(80, 60);
            this.EmailInputBox.Name = "EmailInputBox";
            this.EmailInputBox.Size = new System.Drawing.Size(240, 20);
            this.EmailInputBox.SubmitOnEnter = true;
            this.EmailInputBox.TabIndex = 4;
            this.EmailInputBox.TextSubmitted += new System.EventHandler<string>(this.EmailInputBox_TextSubmitted);
            this.EmailInputBox.TextChanged += new System.EventHandler(this.EmailInputBox_TextChanged);
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(80, 26);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(240, 20);
            this.inputBox1.SubmitOnEnter = true;
            this.inputBox1.TabIndex = 2;
            this.inputBox1.TextSubmitted += new System.EventHandler<string>(this.inputBox1_TextSubmitted);
            // 
            // addOrEditparticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 329);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ImportanceLbl);
            this.Controls.Add(this.ImportanceInputBox);
            this.Controls.Add(this.RemovePreSetBtn);
            this.Controls.Add(this.AddPreSetBtn);
            this.Controls.Add(this.RemoveExSetBtn);
            this.Controls.Add(this.ExSetAddBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PreSetListBox);
            this.Controls.Add(this.ExSetListBox);
            this.Controls.Add(this.EmailInputBox);
            this.Controls.Add(this.EmailTag);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.NameLbl);
            this.Name = "addOrEditparticipantsForm";
            this.Text = "Add or Edit participants Menu";
            this.Load += new System.EventHandler(this.addOrEditparticipantsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button submitBtn;
        private InputBox inputBox1;
        private System.Windows.Forms.Label EmailTag;
        private InputBox EmailInputBox;
        private System.Windows.Forms.ListBox ExSetListBox;
        private System.Windows.Forms.ListBox PreSetListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ExSetAddBtn;
        private System.Windows.Forms.Button RemoveExSetBtn;
        private System.Windows.Forms.Button RemovePreSetBtn;
        private System.Windows.Forms.Button AddPreSetBtn;
        private InputBox ImportanceInputBox;
        private System.Windows.Forms.Label ImportanceLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}