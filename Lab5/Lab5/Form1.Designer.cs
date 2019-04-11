namespace Lab5
{
    partial class Form1
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.whileRadioButton = new System.Windows.Forms.RadioButton();
            this.forRadioButton = new System.Windows.Forms.RadioButton();
            this.doWhileRadioButton = new System.Windows.Forms.RadioButton();
            this.runLoopButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.loopListBox = new System.Windows.Forms.ListBox();
            this.radioButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(12, 25);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromTextBox.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(12, 48);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(12, 64);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 20);
            this.toTextBox.TabIndex = 4;
            // 
            // radioButtonGroupBox
            // 
            this.radioButtonGroupBox.Controls.Add(this.doWhileRadioButton);
            this.radioButtonGroupBox.Controls.Add(this.forRadioButton);
            this.radioButtonGroupBox.Controls.Add(this.whileRadioButton);
            this.radioButtonGroupBox.Location = new System.Drawing.Point(12, 110);
            this.radioButtonGroupBox.Name = "radioButtonGroupBox";
            this.radioButtonGroupBox.Size = new System.Drawing.Size(113, 94);
            this.radioButtonGroupBox.TabIndex = 5;
            this.radioButtonGroupBox.TabStop = false;
            this.radioButtonGroupBox.Text = "Loop Using:";
            // 
            // whileRadioButton
            // 
            this.whileRadioButton.AutoSize = true;
            this.whileRadioButton.Checked = true;
            this.whileRadioButton.Location = new System.Drawing.Point(7, 20);
            this.whileRadioButton.Name = "whileRadioButton";
            this.whileRadioButton.Size = new System.Drawing.Size(49, 17);
            this.whileRadioButton.TabIndex = 0;
            this.whileRadioButton.TabStop = true;
            this.whileRadioButton.Text = "while";
            this.whileRadioButton.UseVisualStyleBackColor = true;
            // 
            // forRadioButton
            // 
            this.forRadioButton.AutoSize = true;
            this.forRadioButton.Location = new System.Drawing.Point(7, 43);
            this.forRadioButton.Name = "forRadioButton";
            this.forRadioButton.Size = new System.Drawing.Size(37, 17);
            this.forRadioButton.TabIndex = 1;
            this.forRadioButton.Text = "for";
            this.forRadioButton.UseVisualStyleBackColor = true;
            // 
            // doWhileRadioButton
            // 
            this.doWhileRadioButton.AutoSize = true;
            this.doWhileRadioButton.Location = new System.Drawing.Point(7, 66);
            this.doWhileRadioButton.Name = "doWhileRadioButton";
            this.doWhileRadioButton.Size = new System.Drawing.Size(64, 17);
            this.doWhileRadioButton.TabIndex = 2;
            this.doWhileRadioButton.Text = "do-while";
            this.doWhileRadioButton.UseVisualStyleBackColor = true;
            // 
            // runLoopButton
            // 
            this.runLoopButton.Location = new System.Drawing.Point(12, 219);
            this.runLoopButton.Name = "runLoopButton";
            this.runLoopButton.Size = new System.Drawing.Size(75, 23);
            this.runLoopButton.TabIndex = 6;
            this.runLoopButton.Text = "Run Loop";
            this.runLoopButton.UseVisualStyleBackColor = true;
            this.runLoopButton.Click += new System.EventHandler(this.runLoopButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(12, 257);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(75, 23);
            this.clearListButton.TabIndex = 7;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // loopListBox
            // 
            this.loopListBox.FormattingEnabled = true;
            this.loopListBox.Location = new System.Drawing.Point(148, 12);
            this.loopListBox.Name = "loopListBox";
            this.loopListBox.Size = new System.Drawing.Size(120, 277);
            this.loopListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.runLoopButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.loopListBox);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.runLoopButton);
            this.Controls.Add(this.radioButtonGroupBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLabel);
            this.Name = "Form1";
            this.Text = "Lab 5";
            this.radioButtonGroupBox.ResumeLayout(false);
            this.radioButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.GroupBox radioButtonGroupBox;
        private System.Windows.Forms.RadioButton doWhileRadioButton;
        private System.Windows.Forms.RadioButton forRadioButton;
        private System.Windows.Forms.RadioButton whileRadioButton;
        private System.Windows.Forms.Button runLoopButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.ListBox loopListBox;
    }
}

