namespace MeetingScedular
{
    partial class availableDatesMenu
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
            this.availableDatesListBox = new System.Windows.Forms.ListBox();
            this.currentDateRangeBtn = new System.Windows.Forms.Button();
            this.currentDateRangeLbl = new System.Windows.Forms.Label();
            this.selectDateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableDatesListBox
            // 
            this.availableDatesListBox.FormattingEnabled = true;
            this.availableDatesListBox.Location = new System.Drawing.Point(12, 12);
            this.availableDatesListBox.Name = "availableDatesListBox";
            this.availableDatesListBox.Size = new System.Drawing.Size(120, 277);
            this.availableDatesListBox.TabIndex = 0;
            // 
            // currentDateRangeBtn
            // 
            this.currentDateRangeBtn.Location = new System.Drawing.Point(138, 28);
            this.currentDateRangeBtn.Name = "currentDateRangeBtn";
            this.currentDateRangeBtn.Size = new System.Drawing.Size(102, 37);
            this.currentDateRangeBtn.TabIndex = 1;
            this.currentDateRangeBtn.Text = "1st May - 2nd June";
            this.currentDateRangeBtn.UseVisualStyleBackColor = true;
            // 
            // currentDateRangeLbl
            // 
            this.currentDateRangeLbl.AutoSize = true;
            this.currentDateRangeLbl.Location = new System.Drawing.Point(138, 12);
            this.currentDateRangeLbl.Name = "currentDateRangeLbl";
            this.currentDateRangeLbl.Size = new System.Drawing.Size(102, 13);
            this.currentDateRangeLbl.TabIndex = 2;
            this.currentDateRangeLbl.Text = "Current Date Range";
            // 
            // selectDateBtn
            // 
            this.selectDateBtn.Location = new System.Drawing.Point(138, 252);
            this.selectDateBtn.Name = "selectDateBtn";
            this.selectDateBtn.Size = new System.Drawing.Size(102, 37);
            this.selectDateBtn.TabIndex = 3;
            this.selectDateBtn.Text = "I CHOose you";
            this.selectDateBtn.UseVisualStyleBackColor = true;
            // 
            // availableDatesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 310);
            this.Controls.Add(this.selectDateBtn);
            this.Controls.Add(this.currentDateRangeLbl);
            this.Controls.Add(this.currentDateRangeBtn);
            this.Controls.Add(this.availableDatesListBox);
            this.Name = "availableDatesMenu";
            this.Text = "availableDatesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableDatesListBox;
        private System.Windows.Forms.Button currentDateRangeBtn;
        private System.Windows.Forms.Label currentDateRangeLbl;
        private System.Windows.Forms.Button selectDateBtn;
    }
}