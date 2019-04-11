namespace Lab9
{
    partial class DateForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.updateMonthButton = new System.Windows.Forms.Button();
            this.updateDayButton = new System.Windows.Forms.Button();
            this.updateYearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(51, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(90, 13);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(122, 17);
            this.dateOutputLabel.TabIndex = 1;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(31, 49);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(42, 79);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(39, 113);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(77, 46);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(78, 79);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(78, 113);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // updateMonthButton
            // 
            this.updateMonthButton.Location = new System.Drawing.Point(185, 46);
            this.updateMonthButton.Name = "updateMonthButton";
            this.updateMonthButton.Size = new System.Drawing.Size(89, 22);
            this.updateMonthButton.TabIndex = 8;
            this.updateMonthButton.Text = "Update Month";
            this.updateMonthButton.UseVisualStyleBackColor = true;
            this.updateMonthButton.Click += new System.EventHandler(this.updateMonthButton_Click);
            // 
            // updateDayButton
            // 
            this.updateDayButton.Location = new System.Drawing.Point(185, 76);
            this.updateDayButton.Name = "updateDayButton";
            this.updateDayButton.Size = new System.Drawing.Size(87, 24);
            this.updateDayButton.TabIndex = 9;
            this.updateDayButton.Text = "Update Day";
            this.updateDayButton.UseVisualStyleBackColor = true;
            this.updateDayButton.Click += new System.EventHandler(this.updateDayButton_Click);
            // 
            // updateYearButton
            // 
            this.updateYearButton.Location = new System.Drawing.Point(185, 111);
            this.updateYearButton.Name = "updateYearButton";
            this.updateYearButton.Size = new System.Drawing.Size(87, 23);
            this.updateYearButton.TabIndex = 10;
            this.updateYearButton.Text = "Update Year";
            this.updateYearButton.UseVisualStyleBackColor = true;
            this.updateYearButton.Click += new System.EventHandler(this.updateYearButton_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.updateYearButton);
            this.Controls.Add(this.updateDayButton);
            this.Controls.Add(this.updateMonthButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "DateForm";
            this.Text = "Lab9";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button updateMonthButton;
        private System.Windows.Forms.Button updateDayButton;
        private System.Windows.Forms.Button updateYearButton;
    }
}

