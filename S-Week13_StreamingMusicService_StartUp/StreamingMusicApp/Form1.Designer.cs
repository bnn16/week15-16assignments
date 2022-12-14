
namespace StreamingMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddUser = new System.Windows.Forms.Button();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.FavSongs = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserList = new System.Windows.Forms.ComboBox();
            this.AllSongs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SongTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.musidId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 450);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddUser);
            this.tabPage1.Controls.Add(this.AddressInput);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.EmailInput);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nameInput);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register User";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(66, 224);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(94, 29);
            this.AddUser.TabIndex = 26;
            this.AddUser.Text = "Add user";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.Add_User);
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(96, 128);
            this.AddressInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(114, 27);
            this.AddressInput.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(96, 72);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(114, 27);
            this.EmailInput.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(96, 22);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(114, 27);
            this.nameInput.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.FavSongs);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.UserList);
            this.tabPage2.Controls.Add(this.AllSongs);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Duration);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SongTitle);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ArtistName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.musidId);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Music";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 379);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 27;
            this.button4.Text = "Remove Fav song";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveFromFav);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fav songs";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 379);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 25;
            this.button3.Text = "Fav Song";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddToFav);
            // 
            // FavSongs
            // 
            this.FavSongs.FormattingEnabled = true;
            this.FavSongs.ItemHeight = 20;
            this.FavSongs.Location = new System.Drawing.Point(687, 33);
            this.FavSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FavSongs.Name = "FavSongs";
            this.FavSongs.Size = new System.Drawing.Size(366, 324);
            this.FavSongs.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "All songs";
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(70, 15);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(151, 28);
            this.UserList.TabIndex = 22;
            this.UserList.Text = "User list";
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.onUserChange);
            // 
            // AllSongs
            // 
            this.AllSongs.FormattingEnabled = true;
            this.AllSongs.ItemHeight = 20;
            this.AllSongs.Location = new System.Drawing.Point(248, 33);
            this.AllSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllSongs.Name = "AllSongs";
            this.AllSongs.Size = new System.Drawing.Size(366, 324);
            this.AllSongs.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add Song";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addSong);
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(70, 219);
            this.Duration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(114, 27);
            this.Duration.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Duration\r\n (sec)";
            // 
            // SongTitle
            // 
            this.SongTitle.Location = new System.Drawing.Point(70, 172);
            this.SongTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Size = new System.Drawing.Size(114, 27);
            this.SongTitle.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title";
            // 
            // ArtistName
            // 
            this.ArtistName.Location = new System.Drawing.Point(70, 116);
            this.ArtistName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(114, 27);
            this.ArtistName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Artist";
            // 
            // musidId
            // 
            this.musidId.Location = new System.Drawing.Point(70, 66);
            this.musidId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musidId.Name = "musidId";
            this.musidId.Size = new System.Drawing.Size(114, 27);
            this.musidId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 457);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sound";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.ListBox AllSongs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SongTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArtistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox musidId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox FavSongs;
    }
}

