namespace MathQuizz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.cbOpertionType = new System.Windows.Forms.ComboBox();
            this.cbQuizzLevel = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.nudNumberOfTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quizz Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opertion Type";
            // 
            // nudNumberOfQuestions
            // 
            this.nudNumberOfQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(220)))), ((int)(((byte)(181)))));
            this.nudNumberOfQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfQuestions.ForeColor = System.Drawing.Color.Indigo;
            this.nudNumberOfQuestions.Location = new System.Drawing.Point(455, 165);
            this.nudNumberOfQuestions.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfQuestions.Name = "nudNumberOfQuestions";
            this.nudNumberOfQuestions.Size = new System.Drawing.Size(47, 27);
            this.nudNumberOfQuestions.TabIndex = 3;
            this.nudNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbOpertionType
            // 
            this.cbOpertionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(220)))), ((int)(((byte)(181)))));
            this.cbOpertionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpertionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOpertionType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpertionType.ForeColor = System.Drawing.Color.Indigo;
            this.cbOpertionType.FormattingEnabled = true;
            this.cbOpertionType.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mixed"});
            this.cbOpertionType.Location = new System.Drawing.Point(427, 247);
            this.cbOpertionType.Name = "cbOpertionType";
            this.cbOpertionType.Size = new System.Drawing.Size(103, 27);
            this.cbOpertionType.TabIndex = 4;
            // 
            // cbQuizzLevel
            // 
            this.cbQuizzLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(220)))), ((int)(((byte)(181)))));
            this.cbQuizzLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuizzLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuizzLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuizzLevel.ForeColor = System.Drawing.Color.Indigo;
            this.cbQuizzLevel.FormattingEnabled = true;
            this.cbQuizzLevel.Items.AddRange(new object[] {
            " Easy",
            "Medium",
            "Hard",
            "Mixed"});
            this.cbQuizzLevel.Location = new System.Drawing.Point(427, 206);
            this.cbQuizzLevel.Name = "cbQuizzLevel";
            this.cbQuizzLevel.Size = new System.Drawing.Size(103, 27);
            this.cbQuizzLevel.TabIndex = 5;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(220)))), ((int)(((byte)(181)))));
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartGame.FlatAppearance.BorderSize = 2;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Indigo;
            this.btnStartGame.Location = new System.Drawing.Point(328, 327);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(93, 38);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // nudNumberOfTime
            // 
            this.nudNumberOfTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(220)))), ((int)(((byte)(181)))));
            this.nudNumberOfTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfTime.ForeColor = System.Drawing.Color.Indigo;
            this.nudNumberOfTime.Location = new System.Drawing.Point(455, 126);
            this.nudNumberOfTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudNumberOfTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfTime.Name = "nudNumberOfTime";
            this.nudNumberOfTime.Size = new System.Drawing.Size(47, 27);
            this.nudNumberOfTime.TabIndex = 8;
            this.nudNumberOfTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number Of Time(s)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudNumberOfTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.cbQuizzLevel);
            this.Controls.Add(this.cbOpertionType);
            this.Controls.Add(this.nudNumberOfQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Math Quizz";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumberOfQuestions;
        private System.Windows.Forms.ComboBox cbOpertionType;
        private System.Windows.Forms.ComboBox cbQuizzLevel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.NumericUpDown nudNumberOfTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

