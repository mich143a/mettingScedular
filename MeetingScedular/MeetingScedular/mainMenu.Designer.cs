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
            this.movePartcipantsLeftBtn = new System.Windows.Forms.Button();
            this.allParticipantListBox = new System.Windows.Forms.ListBox();
            this.SelectedPartcipantsListBox = new System.Windows.Forms.ListBox();
            this.movePartcipantRightBtn = new System.Windows.Forms.Button();
            this.addPartcipantBtn = new System.Windows.Forms.Button();
            this.editPartcipantBtn = new System.Windows.Forms.Button();
            this.removePartcipantBtn = new System.Windows.Forms.Button();
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.startSceduleBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movePartcipantsLeftBtn
            // 
            this.movePartcipantsLeftBtn.Location = new System.Drawing.Point(177, 282);
            this.movePartcipantsLeftBtn.Name = "movePartcipantsLeftBtn";
            this.movePartcipantsLeftBtn.Size = new System.Drawing.Size(44, 23);
            this.movePartcipantsLeftBtn.TabIndex = 0;
            this.movePartcipantsLeftBtn.Text = ">";
            this.movePartcipantsLeftBtn.UseVisualStyleBackColor = true;
            // 
            // allParticipantListBox
            // 
            this.allParticipantListBox.FormattingEnabled = true;
            this.allParticipantListBox.Location = new System.Drawing.Point(44, 272);
            this.allParticipantListBox.Name = "allParticipantListBox";
            this.allParticipantListBox.Size = new System.Drawing.Size(120, 95);
            this.allParticipantListBox.TabIndex = 1;
            // 
            // SelectedPartcipantsListBox
            // 
            this.SelectedPartcipantsListBox.FormattingEnabled = true;
            this.SelectedPartcipantsListBox.Location = new System.Drawing.Point(227, 272);
            this.SelectedPartcipantsListBox.Name = "SelectedPartcipantsListBox";
            this.SelectedPartcipantsListBox.Size = new System.Drawing.Size(120, 95);
            this.SelectedPartcipantsListBox.TabIndex = 2;
            // 
            // movePartcipantRightBtn
            // 
            this.movePartcipantRightBtn.Location = new System.Drawing.Point(177, 331);
            this.movePartcipantRightBtn.Name = "movePartcipantRightBtn";
            this.movePartcipantRightBtn.Size = new System.Drawing.Size(44, 23);
            this.movePartcipantRightBtn.TabIndex = 3;
            this.movePartcipantRightBtn.Text = "<";
            this.movePartcipantRightBtn.UseVisualStyleBackColor = true;
            // 
            // addPartcipantBtn
            // 
            this.addPartcipantBtn.Location = new System.Drawing.Point(373, 272);
            this.addPartcipantBtn.Name = "addPartcipantBtn";
            this.addPartcipantBtn.Size = new System.Drawing.Size(57, 23);
            this.addPartcipantBtn.TabIndex = 4;
            this.addPartcipantBtn.Text = "Add";
            this.addPartcipantBtn.UseVisualStyleBackColor = true;
            // 
            // editPartcipantBtn
            // 
            this.editPartcipantBtn.Location = new System.Drawing.Point(373, 301);
            this.editPartcipantBtn.Name = "editPartcipantBtn";
            this.editPartcipantBtn.Size = new System.Drawing.Size(57, 23);
            this.editPartcipantBtn.TabIndex = 5;
            this.editPartcipantBtn.Text = "Edit";
            this.editPartcipantBtn.UseVisualStyleBackColor = true;
            // 
            // removePartcipantBtn
            // 
            this.removePartcipantBtn.Location = new System.Drawing.Point(373, 344);
            this.removePartcipantBtn.Name = "removePartcipantBtn";
            this.removePartcipantBtn.Size = new System.Drawing.Size(57, 23);
            this.removePartcipantBtn.TabIndex = 6;
            this.removePartcipantBtn.Text = "Remove";
            this.removePartcipantBtn.UseVisualStyleBackColor = true;
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
            this.loadFileBtn.Location = new System.Drawing.Point(514, 301);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.startSceduleBtn);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.removePartcipantBtn);
            this.Controls.Add(this.editPartcipantBtn);
            this.Controls.Add(this.addPartcipantBtn);
            this.Controls.Add(this.movePartcipantRightBtn);
            this.Controls.Add(this.SelectedPartcipantsListBox);
            this.Controls.Add(this.allParticipantListBox);
            this.Controls.Add(this.movePartcipantsLeftBtn);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button movePartcipantsLeftBtn;
        private System.Windows.Forms.ListBox allParticipantListBox;
        private System.Windows.Forms.ListBox SelectedPartcipantsListBox;
        private System.Windows.Forms.Button movePartcipantRightBtn;
        private System.Windows.Forms.Button addPartcipantBtn;
        private System.Windows.Forms.Button editPartcipantBtn;
        private System.Windows.Forms.Button removePartcipantBtn;
        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.Button startSceduleBtn;
        private System.Windows.Forms.Button loadFileBtn;
    }
}

