namespace MeetingScedular
{
    partial class constraintsVoilatedMenu
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
            this.violateListBox = new System.Windows.Forms.ListBox();
            this.vioEditBtn = new System.Windows.Forms.Button();
            this.vioBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // violateListBox
            // 
            this.violateListBox.FormattingEnabled = true;
            this.violateListBox.Location = new System.Drawing.Point(13, 13);
            this.violateListBox.Name = "violateListBox";
            this.violateListBox.Size = new System.Drawing.Size(120, 95);
            this.violateListBox.TabIndex = 0;
            // 
            // vioEditBtn
            // 
            this.vioEditBtn.Location = new System.Drawing.Point(140, 13);
            this.vioEditBtn.Name = "vioEditBtn";
            this.vioEditBtn.Size = new System.Drawing.Size(75, 23);
            this.vioEditBtn.TabIndex = 1;
            this.vioEditBtn.Text = "Edit/Change";
            this.vioEditBtn.UseVisualStyleBackColor = true;
            // 
            // vioBackBtn
            // 
            this.vioBackBtn.Location = new System.Drawing.Point(140, 84);
            this.vioBackBtn.Name = "vioBackBtn";
            this.vioBackBtn.Size = new System.Drawing.Size(75, 23);
            this.vioBackBtn.TabIndex = 2;
            this.vioBackBtn.Text = "Back";
            this.vioBackBtn.UseVisualStyleBackColor = true;
            // 
            // constraintsVoilatedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 140);
            this.Controls.Add(this.vioBackBtn);
            this.Controls.Add(this.vioEditBtn);
            this.Controls.Add(this.violateListBox);
            this.Name = "constraintsVoilatedMenu";
            this.Text = "Constraints Voilated Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox violateListBox;
        private System.Windows.Forms.Button vioEditBtn;
        private System.Windows.Forms.Button vioBackBtn;
    }
}