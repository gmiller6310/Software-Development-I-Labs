namespace Lab4
{
    partial class lab4Form
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.admissionTestLabel = new System.Windows.Forms.Label();
            this.admissionTestTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.acceptedTotalLabel = new System.Windows.Forms.Label();
            this.rejectedTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(32, 21);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(198, 13);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "Enter High School Grade Point Average:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(236, 21);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 1;
            // 
            // admissionTestLabel
            // 
            this.admissionTestLabel.AutoSize = true;
            this.admissionTestLabel.Location = new System.Drawing.Point(90, 64);
            this.admissionTestLabel.Name = "admissionTestLabel";
            this.admissionTestLabel.Size = new System.Drawing.Size(140, 13);
            this.admissionTestLabel.TabIndex = 2;
            this.admissionTestLabel.Text = "Enter Admission Test Score:";
            // 
            // admissionTestTextBox
            // 
            this.admissionTestTextBox.Location = new System.Drawing.Point(236, 64);
            this.admissionTestTextBox.Name = "admissionTestTextBox";
            this.admissionTestTextBox.Size = new System.Drawing.Size(100, 20);
            this.admissionTestTextBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(129, 102);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(101, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Acceptance Result:";
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOutputLabel.Location = new System.Drawing.Point(236, 101);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.resultOutputLabel.TabIndex = 5;
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(3, 149);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(87, 13);
            this.acceptedLabel.TabIndex = 6;
            this.acceptedLabel.Text = "Accepted Count:";
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(202, 149);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(84, 13);
            this.rejectedLabel.TabIndex = 7;
            this.rejectedLabel.Text = "Rejected Count:";
            // 
            // acceptedTotalLabel
            // 
            this.acceptedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedTotalLabel.Location = new System.Drawing.Point(96, 148);
            this.acceptedTotalLabel.Name = "acceptedTotalLabel";
            this.acceptedTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.acceptedTotalLabel.TabIndex = 8;
            // 
            // rejectedTotalLabel
            // 
            this.rejectedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedTotalLabel.Location = new System.Drawing.Point(292, 148);
            this.rejectedTotalLabel.Name = "rejectedTotalLabel";
            this.rejectedTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.rejectedTotalLabel.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(155, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lab4Form
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 227);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rejectedTotalLabel);
            this.Controls.Add(this.acceptedTotalLabel);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.admissionTestTextBox);
            this.Controls.Add(this.admissionTestLabel);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.gpaLabel);
            this.Name = "lab4Form";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.Label admissionTestLabel;
        private System.Windows.Forms.TextBox admissionTestTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultOutputLabel;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label acceptedTotalLabel;
        private System.Windows.Forms.Label rejectedTotalLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

