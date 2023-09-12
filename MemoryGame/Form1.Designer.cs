namespace MemoryGame
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.tmStartGame = new System.Windows.Forms.Timer(this.components);
            this.tmDurationGame = new System.Windows.Forms.Timer(this.components);
            this.lblGameDurationName = new System.Windows.Forms.Label();
            this.lblGameDurationValue = new System.Windows.Forms.Label();
            this.tmShowImageForMoment = new System.Windows.Forms.Timer(this.components);
            this.pbQuestion16 = new System.Windows.Forms.PictureBox();
            this.pbQuestion15 = new System.Windows.Forms.PictureBox();
            this.pbQuestion13 = new System.Windows.Forms.PictureBox();
            this.pbQuestion14 = new System.Windows.Forms.PictureBox();
            this.pbQuestion12 = new System.Windows.Forms.PictureBox();
            this.pbQuestion11 = new System.Windows.Forms.PictureBox();
            this.pbQuestion9 = new System.Windows.Forms.PictureBox();
            this.pbQuestion10 = new System.Windows.Forms.PictureBox();
            this.pbQuestion5 = new System.Windows.Forms.PictureBox();
            this.pbQuestion6 = new System.Windows.Forms.PictureBox();
            this.pbQuestion8 = new System.Windows.Forms.PictureBox();
            this.pbQuestion7 = new System.Windows.Forms.PictureBox();
            this.pbQuestion3 = new System.Windows.Forms.PictureBox();
            this.pbQuestion2 = new System.Windows.Forms.PictureBox();
            this.pbQuestion4 = new System.Windows.Forms.PictureBox();
            this.pbQuestion1 = new System.Windows.Forms.PictureBox();
            this.pbBackgroundMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Orange;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(681, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 41);
            this.btnStart.TabIndex = 17;
            this.btnStart.Tag = "";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmStartGame
            // 
            this.tmStartGame.Interval = 2000;
            this.tmStartGame.Tick += new System.EventHandler(this.tmStartGame_Tick);
            // 
            // tmDurationGame
            // 
            this.tmDurationGame.Interval = 1000;
            this.tmDurationGame.Tick += new System.EventHandler(this.tmDurationGame_Tick);
            // 
            // lblGameDurationName
            // 
            this.lblGameDurationName.BackColor = System.Drawing.Color.Indigo;
            this.lblGameDurationName.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDurationName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameDurationName.Location = new System.Drawing.Point(681, 98);
            this.lblGameDurationName.Name = "lblGameDurationName";
            this.lblGameDurationName.Size = new System.Drawing.Size(189, 28);
            this.lblGameDurationName.TabIndex = 18;
            this.lblGameDurationName.Text = "Game Duration";
            this.lblGameDurationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameDurationValue
            // 
            this.lblGameDurationValue.AutoSize = true;
            this.lblGameDurationValue.BackColor = System.Drawing.Color.Indigo;
            this.lblGameDurationValue.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDurationValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameDurationValue.Location = new System.Drawing.Point(761, 146);
            this.lblGameDurationValue.Name = "lblGameDurationValue";
            this.lblGameDurationValue.Size = new System.Drawing.Size(57, 31);
            this.lblGameDurationValue.TabIndex = 19;
            this.lblGameDurationValue.Text = "30 s";
            // 
            // tmShowImageForMoment
            // 
            this.tmShowImageForMoment.Tick += new System.EventHandler(this.tmShowTic_Tick);
            // 
            // pbQuestion16
            // 
            this.pbQuestion16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion16.Enabled = false;
            this.pbQuestion16.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion16.Location = new System.Drawing.Point(485, 421);
            this.pbQuestion16.Name = "pbQuestion16";
            this.pbQuestion16.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion16.TabIndex = 16;
            this.pbQuestion16.TabStop = false;
            this.pbQuestion16.Tag = "15";
            this.pbQuestion16.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion15
            // 
            this.pbQuestion15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion15.Enabled = false;
            this.pbQuestion15.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion15.Location = new System.Drawing.Point(336, 421);
            this.pbQuestion15.Name = "pbQuestion15";
            this.pbQuestion15.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion15.TabIndex = 15;
            this.pbQuestion15.TabStop = false;
            this.pbQuestion15.Tag = "14";
            this.pbQuestion15.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion13
            // 
            this.pbQuestion13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion13.Enabled = false;
            this.pbQuestion13.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion13.Location = new System.Drawing.Point(36, 421);
            this.pbQuestion13.Name = "pbQuestion13";
            this.pbQuestion13.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion13.TabIndex = 14;
            this.pbQuestion13.TabStop = false;
            this.pbQuestion13.Tag = "12";
            this.pbQuestion13.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion14
            // 
            this.pbQuestion14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion14.Enabled = false;
            this.pbQuestion14.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion14.Location = new System.Drawing.Point(187, 421);
            this.pbQuestion14.Name = "pbQuestion14";
            this.pbQuestion14.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion14.TabIndex = 13;
            this.pbQuestion14.TabStop = false;
            this.pbQuestion14.Tag = "13";
            this.pbQuestion14.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion12
            // 
            this.pbQuestion12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion12.Enabled = false;
            this.pbQuestion12.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion12.Location = new System.Drawing.Point(485, 293);
            this.pbQuestion12.Name = "pbQuestion12";
            this.pbQuestion12.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion12.TabIndex = 12;
            this.pbQuestion12.TabStop = false;
            this.pbQuestion12.Tag = "11";
            this.pbQuestion12.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion11
            // 
            this.pbQuestion11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion11.Enabled = false;
            this.pbQuestion11.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion11.Location = new System.Drawing.Point(336, 293);
            this.pbQuestion11.Name = "pbQuestion11";
            this.pbQuestion11.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion11.TabIndex = 11;
            this.pbQuestion11.TabStop = false;
            this.pbQuestion11.Tag = "10";
            this.pbQuestion11.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion9
            // 
            this.pbQuestion9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion9.Enabled = false;
            this.pbQuestion9.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion9.Location = new System.Drawing.Point(36, 293);
            this.pbQuestion9.Name = "pbQuestion9";
            this.pbQuestion9.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion9.TabIndex = 10;
            this.pbQuestion9.TabStop = false;
            this.pbQuestion9.Tag = "8";
            this.pbQuestion9.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion10
            // 
            this.pbQuestion10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion10.Enabled = false;
            this.pbQuestion10.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion10.Location = new System.Drawing.Point(187, 293);
            this.pbQuestion10.Name = "pbQuestion10";
            this.pbQuestion10.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion10.TabIndex = 9;
            this.pbQuestion10.TabStop = false;
            this.pbQuestion10.Tag = "9";
            this.pbQuestion10.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion5
            // 
            this.pbQuestion5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion5.Enabled = false;
            this.pbQuestion5.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion5.Location = new System.Drawing.Point(36, 164);
            this.pbQuestion5.Name = "pbQuestion5";
            this.pbQuestion5.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion5.TabIndex = 8;
            this.pbQuestion5.TabStop = false;
            this.pbQuestion5.Tag = "4";
            this.pbQuestion5.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion6
            // 
            this.pbQuestion6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion6.Enabled = false;
            this.pbQuestion6.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion6.Location = new System.Drawing.Point(187, 164);
            this.pbQuestion6.Name = "pbQuestion6";
            this.pbQuestion6.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion6.TabIndex = 7;
            this.pbQuestion6.TabStop = false;
            this.pbQuestion6.Tag = "5";
            this.pbQuestion6.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion8
            // 
            this.pbQuestion8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion8.Enabled = false;
            this.pbQuestion8.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion8.Location = new System.Drawing.Point(485, 164);
            this.pbQuestion8.Name = "pbQuestion8";
            this.pbQuestion8.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion8.TabIndex = 6;
            this.pbQuestion8.TabStop = false;
            this.pbQuestion8.Tag = "7";
            this.pbQuestion8.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion7
            // 
            this.pbQuestion7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion7.Enabled = false;
            this.pbQuestion7.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion7.Location = new System.Drawing.Point(336, 164);
            this.pbQuestion7.Name = "pbQuestion7";
            this.pbQuestion7.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion7.TabIndex = 5;
            this.pbQuestion7.TabStop = false;
            this.pbQuestion7.Tag = "6";
            this.pbQuestion7.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion3
            // 
            this.pbQuestion3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion3.Enabled = false;
            this.pbQuestion3.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion3.Location = new System.Drawing.Point(336, 35);
            this.pbQuestion3.Name = "pbQuestion3";
            this.pbQuestion3.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion3.TabIndex = 4;
            this.pbQuestion3.TabStop = false;
            this.pbQuestion3.Tag = "2";
            this.pbQuestion3.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion2
            // 
            this.pbQuestion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion2.Enabled = false;
            this.pbQuestion2.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion2.Location = new System.Drawing.Point(187, 35);
            this.pbQuestion2.Name = "pbQuestion2";
            this.pbQuestion2.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion2.TabIndex = 3;
            this.pbQuestion2.TabStop = false;
            this.pbQuestion2.Tag = "1";
            this.pbQuestion2.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion4
            // 
            this.pbQuestion4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion4.Enabled = false;
            this.pbQuestion4.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion4.Location = new System.Drawing.Point(485, 35);
            this.pbQuestion4.Name = "pbQuestion4";
            this.pbQuestion4.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion4.TabIndex = 2;
            this.pbQuestion4.TabStop = false;
            this.pbQuestion4.Tag = "3";
            this.pbQuestion4.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbQuestion1
            // 
            this.pbQuestion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestion1.Enabled = false;
            this.pbQuestion1.Image = global::MemoryGame.Properties.Resources.Question;
            this.pbQuestion1.Location = new System.Drawing.Point(36, 35);
            this.pbQuestion1.Name = "pbQuestion1";
            this.pbQuestion1.Size = new System.Drawing.Size(133, 113);
            this.pbQuestion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion1.TabIndex = 1;
            this.pbQuestion1.TabStop = false;
            this.pbQuestion1.Tag = "0";
            this.pbQuestion1.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // pbBackgroundMain
            // 
            this.pbBackgroundMain.BackColor = System.Drawing.SystemColors.Control;
            this.pbBackgroundMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackgroundMain.Image = global::MemoryGame.Properties.Resources.MemoryGame_background1;
            this.pbBackgroundMain.Location = new System.Drawing.Point(0, 0);
            this.pbBackgroundMain.Name = "pbBackgroundMain";
            this.pbBackgroundMain.Size = new System.Drawing.Size(900, 569);
            this.pbBackgroundMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackgroundMain.TabIndex = 0;
            this.pbBackgroundMain.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.lblGameDurationValue);
            this.Controls.Add(this.lblGameDurationName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbQuestion16);
            this.Controls.Add(this.pbQuestion15);
            this.Controls.Add(this.pbQuestion13);
            this.Controls.Add(this.pbQuestion14);
            this.Controls.Add(this.pbQuestion12);
            this.Controls.Add(this.pbQuestion11);
            this.Controls.Add(this.pbQuestion9);
            this.Controls.Add(this.pbQuestion10);
            this.Controls.Add(this.pbQuestion5);
            this.Controls.Add(this.pbQuestion6);
            this.Controls.Add(this.pbQuestion8);
            this.Controls.Add(this.pbQuestion7);
            this.Controls.Add(this.pbQuestion3);
            this.Controls.Add(this.pbQuestion2);
            this.Controls.Add(this.pbQuestion4);
            this.Controls.Add(this.pbQuestion1);
            this.Controls.Add(this.pbBackgroundMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackgroundMain;
        private System.Windows.Forms.PictureBox pbQuestion1;
        private System.Windows.Forms.PictureBox pbQuestion4;
        private System.Windows.Forms.PictureBox pbQuestion2;
        private System.Windows.Forms.PictureBox pbQuestion3;
        private System.Windows.Forms.PictureBox pbQuestion7;
        private System.Windows.Forms.PictureBox pbQuestion8;
        private System.Windows.Forms.PictureBox pbQuestion6;
        private System.Windows.Forms.PictureBox pbQuestion5;
        private System.Windows.Forms.PictureBox pbQuestion10;
        private System.Windows.Forms.PictureBox pbQuestion9;
        private System.Windows.Forms.PictureBox pbQuestion11;
        private System.Windows.Forms.PictureBox pbQuestion12;
        private System.Windows.Forms.PictureBox pbQuestion14;
        private System.Windows.Forms.PictureBox pbQuestion13;
        private System.Windows.Forms.PictureBox pbQuestion15;
        private System.Windows.Forms.PictureBox pbQuestion16;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmStartGame;
        private System.Windows.Forms.Timer tmDurationGame;
        private System.Windows.Forms.Label lblGameDurationName;
        private System.Windows.Forms.Label lblGameDurationValue;
        private System.Windows.Forms.Timer tmShowImageForMoment;
    }
}

