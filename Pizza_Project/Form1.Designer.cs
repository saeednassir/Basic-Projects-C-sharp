namespace Pizza_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCtustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.nudCountPizaa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderToppings = new System.Windows.Forms.Label();
            this.lblValueTotoalPrice = new System.Windows.Forms.Label();
            this.lblDollarMark = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblValueWhereToEat = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblValueCrustType = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblValueSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnRestForm = new System.Windows.Forms.Button();
            this.chkReadyToOrder = new System.Windows.Forms.CheckBox();
            this.notifyOrder = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbSize.SuspendLayout();
            this.gbCtustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPizaa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(190, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(469, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSize.Location = new System.Drawing.Point(21, 99);
            this.gbSize.Name = "gbSize";
            this.gbSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSize.Size = new System.Drawing.Size(143, 159);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(24, 92);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(57, 20);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(24, 56);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(70, 20);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "20";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(24, 30);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(57, 20);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCtustType
            // 
            this.gbCtustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCtustType.Controls.Add(this.rbThinkCrust);
            this.gbCtustType.Controls.Add(this.rbThinCrust);
            this.gbCtustType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCtustType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCtustType.Location = new System.Drawing.Point(21, 282);
            this.gbCtustType.Name = "gbCtustType";
            this.gbCtustType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCtustType.Size = new System.Drawing.Size(143, 158);
            this.gbCtustType.TabIndex = 5;
            this.gbCtustType.TabStop = false;
            this.gbCtustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(24, 56);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(89, 20);
            this.rbThinkCrust.TabIndex = 7;
            this.rbThinkCrust.Tag = "5";
            this.rbThinkCrust.Text = "Think Ctust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(24, 30);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(84, 20);
            this.rbThinCrust.TabIndex = 6;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbToppings.Location = new System.Drawing.Point(200, 99);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(278, 159);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(153, 105);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(110, 20);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "3";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(152, 68);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(60, 20);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "3";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(153, 31);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(59, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "3";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(20, 105);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(83, 20);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "3";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(20, 68);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(92, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(20, 31);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(94, 20);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbWhereToEat.Location = new System.Drawing.Point(200, 282);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbWhereToEat.Size = new System.Drawing.Size(278, 76);
            this.gbWhereToEat.TabIndex = 8;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(109, 30);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(77, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(24, 30);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(58, 20);
            this.rbEatIn.TabIndex = 9;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.nudCountPizaa);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Controls.Add(this.lblOrderToppings);
            this.gbOrderSummary.Controls.Add(this.lblValueTotoalPrice);
            this.gbOrderSummary.Controls.Add(this.lblDollarMark);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblValueWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblValueCrustType);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblValueSize);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOrderSummary.Location = new System.Drawing.Point(498, 113);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(281, 327);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // nudCountPizaa
            // 
            this.nudCountPizaa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountPizaa.Location = new System.Drawing.Point(128, 293);
            this.nudCountPizaa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCountPizaa.Name = "nudCountPizaa";
            this.nudCountPizaa.Size = new System.Drawing.Size(62, 27);
            this.nudCountPizaa.TabIndex = 13;
            this.nudCountPizaa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCountPizaa.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Count Pizza : ";
            // 
            // lblOrderToppings
            // 
            this.lblOrderToppings.Location = new System.Drawing.Point(10, 106);
            this.lblOrderToppings.Name = "lblOrderToppings";
            this.lblOrderToppings.Size = new System.Drawing.Size(265, 53);
            this.lblOrderToppings.TabIndex = 11;
            this.lblOrderToppings.Text = "No Toppings.";
            // 
            // lblValueTotoalPrice
            // 
            this.lblValueTotoalPrice.AutoSize = true;
            this.lblValueTotoalPrice.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTotoalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblValueTotoalPrice.Location = new System.Drawing.Point(158, 237);
            this.lblValueTotoalPrice.Name = "lblValueTotoalPrice";
            this.lblValueTotoalPrice.Size = new System.Drawing.Size(36, 38);
            this.lblValueTotoalPrice.TabIndex = 9;
            this.lblValueTotoalPrice.Text = "0";
            // 
            // lblDollarMark
            // 
            this.lblDollarMark.AutoSize = true;
            this.lblDollarMark.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarMark.ForeColor = System.Drawing.Color.Green;
            this.lblDollarMark.Location = new System.Drawing.Point(125, 237);
            this.lblDollarMark.Name = "lblDollarMark";
            this.lblDollarMark.Size = new System.Drawing.Size(36, 38);
            this.lblDollarMark.TabIndex = 8;
            this.lblDollarMark.Text = "$";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(25, 237);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 19);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price : ";
            // 
            // lblValueWhereToEat
            // 
            this.lblValueWhereToEat.AutoSize = true;
            this.lblValueWhereToEat.Location = new System.Drawing.Point(135, 203);
            this.lblValueWhereToEat.Name = "lblValueWhereToEat";
            this.lblValueWhereToEat.Size = new System.Drawing.Size(40, 16);
            this.lblValueWhereToEat.TabIndex = 6;
            this.lblValueWhereToEat.Text = "Eat In";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(25, 200);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(101, 19);
            this.lblWhereToEat.TabIndex = 5;
            this.lblWhereToEat.Text = "Where to Eat :";
            // 
            // lblValueCrustType
            // 
            this.lblValueCrustType.AutoSize = true;
            this.lblValueCrustType.Location = new System.Drawing.Point(109, 172);
            this.lblValueCrustType.Name = "lblValueCrustType";
            this.lblValueCrustType.Size = new System.Drawing.Size(66, 16);
            this.lblValueCrustType.TabIndex = 4;
            this.lblValueCrustType.Text = "Thin Crust";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(28, 169);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(91, 19);
            this.lblCrustType.TabIndex = 3;
            this.lblCrustType.Text = "Crust Type : ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(28, 81);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(82, 19);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings : ";
            // 
            // lblValueSize
            // 
            this.lblValueSize.AutoSize = true;
            this.lblValueSize.Location = new System.Drawing.Point(74, 47);
            this.lblValueSize.Name = "lblValueSize";
            this.lblValueSize.Size = new System.Drawing.Size(52, 16);
            this.lblValueSize.TabIndex = 1;
            this.lblValueSize.Text = "Meduim";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(28, 44);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 19);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size : ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Enabled = false;
            this.btnOrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderPizza.Location = new System.Drawing.Point(197, 409);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(106, 31);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnRestForm
            // 
            this.btnRestForm.BackColor = System.Drawing.Color.Transparent;
            this.btnRestForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnRestForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestForm.Location = new System.Drawing.Point(328, 409);
            this.btnRestForm.Name = "btnRestForm";
            this.btnRestForm.Size = new System.Drawing.Size(106, 31);
            this.btnRestForm.TabIndex = 10;
            this.btnRestForm.Text = "Rest Form";
            this.btnRestForm.UseVisualStyleBackColor = false;
            this.btnRestForm.Click += new System.EventHandler(this.btnRestForm_Click);
            // 
            // chkReadyToOrder
            // 
            this.chkReadyToOrder.AutoSize = true;
            this.chkReadyToOrder.BackColor = System.Drawing.Color.Transparent;
            this.chkReadyToOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkReadyToOrder.Location = new System.Drawing.Point(200, 383);
            this.chkReadyToOrder.Name = "chkReadyToOrder";
            this.chkReadyToOrder.Size = new System.Drawing.Size(101, 17);
            this.chkReadyToOrder.TabIndex = 6;
            this.chkReadyToOrder.Text = "Ready to Order";
            this.chkReadyToOrder.UseVisualStyleBackColor = false;
            this.chkReadyToOrder.CheckedChanged += new System.EventHandler(this.chkReadyToOrder_CheckedChanged);
            // 
            // notifyOrder
            // 
            this.notifyOrder.Text = "notifyIcon1";
            this.notifyOrder.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1076, 543);
            this.Controls.Add(this.chkReadyToOrder);
            this.Controls.Add(this.btnRestForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCtustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCtustType.ResumeLayout(false);
            this.gbCtustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPizaa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.GroupBox gbCtustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblValueSize;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblValueCrustType;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblValueWhereToEat;
        private System.Windows.Forms.Label lblValueTotoalPrice;
        private System.Windows.Forms.Label lblDollarMark;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnRestForm;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.CheckBox chkReadyToOrder;
        private System.Windows.Forms.Label lblOrderToppings;
        private System.Windows.Forms.NotifyIcon notifyOrder;
        private System.Windows.Forms.NumericUpDown nudCountPizaa;
        private System.Windows.Forms.Label label1;
    }
}

