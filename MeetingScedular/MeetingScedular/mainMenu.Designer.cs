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
            this.addparticipantBtn = new System.Windows.Forms.Button();
            this.editparticipantBtn = new System.Windows.Forms.Button();
            this.removeparticipantBtn = new System.Windows.Forms.Button();
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.startSceduleBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveparticipantsLeftBtn
            // 
            this.moveparticipantsLeftBtn.Location = new System.Drawing.Point(177, 282);
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
            this.allParticipantListBox.Location = new System.Drawing.Point(44, 272);
            this.allParticipantListBox.Name = "allParticipantListBox";
            this.allParticipantListBox.Size = new System.Drawing.Size(120, 95);
            this.allParticipantListBox.TabIndex = 1;
            this.allParticipantListBox.SelectedIndexChanged += new System.EventHandler(this.allParticipantListBox_SelectedIndexChanged);
            // 
            // SelectedparticipantsListBox
            // 
            this.SelectedparticipantsListBox.FormattingEnabled = true;
            this.SelectedparticipantsListBox.Location = new System.Drawing.Point(227, 272);
            this.SelectedparticipantsListBox.Name = "SelectedparticipantsListBox";
            this.SelectedparticipantsListBox.Size = new System.Drawing.Size(120, 95);
            this.SelectedparticipantsListBox.TabIndex = 2;
            this.SelectedparticipantsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedparticipantsListBox_SelectedIndexChanged);
            // 
            // moveparticipantRightBtn
            // 
            this.moveparticipantRightBtn.Location = new System.Drawing.Point(177, 331);
            this.moveparticipantRightBtn.Name = "moveparticipantRightBtn";
            this.moveparticipantRightBtn.Size = new System.Drawing.Size(44, 23);
            this.moveparticipantRightBtn.TabIndex = 3;
            this.moveparticipantRightBtn.Text = "<";
            this.moveparticipantRightBtn.UseVisualStyleBackColor = true;
            this.moveparticipantRightBtn.Click += new System.EventHandler(this.moveparticipantRightBtn_Click);
            // 
            // addparticipantBtn
            // 
            this.addparticipantBtn.Location = new System.Drawing.Point(373, 272);
            this.addparticipantBtn.Name = "addparticipantBtn";
            this.addparticipantBtn.Size = new System.Drawing.Size(57, 23);
            this.addparticipantBtn.TabIndex = 4;
            this.addparticipantBtn.Text = "Add";
            this.addparticipantBtn.UseVisualStyleBackColor = true;
            this.addparticipantBtn.Click += new System.EventHandler(this.addparticipantBtn_Click);
            // 
            // editparticipantBtn
            // 
            this.editparticipantBtn.Location = new System.Drawing.Point(373, 301);
            this.editparticipantBtn.Name = "editparticipantBtn";
            this.editparticipantBtn.Size = new System.Drawing.Size(57, 23);
            this.editparticipantBtn.TabIndex = 5;
            this.editparticipantBtn.Text = "Edit";
            this.editparticipantBtn.UseVisualStyleBackColor = true;
            // 
            // removeparticipantBtn
            // 
            this.removeparticipantBtn.Location = new System.Drawing.Point(373, 344);
            this.removeparticipantBtn.Name = "removeparticipantBtn";
            this.removeparticipantBtn.Size = new System.Drawing.Size(57, 23);
            this.removeparticipantBtn.TabIndex = 6;
            this.removeparticipantBtn.Text = "Remove";
            this.removeparticipantBtn.UseVisualStyleBackColor = true;
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Location = new System.Drawing.Point(303, 389);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(44, 23);
            this.CloseFormBtn.TabIndex = 7;
            this.CloseFormBtn.Text = "Close";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            // 
            // startSceduleBtn
            // 
            this.startSceduleBtn.Location = new System.Drawing.Point(386, 389);
            this.startSceduleBtn.Name = "startSceduleBtn";
            this.startSceduleBtn.Size = new System.Drawing.Size(44, 23);
            this.startSceduleBtn.TabIndex = 8;
            this.startSceduleBtn.Text = "Start";
            this.startSceduleBtn.UseVisualStyleBackColor = true;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(509, 191);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 9;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.startSceduleBtn);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.removeparticipantBtn);
            this.Controls.Add(this.editparticipantBtn);
            this.Controls.Add(this.addparticipantBtn);
            this.Controls.Add(this.moveparticipantRightBtn);
            this.Controls.Add(this.SelectedparticipantsListBox);
            this.Controls.Add(this.allParticipantListBox);
            this.Controls.Add(this.moveparticipantsLeftBtn);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveparticipantsLeftBtn;
        private System.Windows.Forms.ListBox allParticipantListBox;
        private System.Windows.Forms.ListBox SelectedparticipantsListBox;
        private System.Windows.Forms.Button moveparticipantRightBtn;
        private System.Windows.Forms.Button addparticipantBtn;
        private System.Windows.Forms.Button editparticipantBtn;
        private System.Windows.Forms.Button removeparticipantBtn;
        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.Button startSceduleBtn;
        private System.Windows.Forms.Button loadFileBtn;
    }
}

