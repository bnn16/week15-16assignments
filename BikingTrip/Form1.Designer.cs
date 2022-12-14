
namespace BikingTrip
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
            this.MyTrips = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Transport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TripRating = new System.Windows.Forms.NumericUpDown();
            this.DistanceKM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TripTo = new System.Windows.Forms.TextBox();
            this.AddTrip = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBtwRatings = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BetweenR2 = new System.Windows.Forms.NumericUpDown();
            this.BetweenR1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowAggBtn = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.DeleteSelectedTrip = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceKM)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenR1)).BeginInit();
            this.gbxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyTrips
            // 
            this.MyTrips.FormattingEnabled = true;
            this.MyTrips.ItemHeight = 16;
            this.MyTrips.Location = new System.Drawing.Point(39, 33);
            this.MyTrips.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyTrips.Name = "MyTrips";
            this.MyTrips.Size = new System.Drawing.Size(370, 148);
            this.MyTrips.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Transport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TripRating);
            this.groupBox1.Controls.Add(this.DistanceKM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TripTo);
            this.groupBox1.Controls.Add(this.AddTrip);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(302, 195);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add trip";
            // 
            // Transport
            // 
            this.Transport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Transport.FormattingEnabled = true;
            this.Transport.Items.AddRange(new object[] {
            "Car",
            "Bike",
            "Train",
            "Bus"});
            this.Transport.Location = new System.Drawing.Point(113, 130);
            this.Transport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(169, 24);
            this.Transport.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label6.Location = new System.Drawing.Point(17, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Transport:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Rating:";
            // 
            // TripRating
            // 
            this.TripRating.DecimalPlaces = 1;
            this.TripRating.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TripRating.Location = new System.Drawing.Point(113, 97);
            this.TripRating.Margin = new System.Windows.Forms.Padding(2);
            this.TripRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TripRating.Name = "TripRating";
            this.TripRating.Size = new System.Drawing.Size(169, 22);
            this.TripRating.TabIndex = 47;
            // 
            // DistanceKM
            // 
            this.DistanceKM.DecimalPlaces = 3;
            this.DistanceKM.Location = new System.Drawing.Point(114, 67);
            this.DistanceKM.Margin = new System.Windows.Forms.Padding(2);
            this.DistanceKM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DistanceKM.Name = "DistanceKM";
            this.DistanceKM.Size = new System.Drawing.Size(132, 22);
            this.DistanceKM.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label3.Location = new System.Drawing.Point(64, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "To:";
            // 
            // TripTo
            // 
            this.TripTo.Location = new System.Drawing.Point(114, 33);
            this.TripTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TripTo.Name = "TripTo";
            this.TripTo.Size = new System.Drawing.Size(171, 22);
            this.TripTo.TabIndex = 17;
            // 
            // AddTrip
            // 
            this.AddTrip.Location = new System.Drawing.Point(18, 159);
            this.AddTrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTrip.Name = "AddTrip";
            this.AddTrip.Size = new System.Drawing.Size(265, 22);
            this.AddTrip.TabIndex = 15;
            this.AddTrip.Text = "Add";
            this.AddTrip.UseVisualStyleBackColor = true;
            this.AddTrip.Click += new System.EventHandler(this.AddToTrips);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBtwRatings);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BetweenR2);
            this.groupBox2.Controls.Add(this.BetweenR1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ShowAggBtn);
            this.groupBox2.Controls.Add(this.ShowAll);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.MyTrips);
            this.groupBox2.Location = new System.Drawing.Point(333, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(452, 343);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My trips";
            // 
            // SearchBtwRatings
            // 
            this.SearchBtwRatings.Location = new System.Drawing.Point(322, 259);
            this.SearchBtwRatings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBtwRatings.Name = "SearchBtwRatings";
            this.SearchBtwRatings.Size = new System.Drawing.Size(96, 30);
            this.SearchBtwRatings.TabIndex = 51;
            this.SearchBtwRatings.Text = "Search";
            this.SearchBtwRatings.UseVisualStyleBackColor = true;
            this.SearchBtwRatings.Click += new System.EventHandler(this.SearchBetweenRatings);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label8.Location = new System.Drawing.Point(228, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "and";
            // 
            // BetweenR2
            // 
            this.BetweenR2.DecimalPlaces = 1;
            this.BetweenR2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.BetweenR2.Location = new System.Drawing.Point(273, 264);
            this.BetweenR2.Margin = new System.Windows.Forms.Padding(2);
            this.BetweenR2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetweenR2.Name = "BetweenR2";
            this.BetweenR2.Size = new System.Drawing.Size(43, 22);
            this.BetweenR2.TabIndex = 49;
            // 
            // BetweenR1
            // 
            this.BetweenR1.DecimalPlaces = 1;
            this.BetweenR1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.BetweenR1.Location = new System.Drawing.Point(173, 264);
            this.BetweenR1.Margin = new System.Windows.Forms.Padding(2);
            this.BetweenR1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetweenR1.Name = "BetweenR1";
            this.BetweenR1.Size = new System.Drawing.Size(43, 22);
            this.BetweenR1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label7.Location = new System.Drawing.Point(32, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search between:";
            // 
            // ShowAggBtn
            // 
            this.ShowAggBtn.Location = new System.Drawing.Point(39, 295);
            this.ShowAggBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowAggBtn.Name = "ShowAggBtn";
            this.ShowAggBtn.Size = new System.Drawing.Size(369, 30);
            this.ShowAggBtn.TabIndex = 24;
            this.ShowAggBtn.Text = "Show aggregate data";
            this.ShowAggBtn.UseVisualStyleBackColor = true;
            this.ShowAggBtn.Click += new System.EventHandler(this.ShowAgg);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(39, 187);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(369, 30);
            this.ShowAll.TabIndex = 23;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAllTrips);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label1.Location = new System.Drawing.Point(39, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "To:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(77, 218);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(207, 22);
            this.Search.TabIndex = 21;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(290, 217);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(118, 30);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchTrip);
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.btnInfo);
            this.gbxActions.Controls.Add(this.DeleteSelectedTrip);
            this.gbxActions.Location = new System.Drawing.Point(11, 209);
            this.gbxActions.Margin = new System.Windows.Forms.Padding(2);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Padding = new System.Windows.Forms.Padding(2);
            this.gbxActions.Size = new System.Drawing.Size(305, 126);
            this.gbxActions.TabIndex = 43;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Selected trip";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(14, 20);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(265, 45);
            this.btnInfo.TabIndex = 45;
            this.btnInfo.Text = "Show info of selected trip";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.InfoAboutTrip);
            // 
            // DeleteSelectedTrip
            // 
            this.DeleteSelectedTrip.Location = new System.Drawing.Point(14, 76);
            this.DeleteSelectedTrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteSelectedTrip.Name = "DeleteSelectedTrip";
            this.DeleteSelectedTrip.Size = new System.Drawing.Size(265, 36);
            this.DeleteSelectedTrip.TabIndex = 20;
            this.DeleteSelectedTrip.Text = "Delete selected trip";
            this.DeleteSelectedTrip.UseVisualStyleBackColor = true;
            this.DeleteSelectedTrip.Click += new System.EventHandler(this.DeleteTrip);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 364);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Travel App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceKM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenR1)).EndInit();
            this.gbxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox MyTrips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TripTo;
        private System.Windows.Forms.Button AddTrip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button DeleteSelectedTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.NumericUpDown DistanceKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TripRating;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.ComboBox Transport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowAggBtn;
        private System.Windows.Forms.Button SearchBtwRatings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown BetweenR2;
        private System.Windows.Forms.NumericUpDown BetweenR1;
        private System.Windows.Forms.Label label7;
    }
}

