namespace WindowsFormsApplication1
{
    partial class lab1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab1Form));
            this.otterPictureBox = new System.Windows.Forms.PictureBox();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.hobbiesButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // otterPictureBox
            // 
            this.otterPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otterPictureBox.BackgroundImage")));
            this.otterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.otterPictureBox.Location = new System.Drawing.Point(62, 12);
            this.otterPictureBox.Name = "otterPictureBox";
            this.otterPictureBox.Size = new System.Drawing.Size(164, 162);
            this.otterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otterPictureBox.TabIndex = 0;
            this.otterPictureBox.TabStop = false;
            this.otterPictureBox.Click += new System.EventHandler(this.otterPictureBox_Click);
            // 
            // myNameLabel
            // 
            this.myNameLabel.Location = new System.Drawing.Point(93, 177);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(100, 23);
            this.myNameLabel.TabIndex = 1;
            this.myNameLabel.Text = "Grant Miller";
            this.myNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // hobbiesButton
            // 
            this.hobbiesButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hobbiesButton.Location = new System.Drawing.Point(12, 216);
            this.hobbiesButton.Name = "hobbiesButton";
            this.hobbiesButton.Size = new System.Drawing.Size(75, 23);
            this.hobbiesButton.TabIndex = 2;
            this.hobbiesButton.Text = "Hobbies";
            this.hobbiesButton.UseVisualStyleBackColor = true;
            this.hobbiesButton.Click += new System.EventHandler(this.hobbiesButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookButton.Location = new System.Drawing.Point(105, 216);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 3;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(196, 216);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(75, 23);
            this.movieButton.TabIndex = 4;
            this.movieButton.Text = "Movie";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // lab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 261);
            this.Controls.Add(this.movieButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.hobbiesButton);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.otterPictureBox);
            this.Name = "lab1Form";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.otterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox otterPictureBox;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Button hobbiesButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button movieButton;
    }
}

