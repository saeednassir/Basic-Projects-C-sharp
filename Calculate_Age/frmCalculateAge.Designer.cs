namespace Calculate_Age
{
    partial class frmCalculateAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculateAge));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDaysNumber = new System.Windows.Forms.Label();
            this.lblHoursNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinutesNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSecondsNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWeeksNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYourAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Calculate_Age.Properties.Resources.bgfrmCalcAge;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ضع تاريخ ميلادك";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(128, 201);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "أحسب";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dtpAge
            // 
            this.dtpAge.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAge.Location = new System.Drawing.Point(104, 160);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.RightToLeftLayout = true;
            this.dtpAge.Size = new System.Drawing.Size(148, 20);
            this.dtpAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "عدد الأيام :";
            // 
            // lblDaysNumber
            // 
            this.lblDaysNumber.AutoSize = true;
            this.lblDaysNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysNumber.Location = new System.Drawing.Point(119, 295);
            this.lblDaysNumber.Name = "lblDaysNumber";
            this.lblDaysNumber.Size = new System.Drawing.Size(15, 16);
            this.lblDaysNumber.TabIndex = 5;
            this.lblDaysNumber.Text = "0";
            // 
            // lblHoursNumber
            // 
            this.lblHoursNumber.AutoSize = true;
            this.lblHoursNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursNumber.Location = new System.Drawing.Point(119, 327);
            this.lblHoursNumber.Name = "lblHoursNumber";
            this.lblHoursNumber.Size = new System.Drawing.Size(15, 16);
            this.lblHoursNumber.TabIndex = 7;
            this.lblHoursNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "عدد الساعات :";
            // 
            // lblMinutesNumber
            // 
            this.lblMinutesNumber.AutoSize = true;
            this.lblMinutesNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesNumber.Location = new System.Drawing.Point(121, 357);
            this.lblMinutesNumber.Name = "lblMinutesNumber";
            this.lblMinutesNumber.Size = new System.Drawing.Size(15, 16);
            this.lblMinutesNumber.TabIndex = 9;
            this.lblMinutesNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "عدد الدقائق :";
            // 
            // lblSecondsNumber
            // 
            this.lblSecondsNumber.AutoSize = true;
            this.lblSecondsNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsNumber.Location = new System.Drawing.Point(278, 295);
            this.lblSecondsNumber.Name = "lblSecondsNumber";
            this.lblSecondsNumber.Size = new System.Drawing.Size(15, 16);
            this.lblSecondsNumber.TabIndex = 11;
            this.lblSecondsNumber.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "عدد الثواني :";
            // 
            // lblWeeksNumber
            // 
            this.lblWeeksNumber.AutoSize = true;
            this.lblWeeksNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeksNumber.Location = new System.Drawing.Point(296, 327);
            this.lblWeeksNumber.Name = "lblWeeksNumber";
            this.lblWeeksNumber.Size = new System.Drawing.Size(15, 16);
            this.lblWeeksNumber.TabIndex = 13;
            this.lblWeeksNumber.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "عدد الاسابيع :";
            // 
            // lblYourAge
            // 
            this.lblYourAge.AutoSize = true;
            this.lblYourAge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAge.Location = new System.Drawing.Point(84, 263);
            this.lblYourAge.Name = "lblYourAge";
            this.lblYourAge.Size = new System.Drawing.Size(64, 16);
            this.lblYourAge.TabIndex = 14;
            this.lblYourAge.Text = "عمرك هو";
            // 
            // frmCalculateAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 484);
            this.Controls.Add(this.lblYourAge);
            this.Controls.Add(this.lblWeeksNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSecondsNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMinutesNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHoursNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDaysNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculateAge";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "أحسب عمرك";
            this.Load += new System.EventHandler(this.frmCalculateAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDaysNumber;
        private System.Windows.Forms.Label lblHoursNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinutesNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSecondsNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWeeksNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYourAge;
    }
}