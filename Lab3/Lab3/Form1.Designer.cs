namespace Lab3
{
    partial class lab3Form
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
            this.priceOfMealLabel = new System.Windows.Forms.Label();
            this.mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.smallTipLabel = new System.Windows.Forms.Label();
            this.smallTipOutputLabel = new System.Windows.Forms.Label();
            this.mediumTipLabel = new System.Windows.Forms.Label();
            this.mediumTipOutputLabel = new System.Windows.Forms.Label();
            this.largeTipLabel = new System.Windows.Forms.Label();
            this.largeTipOutputLabel = new System.Windows.Forms.Label();
            this.calculateTipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceOfMealLabel
            // 
            this.priceOfMealLabel.AutoSize = true;
            this.priceOfMealLabel.Location = new System.Drawing.Point(54, 15);
            this.priceOfMealLabel.Name = "priceOfMealLabel";
            this.priceOfMealLabel.Size = new System.Drawing.Size(98, 13);
            this.priceOfMealLabel.TabIndex = 0;
            this.priceOfMealLabel.Text = "Enter price of meal:";
            // 
            // mealPriceTextBox
            // 
            this.mealPriceTextBox.Location = new System.Drawing.Point(158, 12);
            this.mealPriceTextBox.Name = "mealPriceTextBox";
            this.mealPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.mealPriceTextBox.TabIndex = 1;
            // 
            // smallTipLabel
            // 
            this.smallTipLabel.AutoSize = true;
            this.smallTipLabel.Location = new System.Drawing.Point(125, 48);
            this.smallTipLabel.Name = "smallTipLabel";
            this.smallTipLabel.Size = new System.Drawing.Size(27, 13);
            this.smallTipLabel.TabIndex = 2;
            this.smallTipLabel.Text = "15%";
            // 
            // smallTipOutputLabel
            // 
            this.smallTipOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallTipOutputLabel.Location = new System.Drawing.Point(158, 47);
            this.smallTipOutputLabel.Name = "smallTipOutputLabel";
            this.smallTipOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.smallTipOutputLabel.TabIndex = 3;
            // 
            // mediumTipLabel
            // 
            this.mediumTipLabel.AutoSize = true;
            this.mediumTipLabel.Location = new System.Drawing.Point(125, 93);
            this.mediumTipLabel.Name = "mediumTipLabel";
            this.mediumTipLabel.Size = new System.Drawing.Size(27, 13);
            this.mediumTipLabel.TabIndex = 4;
            this.mediumTipLabel.Text = "18%";
            // 
            // mediumTipOutputLabel
            // 
            this.mediumTipOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumTipOutputLabel.Location = new System.Drawing.Point(158, 92);
            this.mediumTipOutputLabel.Name = "mediumTipOutputLabel";
            this.mediumTipOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.mediumTipOutputLabel.TabIndex = 5;
            // 
            // largeTipLabel
            // 
            this.largeTipLabel.AutoSize = true;
            this.largeTipLabel.Location = new System.Drawing.Point(125, 135);
            this.largeTipLabel.Name = "largeTipLabel";
            this.largeTipLabel.Size = new System.Drawing.Size(27, 13);
            this.largeTipLabel.TabIndex = 6;
            this.largeTipLabel.Text = "20%";
            // 
            // largeTipOutputLabel
            // 
            this.largeTipOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeTipOutputLabel.Location = new System.Drawing.Point(158, 135);
            this.largeTipOutputLabel.Name = "largeTipOutputLabel";
            this.largeTipOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.largeTipOutputLabel.TabIndex = 7;
            // 
            // calculateTipButton
            // 
            this.calculateTipButton.Location = new System.Drawing.Point(103, 184);
            this.calculateTipButton.Name = "calculateTipButton";
            this.calculateTipButton.Size = new System.Drawing.Size(82, 23);
            this.calculateTipButton.TabIndex = 8;
            this.calculateTipButton.Text = "Calculate Tip";
            this.calculateTipButton.UseVisualStyleBackColor = true;
            this.calculateTipButton.Click += new System.EventHandler(this.calculateTipButton_Click);
            // 
            // lab3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.calculateTipButton);
            this.Controls.Add(this.largeTipOutputLabel);
            this.Controls.Add(this.largeTipLabel);
            this.Controls.Add(this.mediumTipOutputLabel);
            this.Controls.Add(this.mediumTipLabel);
            this.Controls.Add(this.smallTipOutputLabel);
            this.Controls.Add(this.smallTipLabel);
            this.Controls.Add(this.mealPriceTextBox);
            this.Controls.Add(this.priceOfMealLabel);
            this.Name = "lab3Form";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceOfMealLabel;
        private System.Windows.Forms.TextBox mealPriceTextBox;
        private System.Windows.Forms.Label smallTipLabel;
        private System.Windows.Forms.Label smallTipOutputLabel;
        private System.Windows.Forms.Label mediumTipLabel;
        private System.Windows.Forms.Label mediumTipOutputLabel;
        private System.Windows.Forms.Label largeTipLabel;
        private System.Windows.Forms.Label largeTipOutputLabel;
        private System.Windows.Forms.Button calculateTipButton;
    }
}

