namespace Lab7
{
    partial class lab7
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
            this.monthNumberLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lookUpButton = new System.Windows.Forms.Button();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.spanishRadioButton = new System.Windows.Forms.RadioButton();
            this.italianRadioButton = new System.Windows.Forms.RadioButton();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthNumberLabel
            // 
            this.monthNumberLabel.AutoSize = true;
            this.monthNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.monthNumberLabel.Name = "monthNumberLabel";
            this.monthNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.monthNumberLabel.TabIndex = 0;
            this.monthNumberLabel.Text = "Month #";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(67, 13);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 1;
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.italianRadioButton);
            this.languageGroupBox.Controls.Add(this.spanishRadioButton);
            this.languageGroupBox.Controls.Add(this.englishRadioButton);
            this.languageGroupBox.Location = new System.Drawing.Point(16, 51);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(151, 96);
            this.languageGroupBox.TabIndex = 2;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Choose Language";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(16, 162);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(151, 23);
            this.outputLabel.TabIndex = 3;
            // 
            // lookUpButton
            // 
            this.lookUpButton.Location = new System.Drawing.Point(53, 203);
            this.lookUpButton.Name = "lookUpButton";
            this.lookUpButton.Size = new System.Drawing.Size(75, 23);
            this.lookUpButton.TabIndex = 4;
            this.lookUpButton.Text = "Look Up";
            this.lookUpButton.UseVisualStyleBackColor = true;
            this.lookUpButton.Click += new System.EventHandler(this.lookUpButton_Click);
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(6, 19);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.englishRadioButton.TabIndex = 0;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // spanishRadioButton
            // 
            this.spanishRadioButton.AutoSize = true;
            this.spanishRadioButton.Location = new System.Drawing.Point(6, 42);
            this.spanishRadioButton.Name = "spanishRadioButton";
            this.spanishRadioButton.Size = new System.Drawing.Size(63, 17);
            this.spanishRadioButton.TabIndex = 5;
            this.spanishRadioButton.TabStop = true;
            this.spanishRadioButton.Text = "Spanish";
            this.spanishRadioButton.UseVisualStyleBackColor = true;
            // 
            // italianRadioButton
            // 
            this.italianRadioButton.AutoSize = true;
            this.italianRadioButton.Location = new System.Drawing.Point(6, 65);
            this.italianRadioButton.Name = "italianRadioButton";
            this.italianRadioButton.Size = new System.Drawing.Size(53, 17);
            this.italianRadioButton.TabIndex = 6;
            this.italianRadioButton.TabStop = true;
            this.italianRadioButton.Text = "Italian";
            this.italianRadioButton.UseVisualStyleBackColor = true;
            // 
            // lab7
            // 
            this.AcceptButton = this.lookUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 239);
            this.Controls.Add(this.lookUpButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.monthNumberLabel);
            this.Name = "lab7";
            this.Text = "Lab 7";
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthNumberLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.GroupBox languageGroupBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button lookUpButton;
        private System.Windows.Forms.RadioButton italianRadioButton;
        private System.Windows.Forms.RadioButton spanishRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
    }
}

