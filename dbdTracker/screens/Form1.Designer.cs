namespace dbdTracker
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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.survivorFourText = new System.Windows.Forms.TextBox();
            this.survivorThreeText = new System.Windows.Forms.TextBox();
            this.survivorTwoText = new System.Windows.Forms.TextBox();
            this.survivorOneText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 296);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoBox.Size = new System.Drawing.Size(935, 224);
            this.infoBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(953, 31);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // survivorFourText
            // 
            this.survivorFourText.Location = new System.Drawing.Point(481, 162);
            this.survivorFourText.Multiline = true;
            this.survivorFourText.Name = "survivorFourText";
            this.survivorFourText.ReadOnly = true;
            this.survivorFourText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.survivorFourText.Size = new System.Drawing.Size(466, 128);
            this.survivorFourText.TabIndex = 2;
            // 
            // survivorThreeText
            // 
            this.survivorThreeText.Location = new System.Drawing.Point(12, 162);
            this.survivorThreeText.Multiline = true;
            this.survivorThreeText.Name = "survivorThreeText";
            this.survivorThreeText.ReadOnly = true;
            this.survivorThreeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.survivorThreeText.Size = new System.Drawing.Size(463, 128);
            this.survivorThreeText.TabIndex = 3;
            // 
            // survivorTwoText
            // 
            this.survivorTwoText.Location = new System.Drawing.Point(481, 32);
            this.survivorTwoText.Multiline = true;
            this.survivorTwoText.Name = "survivorTwoText";
            this.survivorTwoText.ReadOnly = true;
            this.survivorTwoText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.survivorTwoText.Size = new System.Drawing.Size(466, 124);
            this.survivorTwoText.TabIndex = 4;
            // 
            // survivorOneText
            // 
            this.survivorOneText.Location = new System.Drawing.Point(12, 32);
            this.survivorOneText.Multiline = true;
            this.survivorOneText.Name = "survivorOneText";
            this.survivorOneText.ReadOnly = true;
            this.survivorOneText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.survivorOneText.Size = new System.Drawing.Size(463, 124);
            this.survivorOneText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 598);
            this.Controls.Add(this.survivorOneText);
            this.Controls.Add(this.survivorTwoText);
            this.Controls.Add(this.survivorThreeText);
            this.Controls.Add(this.survivorFourText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.infoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox survivorFourText;
        private System.Windows.Forms.TextBox survivorThreeText;
        private System.Windows.Forms.TextBox survivorTwoText;
        private System.Windows.Forms.TextBox survivorOneText;
    }
}

