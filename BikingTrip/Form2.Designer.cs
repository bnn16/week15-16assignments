namespace BikingTrip
{
    partial class Form2
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
            this.ListOfTrips = new System.Windows.Forms.ListBox();
            this.lbAvg = new System.Windows.Forms.Label();
            this.AvgRatingOfTrips = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListOfTrips
            // 
            this.ListOfTrips.FormattingEnabled = true;
            this.ListOfTrips.ItemHeight = 16;
            this.ListOfTrips.Location = new System.Drawing.Point(26, 30);
            this.ListOfTrips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfTrips.Name = "ListOfTrips";
            this.ListOfTrips.Size = new System.Drawing.Size(489, 292);
            this.ListOfTrips.TabIndex = 0;
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Location = new System.Drawing.Point(90, 334);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(152, 17);
            this.lbAvg.TabIndex = 1;
            this.lbAvg.Text = "Average rating of trips:";
            // 
            // AvgRatingOfTrips
            // 
            this.AvgRatingOfTrips.Location = new System.Drawing.Point(244, 334);
            this.AvgRatingOfTrips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvgRatingOfTrips.Name = "AvgRatingOfTrips";
            this.AvgRatingOfTrips.ReadOnly = true;
            this.AvgRatingOfTrips.Size = new System.Drawing.Size(89, 22);
            this.AvgRatingOfTrips.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 360);
            this.Controls.Add(this.AvgRatingOfTrips);
            this.Controls.Add(this.lbAvg);
            this.Controls.Add(this.ListOfTrips);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfTrips;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.TextBox AvgRatingOfTrips;
    }
}