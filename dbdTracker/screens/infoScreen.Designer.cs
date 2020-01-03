namespace dbdTracker
{
    partial class infoScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.killerName = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.survOneNameBox = new System.Windows.Forms.TextBox();
            this.survTwoNameBox = new System.Windows.Forms.TextBox();
            this.survThreeNameBox = new System.Windows.Forms.TextBox();
            this.survFourNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // killerName
            // 
            this.killerName.Location = new System.Drawing.Point(13, 13);
            this.killerName.Multiline = true;
            this.killerName.Name = "killerName";
            this.killerName.ReadOnly = true;
            this.killerName.Size = new System.Drawing.Size(975, 20);
            this.killerName.TabIndex = 0;
            this.killerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(204, 170);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "killerData";
            // 
            // survOneNameBox
            // 
            this.survOneNameBox.Location = new System.Drawing.Point(13, 292);
            this.survOneNameBox.Multiline = true;
            this.survOneNameBox.Name = "survOneNameBox";
            this.survOneNameBox.ReadOnly = true;
            this.survOneNameBox.Size = new System.Drawing.Size(235, 20);
            this.survOneNameBox.TabIndex = 2;
            this.survOneNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // survTwoNameBox
            // 
            this.survTwoNameBox.Location = new System.Drawing.Point(254, 292);
            this.survTwoNameBox.Multiline = true;
            this.survTwoNameBox.Name = "survTwoNameBox";
            this.survTwoNameBox.ReadOnly = true;
            this.survTwoNameBox.Size = new System.Drawing.Size(235, 20);
            this.survTwoNameBox.TabIndex = 3;
            this.survTwoNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // survThreeNameBox
            // 
            this.survThreeNameBox.Location = new System.Drawing.Point(495, 292);
            this.survThreeNameBox.Multiline = true;
            this.survThreeNameBox.Name = "survThreeNameBox";
            this.survThreeNameBox.ReadOnly = true;
            this.survThreeNameBox.Size = new System.Drawing.Size(235, 20);
            this.survThreeNameBox.TabIndex = 4;
            this.survThreeNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // survFourNameBox
            // 
            this.survFourNameBox.Location = new System.Drawing.Point(753, 292);
            this.survFourNameBox.Multiline = true;
            this.survFourNameBox.Name = "survFourNameBox";
            this.survFourNameBox.ReadOnly = true;
            this.survFourNameBox.Size = new System.Drawing.Size(235, 20);
            this.survFourNameBox.TabIndex = 5;
            this.survFourNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.survFourNameBox);
            this.Controls.Add(this.survThreeNameBox);
            this.Controls.Add(this.survTwoNameBox);
            this.Controls.Add(this.survOneNameBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.killerName);
            this.Name = "infoScreen";
            this.Text = "infoScreen";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox killerName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox survOneNameBox;
        private System.Windows.Forms.TextBox survTwoNameBox;
        private System.Windows.Forms.TextBox survThreeNameBox;
        private System.Windows.Forms.TextBox survFourNameBox;
    }
}