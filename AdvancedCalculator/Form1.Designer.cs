namespace AdvancedCalculator
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
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDiv = new ePOSOne.btnProduct.Button_WOC();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnDot = new ePOSOne.btnProduct.Button_WOC();
            this.btnN7 = new ePOSOne.btnProduct.Button_WOC();
            this.btnN4 = new ePOSOne.btnProduct.Button_WOC();
            this.btnN5 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSqrt = new ePOSOne.btnProduct.Button_WOC();
            this.btnPow = new ePOSOne.btnProduct.Button_WOC();
            this.btnEqual = new ePOSOne.btnProduct.Button_WOC();
            this.btnN0 = new ePOSOne.btnProduct.Button_WOC();
            this.btnN8 = new ePOSOne.btnProduct.Button_WOC();
            this.btnMult = new ePOSOne.btnProduct.Button_WOC();
            this.btnN9 = new ePOSOne.btnProduct.Button_WOC();
            this.btnSub = new ePOSOne.btnProduct.Button_WOC();
            this.btnN6 = new ePOSOne.btnProduct.Button_WOC();
            this.btnAdd = new ePOSOne.btnProduct.Button_WOC();
            this.btnN3 = new ePOSOne.btnProduct.Button_WOC();
            this.btnN2 = new ePOSOne.btnProduct.Button_WOC();
            this.btnN1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.White;
            this.txtScreen.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.Location = new System.Drawing.Point(0, 40);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.Size = new System.Drawing.Size(325, 53);
            this.txtScreen.TabIndex = 5;
            this.txtScreen.TabStop = false;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(253, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(28, 28);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculator";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(291, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BorderColor = System.Drawing.Color.Orange;
            this.btnDiv.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(247, 317);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnDiv.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnDiv.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDiv.Size = new System.Drawing.Size(60, 44);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Tag = "/";
            this.btnDiv.Text = "/";
            this.btnDiv.TextColor = System.Drawing.Color.OrangeRed;
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOpertion_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Orange;
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(10, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnClear.Size = new System.Drawing.Size(60, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Tag = "C";
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.OrangeRed;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDot
            // 
            this.btnDot.BorderColor = System.Drawing.Color.Orange;
            this.btnDot.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(89, 381);
            this.btnDot.Name = "btnDot";
            this.btnDot.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnDot.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnDot.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDot.Size = new System.Drawing.Size(60, 44);
            this.btnDot.TabIndex = 7;
            this.btnDot.Tag = ".";
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.White;
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnN7
            // 
            this.btnN7.BorderColor = System.Drawing.Color.Orange;
            this.btnN7.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN7.FlatAppearance.BorderSize = 0;
            this.btnN7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(10, 318);
            this.btnN7.Name = "btnN7";
            this.btnN7.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN7.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN7.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN7.Size = new System.Drawing.Size(60, 44);
            this.btnN7.TabIndex = 7;
            this.btnN7.Tag = "7";
            this.btnN7.Text = "7";
            this.btnN7.TextColor = System.Drawing.Color.White;
            this.btnN7.UseVisualStyleBackColor = true;
            this.btnN7.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnN4
            // 
            this.btnN4.BorderColor = System.Drawing.Color.Orange;
            this.btnN4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN4.FlatAppearance.BorderSize = 0;
            this.btnN4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(10, 250);
            this.btnN4.Name = "btnN4";
            this.btnN4.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN4.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN4.Size = new System.Drawing.Size(60, 44);
            this.btnN4.TabIndex = 7;
            this.btnN4.Tag = "4";
            this.btnN4.Text = "4";
            this.btnN4.TextColor = System.Drawing.Color.White;
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnN5
            // 
            this.btnN5.BorderColor = System.Drawing.Color.Orange;
            this.btnN5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN5.FlatAppearance.BorderSize = 0;
            this.btnN5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(89, 250);
            this.btnN5.Name = "btnN5";
            this.btnN5.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN5.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN5.Size = new System.Drawing.Size(60, 44);
            this.btnN5.TabIndex = 6;
            this.btnN5.Tag = "5";
            this.btnN5.Text = "5";
            this.btnN5.TextColor = System.Drawing.Color.White;
            this.btnN5.UseVisualStyleBackColor = true;
            this.btnN5.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BorderColor = System.Drawing.Color.Orange;
            this.btnSqrt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(168, 124);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnSqrt.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnSqrt.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSqrt.Size = new System.Drawing.Size(60, 44);
            this.btnSqrt.TabIndex = 7;
            this.btnSqrt.Tag = "sq";
            this.btnSqrt.Text = "√";
            this.btnSqrt.TextColor = System.Drawing.Color.OrangeRed;
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click_1);
            // 
            // btnPow
            // 
            this.btnPow.BorderColor = System.Drawing.Color.Orange;
            this.btnPow.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPow.FlatAppearance.BorderSize = 0;
            this.btnPow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(89, 124);
            this.btnPow.Name = "btnPow";
            this.btnPow.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnPow.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnPow.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPow.Size = new System.Drawing.Size(60, 44);
            this.btnPow.TabIndex = 7;
            this.btnPow.Tag = "^";
            this.btnPow.Text = "^";
            this.btnPow.TextColor = System.Drawing.Color.OrangeRed;
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnOpertion_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEqual.BorderColor = System.Drawing.Color.Orange;
            this.btnEqual.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(247, 381);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnEqual.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnEqual.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnEqual.Size = new System.Drawing.Size(60, 44);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Tag = "=";
            this.btnEqual.Text = "=";
            this.btnEqual.TextColor = System.Drawing.Color.OrangeRed;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnN0
            // 
            this.btnN0.BorderColor = System.Drawing.Color.Orange;
            this.btnN0.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN0.FlatAppearance.BorderSize = 0;
            this.btnN0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(168, 381);
            this.btnN0.Name = "btnN0";
            this.btnN0.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN0.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN0.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN0.Size = new System.Drawing.Size(60, 44);
            this.btnN0.TabIndex = 7;
            this.btnN0.Tag = "0";
            this.btnN0.Text = "0";
            this.btnN0.TextColor = System.Drawing.Color.White;
            this.btnN0.UseVisualStyleBackColor = true;
            this.btnN0.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnN8
            // 
            this.btnN8.BorderColor = System.Drawing.Color.Orange;
            this.btnN8.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN8.FlatAppearance.BorderSize = 0;
            this.btnN8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(89, 317);
            this.btnN8.Name = "btnN8";
            this.btnN8.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN8.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN8.Size = new System.Drawing.Size(60, 44);
            this.btnN8.TabIndex = 7;
            this.btnN8.Tag = "8";
            this.btnN8.Text = "8";
            this.btnN8.TextColor = System.Drawing.Color.White;
            this.btnN8.UseVisualStyleBackColor = true;
            this.btnN8.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnMult
            // 
            this.btnMult.BorderColor = System.Drawing.Color.Orange;
            this.btnMult.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(247, 250);
            this.btnMult.Name = "btnMult";
            this.btnMult.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnMult.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnMult.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnMult.Size = new System.Drawing.Size(60, 44);
            this.btnMult.TabIndex = 7;
            this.btnMult.Tag = "*";
            this.btnMult.Text = "*";
            this.btnMult.TextColor = System.Drawing.Color.OrangeRed;
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnOpertion_Click);
            // 
            // btnN9
            // 
            this.btnN9.BorderColor = System.Drawing.Color.Orange;
            this.btnN9.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN9.FlatAppearance.BorderSize = 0;
            this.btnN9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(168, 317);
            this.btnN9.Name = "btnN9";
            this.btnN9.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN9.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN9.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN9.Size = new System.Drawing.Size(60, 44);
            this.btnN9.TabIndex = 7;
            this.btnN9.Tag = "9";
            this.btnN9.Text = "9";
            this.btnN9.TextColor = System.Drawing.Color.White;
            this.btnN9.UseVisualStyleBackColor = true;
            this.btnN9.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnSub
            // 
            this.btnSub.BorderColor = System.Drawing.Color.Orange;
            this.btnSub.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(247, 183);
            this.btnSub.Name = "btnSub";
            this.btnSub.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnSub.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnSub.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSub.Size = new System.Drawing.Size(60, 44);
            this.btnSub.TabIndex = 7;
            this.btnSub.Tag = "-";
            this.btnSub.Text = "-";
            this.btnSub.TextColor = System.Drawing.Color.OrangeRed;
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOpertion_Click);
            // 
            // btnN6
            // 
            this.btnN6.BorderColor = System.Drawing.Color.Orange;
            this.btnN6.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN6.FlatAppearance.BorderSize = 0;
            this.btnN6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(168, 250);
            this.btnN6.Name = "btnN6";
            this.btnN6.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN6.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN6.Size = new System.Drawing.Size(60, 44);
            this.btnN6.TabIndex = 7;
            this.btnN6.Tag = "6";
            this.btnN6.Text = "6";
            this.btnN6.TextColor = System.Drawing.Color.White;
            this.btnN6.UseVisualStyleBackColor = true;
            this.btnN6.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Orange;
            this.btnAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(247, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnAdd.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnAdd.Size = new System.Drawing.Size(60, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOpertion_Click);
            // 
            // btnN3
            // 
            this.btnN3.BorderColor = System.Drawing.Color.Orange;
            this.btnN3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN3.FlatAppearance.BorderSize = 0;
            this.btnN3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(168, 183);
            this.btnN3.Name = "btnN3";
            this.btnN3.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN3.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN3.Size = new System.Drawing.Size(60, 44);
            this.btnN3.TabIndex = 7;
            this.btnN3.Tag = "3";
            this.btnN3.Text = "3";
            this.btnN3.TextColor = System.Drawing.Color.White;
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnN2
            // 
            this.btnN2.BorderColor = System.Drawing.Color.Orange;
            this.btnN2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN2.FlatAppearance.BorderSize = 0;
            this.btnN2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(89, 183);
            this.btnN2.Name = "btnN2";
            this.btnN2.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN2.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN2.Size = new System.Drawing.Size(60, 44);
            this.btnN2.TabIndex = 6;
            this.btnN2.Tag = "2";
            this.btnN2.Text = "2";
            this.btnN2.TextColor = System.Drawing.Color.White;
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnN1
            // 
            this.btnN1.BorderColor = System.Drawing.Color.Orange;
            this.btnN1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN1.FlatAppearance.BorderSize = 0;
            this.btnN1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(10, 183);
            this.btnN1.Name = "btnN1";
            this.btnN1.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.btnN1.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.btnN1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnN1.Size = new System.Drawing.Size(60, 44);
            this.btnN1.TabIndex = 2;
            this.btnN1.Tag = "1";
            this.btnN1.Text = "1";
            this.btnN1.TextColor = System.Drawing.Color.White;
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnN_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnN1;
        private ePOSOne.btnProduct.Button_WOC btnN2;
        private ePOSOne.btnProduct.Button_WOC btnN3;
        private ePOSOne.btnProduct.Button_WOC btnN4;
        private ePOSOne.btnProduct.Button_WOC btnN5;
        private ePOSOne.btnProduct.Button_WOC btnN7;
        private ePOSOne.btnProduct.Button_WOC btnN6;
        private ePOSOne.btnProduct.Button_WOC btnN9;
        private ePOSOne.btnProduct.Button_WOC btnN8;
        private ePOSOne.btnProduct.Button_WOC btnN0;
        private ePOSOne.btnProduct.Button_WOC btnDot;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnAdd;
        private ePOSOne.btnProduct.Button_WOC btnSub;
        private ePOSOne.btnProduct.Button_WOC btnMult;
        private ePOSOne.btnProduct.Button_WOC btnDiv;
        private ePOSOne.btnProduct.Button_WOC btnEqual;
        private ePOSOne.btnProduct.Button_WOC btnPow;
        private ePOSOne.btnProduct.Button_WOC btnSqrt;
        private System.Windows.Forms.Button btnMinimized;
    }
}

