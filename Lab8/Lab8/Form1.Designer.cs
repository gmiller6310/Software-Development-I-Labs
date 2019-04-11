namespace Lab8
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
            this.tripDistanceLabel = new System.Windows.Forms.Label();
            this.tripDistanceTextBox = new System.Windows.Forms.TextBox();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.ticketPriceOutputLabel = new System.Windows.Forms.Label();
            this.findTicketPriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tripDistanceLabel
            // 
            this.tripDistanceLabel.AutoSize = true;
            this.tripDistanceLabel.Location = new System.Drawing.Point(12, 9);
            this.tripDistanceLabel.Name = "tripDistanceLabel";
            this.tripDistanceLabel.Size = new System.Drawing.Size(73, 13);
            this.tripDistanceLabel.TabIndex = 0;
            this.tripDistanceLabel.Text = "Trip Distance:";
            // 
            // tripDistanceTextBox
            // 
            this.tripDistanceTextBox.Location = new System.Drawing.Point(91, 12);
            this.tripDistanceTextBox.Name = "tripDistanceTextBox";
            this.tripDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.tripDistanceTextBox.TabIndex = 1;
            this.tripDistanceTextBox.TextChanged += new System.EventHandler(this.findTicketPriceButton_Click);
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.AutoSize = true;
            this.ticketPriceLabel.Location = new System.Drawing.Point(18, 45);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(67, 13);
            this.ticketPriceLabel.TabIndex = 2;
            this.ticketPriceLabel.Text = "Ticket Price:";
            // 
            // ticketPriceOutputLabel
            // 
            this.ticketPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPriceOutputLabel.Location = new System.Drawing.Point(91, 45);
            this.ticketPriceOutputLabel.Name = "ticketPriceOutputLabel";
            this.ticketPriceOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.ticketPriceOutputLabel.TabIndex = 3;
            // 
            // findTicketPriceButton
            // 
            this.findTicketPriceButton.Location = new System.Drawing.Point(58, 92);
            this.findTicketPriceButton.Name = "findTicketPriceButton";
            this.findTicketPriceButton.Size = new System.Drawing.Size(95, 23);
            this.findTicketPriceButton.TabIndex = 4;
            this.findTicketPriceButton.Text = "Find Ticket Price";
            this.findTicketPriceButton.UseVisualStyleBackColor = true;
            this.findTicketPriceButton.Click += new System.EventHandler(this.findTicketPriceButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.findTicketPriceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 127);
            this.Controls.Add(this.findTicketPriceButton);
            this.Controls.Add(this.ticketPriceOutputLabel);
            this.Controls.Add(this.ticketPriceLabel);
            this.Controls.Add(this.tripDistanceTextBox);
            this.Controls.Add(this.tripDistanceLabel);
            this.Name = "Form1";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tripDistanceLabel;
        private System.Windows.Forms.TextBox tripDistanceTextBox;
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.Label ticketPriceOutputLabel;
        private System.Windows.Forms.Button findTicketPriceButton;
    }
}

