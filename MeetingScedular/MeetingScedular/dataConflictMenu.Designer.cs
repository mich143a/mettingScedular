namespace MeetingScedular
{
    partial class dataConflictMenu
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
            this.extendDateRangeBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.particpantsRemoveListBox = new System.Windows.Forms.ListBox();
            this.ModifyPartcipantBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extendDateRangeBtn
            // 
            this.extendDateRangeBtn.Location = new System.Drawing.Point(13, 28);
            this.extendDateRangeBtn.Name = "extendDateRangeBtn";
            this.extendDateRangeBtn.Size = new System.Drawing.Size(122, 23);
            this.extendDateRangeBtn.TabIndex = 0;
            this.extendDateRangeBtn.Text = "Extend Date Range";
            this.extendDateRangeBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 57);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(122, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove Partcipant";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // particpantsRemoveListBox
            // 
            this.particpantsRemoveListBox.FormattingEnabled = true;
            this.particpantsRemoveListBox.Location = new System.Drawing.Point(174, 28);
            this.particpantsRemoveListBox.Name = "particpantsRemoveListBox";
            this.particpantsRemoveListBox.Size = new System.Drawing.Size(120, 95);
            this.particpantsRemoveListBox.TabIndex = 2;
            // 
            // ModifyPartcipantBtn
            // 
            this.ModifyPartcipantBtn.Location = new System.Drawing.Point(12, 86);
            this.ModifyPartcipantBtn.Name = "ModifyPartcipantBtn";
            this.ModifyPartcipantBtn.Size = new System.Drawing.Size(122, 23);
            this.ModifyPartcipantBtn.TabIndex = 3;
            this.ModifyPartcipantBtn.Text = "Modify Partcipant";
            this.ModifyPartcipantBtn.UseVisualStyleBackColor = true;
            // 
            // dataConflictMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyPartcipantBtn);
            this.Controls.Add(this.particpantsRemoveListBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.extendDateRangeBtn);
            this.Name = "dataConflictMenu";
            this.Text = "Data Conflict Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extendDateRangeBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ListBox particpantsRemoveListBox;
        private System.Windows.Forms.Button ModifyPartcipantBtn;
    }
}