namespace Stone_Paper_Scissors_Game
{
    partial class frmStonePaperScissorsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStonePaperScissorsGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgNextComputer = new System.Windows.Forms.PictureBox();
            this.imgPlayerNext = new System.Windows.Forms.PictureBox();
            this.btnComputerScissors = new System.Windows.Forms.Button();
            this.btnComputerPaper = new System.Windows.Forms.Button();
            this.btnComputerStone = new System.Windows.Forms.Button();
            this.btnPlayerScissors = new System.Windows.Forms.Button();
            this.btnPlayerPaper = new System.Windows.Forms.Button();
            this.btnPlayerStone = new System.Windows.Forms.Button();
            this.lblPlayerWineerTimes = new System.Windows.Forms.Label();
            this.lblComputerWineerTimes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgNextComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerNext)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Olive;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(551, 493);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.Location = new System.Drawing.Point(1156, 114);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(750, 230);
            this.del.TabIndex = 1;
            this.del.Text = "Rest";
            this.del.UseVisualStyleBackColor = false;
            this.del.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(145, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(633, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Computer";
            // 
            // imgNextComputer
            // 
            this.imgNextComputer.BackColor = System.Drawing.Color.Transparent;
            this.imgNextComputer.Image = global::Stone_Paper_Scissors_Game.Properties.Resources.LeftArrow;
            this.imgNextComputer.Location = new System.Drawing.Point(788, 36);
            this.imgNextComputer.Name = "imgNextComputer";
            this.imgNextComputer.Size = new System.Drawing.Size(85, 74);
            this.imgNextComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNextComputer.TabIndex = 11;
            this.imgNextComputer.TabStop = false;
            this.imgNextComputer.Visible = false;
            // 
            // imgPlayerNext
            // 
            this.imgPlayerNext.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayerNext.Image = global::Stone_Paper_Scissors_Game.Properties.Resources.RightArrow;
            this.imgPlayerNext.Location = new System.Drawing.Point(40, 36);
            this.imgPlayerNext.Name = "imgPlayerNext";
            this.imgPlayerNext.Size = new System.Drawing.Size(85, 74);
            this.imgPlayerNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerNext.TabIndex = 10;
            this.imgPlayerNext.TabStop = false;
            this.imgPlayerNext.Visible = false;
            // 
            // btnComputerScissors
            // 
            this.btnComputerScissors.BackColor = System.Drawing.Color.Transparent;
            this.btnComputerScissors.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.Scissors;
            this.btnComputerScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComputerScissors.Enabled = false;
            this.btnComputerScissors.FlatAppearance.BorderSize = 0;
            this.btnComputerScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnComputerScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputerScissors.Location = new System.Drawing.Point(772, 227);
            this.btnComputerScissors.Name = "btnComputerScissors";
            this.btnComputerScissors.Size = new System.Drawing.Size(101, 83);
            this.btnComputerScissors.TabIndex = 7;
            this.btnComputerScissors.Tag = "3";
            this.btnComputerScissors.UseVisualStyleBackColor = false;
            // 
            // btnComputerPaper
            // 
            this.btnComputerPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnComputerPaper.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.Paper;
            this.btnComputerPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComputerPaper.Enabled = false;
            this.btnComputerPaper.FlatAppearance.BorderSize = 0;
            this.btnComputerPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnComputerPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputerPaper.Location = new System.Drawing.Point(650, 227);
            this.btnComputerPaper.Name = "btnComputerPaper";
            this.btnComputerPaper.Size = new System.Drawing.Size(101, 83);
            this.btnComputerPaper.TabIndex = 6;
            this.btnComputerPaper.Tag = "2";
            this.btnComputerPaper.UseVisualStyleBackColor = false;
            // 
            // btnComputerStone
            // 
            this.btnComputerStone.BackColor = System.Drawing.Color.Transparent;
            this.btnComputerStone.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.stone;
            this.btnComputerStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComputerStone.Enabled = false;
            this.btnComputerStone.FlatAppearance.BorderSize = 0;
            this.btnComputerStone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnComputerStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputerStone.Location = new System.Drawing.Point(513, 227);
            this.btnComputerStone.Name = "btnComputerStone";
            this.btnComputerStone.Size = new System.Drawing.Size(101, 83);
            this.btnComputerStone.TabIndex = 5;
            this.btnComputerStone.Tag = "1";
            this.btnComputerStone.UseVisualStyleBackColor = false;
            // 
            // btnPlayerScissors
            // 
            this.btnPlayerScissors.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerScissors.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.Scissors;
            this.btnPlayerScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerScissors.Enabled = false;
            this.btnPlayerScissors.FlatAppearance.BorderSize = 0;
            this.btnPlayerScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPlayerScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerScissors.Location = new System.Drawing.Point(275, 227);
            this.btnPlayerScissors.Name = "btnPlayerScissors";
            this.btnPlayerScissors.Size = new System.Drawing.Size(101, 83);
            this.btnPlayerScissors.TabIndex = 4;
            this.btnPlayerScissors.Tag = "3";
            this.btnPlayerScissors.UseVisualStyleBackColor = false;
            this.btnPlayerScissors.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnPlayerPaper
            // 
            this.btnPlayerPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerPaper.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.Paper;
            this.btnPlayerPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerPaper.Enabled = false;
            this.btnPlayerPaper.FlatAppearance.BorderSize = 0;
            this.btnPlayerPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPlayerPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerPaper.Location = new System.Drawing.Point(150, 227);
            this.btnPlayerPaper.Name = "btnPlayerPaper";
            this.btnPlayerPaper.Size = new System.Drawing.Size(101, 83);
            this.btnPlayerPaper.TabIndex = 3;
            this.btnPlayerPaper.Tag = "2";
            this.btnPlayerPaper.UseVisualStyleBackColor = false;
            this.btnPlayerPaper.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnPlayerStone
            // 
            this.btnPlayerStone.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerStone.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.stone;
            this.btnPlayerStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerStone.Enabled = false;
            this.btnPlayerStone.FlatAppearance.BorderSize = 0;
            this.btnPlayerStone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPlayerStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerStone.Location = new System.Drawing.Point(24, 227);
            this.btnPlayerStone.Name = "btnPlayerStone";
            this.btnPlayerStone.Size = new System.Drawing.Size(101, 83);
            this.btnPlayerStone.TabIndex = 2;
            this.btnPlayerStone.Tag = "1";
            this.btnPlayerStone.UseVisualStyleBackColor = false;
            this.btnPlayerStone.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // lblPlayerWineerTimes
            // 
            this.lblPlayerWineerTimes.AutoSize = true;
            this.lblPlayerWineerTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWineerTimes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWineerTimes.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblPlayerWineerTimes.Location = new System.Drawing.Point(175, 114);
            this.lblPlayerWineerTimes.Name = "lblPlayerWineerTimes";
            this.lblPlayerWineerTimes.Size = new System.Drawing.Size(28, 29);
            this.lblPlayerWineerTimes.TabIndex = 12;
            this.lblPlayerWineerTimes.Text = "0";
            // 
            // lblComputerWineerTimes
            // 
            this.lblComputerWineerTimes.AutoSize = true;
            this.lblComputerWineerTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWineerTimes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWineerTimes.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblComputerWineerTimes.Location = new System.Drawing.Point(684, 114);
            this.lblComputerWineerTimes.Name = "lblComputerWineerTimes";
            this.lblComputerWineerTimes.Size = new System.Drawing.Size(28, 29);
            this.lblComputerWineerTimes.TabIndex = 13;
            this.lblComputerWineerTimes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Draw : ";
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawTimes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblDrawTimes.Location = new System.Drawing.Point(124, 447);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(28, 29);
            this.lblDrawTimes.TabIndex = 15;
            this.lblDrawTimes.Text = "0";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundNumber.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblRoundNumber.Location = new System.Drawing.Point(246, 496);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(28, 29);
            this.lblRoundNumber.TabIndex = 17;
            this.lblRoundNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rounds Number :";
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Olive;
            this.btnRest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(716, 493);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(139, 40);
            this.btnRest.TabIndex = 18;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // frmStonePaperScissorsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 571);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDrawTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblComputerWineerTimes);
            this.Controls.Add(this.lblPlayerWineerTimes);
            this.Controls.Add(this.imgNextComputer);
            this.Controls.Add(this.imgPlayerNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComputerScissors);
            this.Controls.Add(this.btnComputerPaper);
            this.Controls.Add(this.btnComputerStone);
            this.Controls.Add(this.btnPlayerScissors);
            this.Controls.Add(this.btnPlayerPaper);
            this.Controls.Add(this.btnPlayerStone);
            this.Controls.Add(this.del);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStonePaperScissorsGame";
            this.Text = "StonePaperScissorsGame";
            ((System.ComponentModel.ISupportInitialize)(this.imgNextComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button btnPlayerStone;
        private System.Windows.Forms.Button btnPlayerPaper;
        private System.Windows.Forms.Button btnPlayerScissors;
        private System.Windows.Forms.Button btnComputerScissors;
        private System.Windows.Forms.Button btnComputerPaper;
        private System.Windows.Forms.Button btnComputerStone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgPlayerNext;
        private System.Windows.Forms.PictureBox imgNextComputer;
        private System.Windows.Forms.Label lblPlayerWineerTimes;
        private System.Windows.Forms.Label lblComputerWineerTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRest;
    }
}