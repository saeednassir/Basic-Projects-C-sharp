namespace SignIn_SignUp_Basic
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSignIn = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.mtxtPasswordSignIn = new System.Windows.Forms.MaskedTextBox();
            this.lblTitleSignIn = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUserNameSignIn = new System.Windows.Forms.TextBox();
            this.lblPasswordSignIn = new System.Windows.Forms.Label();
            this.lblUserNameSignIn = new System.Windows.Forms.Label();
            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAgeSignUp = new System.Windows.Forms.TextBox();
            this.lblAgeSignUp = new System.Windows.Forms.Label();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.lblTitleSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.lblPasswordSignUp = new System.Windows.Forms.Label();
            this.lblUserNameSignUp = new System.Windows.Forms.Label();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnRemoveAllUsers = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabSignIn);
            this.tabControlMain.Controls.Add(this.tabSignUp);
            this.tabControlMain.Controls.Add(this.tabTable);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(361, 512);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabSignIn
            // 
            this.tabSignIn.BackColor = System.Drawing.Color.White;
            this.tabSignIn.BackgroundImage = global::SignIn_SignUp_Basic.Properties.Resources.bg;
            this.tabSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSignIn.Controls.Add(this.pictureBox1);
            this.tabSignIn.Controls.Add(this.chkShowPassword);
            this.tabSignIn.Controls.Add(this.mtxtPasswordSignIn);
            this.tabSignIn.Controls.Add(this.lblTitleSignIn);
            this.tabSignIn.Controls.Add(this.btnSignIn);
            this.tabSignIn.Controls.Add(this.txtUserNameSignIn);
            this.tabSignIn.Controls.Add(this.lblPasswordSignIn);
            this.tabSignIn.Controls.Add(this.lblUserNameSignIn);
            this.tabSignIn.Location = new System.Drawing.Point(4, 25);
            this.tabSignIn.Name = "tabSignIn";
            this.tabSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignIn.Size = new System.Drawing.Size(353, 483);
            this.tabSignIn.TabIndex = 0;
            this.tabSignIn.Text = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SignIn_SignUp_Basic.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(78, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkShowPassword.Location = new System.Drawing.Point(131, 342);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(113, 17);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // mtxtPasswordSignIn
            // 
            this.mtxtPasswordSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPasswordSignIn.Location = new System.Drawing.Point(131, 309);
            this.mtxtPasswordSignIn.Name = "mtxtPasswordSignIn";
            this.mtxtPasswordSignIn.Size = new System.Drawing.Size(152, 27);
            this.mtxtPasswordSignIn.TabIndex = 1;
            this.mtxtPasswordSignIn.UseSystemPasswordChar = true;
            this.mtxtPasswordSignIn.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPasswordSignIn_Validating);
            // 
            // lblTitleSignIn
            // 
            this.lblTitleSignIn.AutoSize = true;
            this.lblTitleSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSignIn.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSignIn.ForeColor = System.Drawing.Color.Teal;
            this.lblTitleSignIn.Location = new System.Drawing.Point(97, 177);
            this.lblTitleSignIn.Name = "lblTitleSignIn";
            this.lblTitleSignIn.Size = new System.Drawing.Size(157, 42);
            this.lblTitleSignIn.TabIndex = 6;
            this.lblTitleSignIn.Text = "Sign In";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(131, 407);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(113, 39);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUserNameSignIn
            // 
            this.txtUserNameSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameSignIn.Location = new System.Drawing.Point(131, 265);
            this.txtUserNameSignIn.Name = "txtUserNameSignIn";
            this.txtUserNameSignIn.Size = new System.Drawing.Size(152, 27);
            this.txtUserNameSignIn.TabIndex = 0;
            this.txtUserNameSignIn.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblPasswordSignIn
            // 
            this.lblPasswordSignIn.AutoSize = true;
            this.lblPasswordSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPasswordSignIn.Location = new System.Drawing.Point(23, 309);
            this.lblPasswordSignIn.Name = "lblPasswordSignIn";
            this.lblPasswordSignIn.Size = new System.Drawing.Size(98, 19);
            this.lblPasswordSignIn.TabIndex = 2;
            this.lblPasswordSignIn.Text = "Password :";
            // 
            // lblUserNameSignIn
            // 
            this.lblUserNameSignIn.AutoSize = true;
            this.lblUserNameSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameSignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserNameSignIn.Location = new System.Drawing.Point(23, 263);
            this.lblUserNameSignIn.Name = "lblUserNameSignIn";
            this.lblUserNameSignIn.Size = new System.Drawing.Size(102, 19);
            this.lblUserNameSignIn.TabIndex = 1;
            this.lblUserNameSignIn.Text = "Username :";
            // 
            // tabSignUp
            // 
            this.tabSignUp.BackgroundImage = global::SignIn_SignUp_Basic.Properties.Resources.bg;
            this.tabSignUp.Controls.Add(this.pictureBox2);
            this.tabSignUp.Controls.Add(this.txtAgeSignUp);
            this.tabSignUp.Controls.Add(this.lblAgeSignUp);
            this.tabSignUp.Controls.Add(this.txtPasswordSignUp);
            this.tabSignUp.Controls.Add(this.lblTitleSignUp);
            this.tabSignUp.Controls.Add(this.btnSignUp);
            this.tabSignUp.Controls.Add(this.txtUsernameSignUp);
            this.tabSignUp.Controls.Add(this.lblPasswordSignUp);
            this.tabSignUp.Controls.Add(this.lblUserNameSignUp);
            this.tabSignUp.Location = new System.Drawing.Point(4, 25);
            this.tabSignUp.Name = "tabSignUp";
            this.tabSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignUp.Size = new System.Drawing.Size(353, 483);
            this.tabSignUp.TabIndex = 1;
            this.tabSignUp.Text = "Sign Up";
            this.tabSignUp.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SignIn_SignUp_Basic.Properties.Resources.signup;
            this.pictureBox2.Location = new System.Drawing.Point(102, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // txtAgeSignUp
            // 
            this.txtAgeSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeSignUp.Location = new System.Drawing.Point(128, 352);
            this.txtAgeSignUp.Name = "txtAgeSignUp";
            this.txtAgeSignUp.Size = new System.Drawing.Size(152, 27);
            this.txtAgeSignUp.TabIndex = 2;
            // 
            // lblAgeSignUp
            // 
            this.lblAgeSignUp.AutoSize = true;
            this.lblAgeSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeSignUp.Location = new System.Drawing.Point(70, 360);
            this.lblAgeSignUp.Name = "lblAgeSignUp";
            this.lblAgeSignUp.Size = new System.Drawing.Size(52, 19);
            this.lblAgeSignUp.TabIndex = 14;
            this.lblAgeSignUp.Text = "Age :";
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(128, 310);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(152, 27);
            this.txtPasswordSignUp.TabIndex = 1;
            this.txtPasswordSignUp.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblTitleSignUp
            // 
            this.lblTitleSignUp.AutoSize = true;
            this.lblTitleSignUp.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSignUp.ForeColor = System.Drawing.Color.Teal;
            this.lblTitleSignUp.Location = new System.Drawing.Point(95, 189);
            this.lblTitleSignUp.Name = "lblTitleSignUp";
            this.lblTitleSignUp.Size = new System.Drawing.Size(167, 42);
            this.lblTitleSignUp.TabIndex = 12;
            this.lblTitleSignUp.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(148, 408);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(113, 39);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(128, 268);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(152, 27);
            this.txtUsernameSignUp.TabIndex = 0;
            this.txtUsernameSignUp.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lblPasswordSignUp
            // 
            this.lblPasswordSignUp.AutoSize = true;
            this.lblPasswordSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignUp.Location = new System.Drawing.Point(24, 310);
            this.lblPasswordSignUp.Name = "lblPasswordSignUp";
            this.lblPasswordSignUp.Size = new System.Drawing.Size(98, 19);
            this.lblPasswordSignUp.TabIndex = 9;
            this.lblPasswordSignUp.Text = "Password :";
            // 
            // lblUserNameSignUp
            // 
            this.lblUserNameSignUp.AutoSize = true;
            this.lblUserNameSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameSignUp.Location = new System.Drawing.Point(20, 268);
            this.lblUserNameSignUp.Name = "lblUserNameSignUp";
            this.lblUserNameSignUp.Size = new System.Drawing.Size(102, 19);
            this.lblUserNameSignUp.TabIndex = 8;
            this.lblUserNameSignUp.Text = "Username :";
            // 
            // tabTable
            // 
            this.tabTable.BackgroundImage = global::SignIn_SignUp_Basic.Properties.Resources.bg;
            this.tabTable.Controls.Add(this.btnRemoveAllUsers);
            this.tabTable.Controls.Add(this.btnRemoveUser);
            this.tabTable.Controls.Add(this.label1);
            this.tabTable.Controls.Add(this.listView1);
            this.tabTable.Location = new System.Drawing.Point(4, 25);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(353, 483);
            this.tabTable.TabIndex = 2;
            this.tabTable.Text = "Table";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users Table";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chPassword,
            this.chAge});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 109;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 104;
            // 
            // chAge
            // 
            this.chAge.Text = "Age";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(103, 399);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(137, 33);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnRemoveAllUsers
            // 
            this.btnRemoveAllUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllUsers.Location = new System.Drawing.Point(87, 438);
            this.btnRemoveAllUsers.Name = "btnRemoveAllUsers";
            this.btnRemoveAllUsers.Size = new System.Drawing.Size(170, 33);
            this.btnRemoveAllUsers.TabIndex = 3;
            this.btnRemoveAllUsers.Text = "Remove All Users";
            this.btnRemoveAllUsers.UseVisualStyleBackColor = true;
            this.btnRemoveAllUsers.Click += new System.EventHandler(this.btnRemoveAllUsers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 512);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SignIn&SignUp";
            this.tabControlMain.ResumeLayout(false);
            this.tabSignIn.ResumeLayout(false);
            this.tabSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSignUp.ResumeLayout(false);
            this.tabSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabTable.ResumeLayout(false);
            this.tabTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSignIn;
        private System.Windows.Forms.TabPage tabSignUp;
        private System.Windows.Forms.Label lblUserNameSignIn;
        private System.Windows.Forms.Label lblTitleSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUserNameSignIn;
        private System.Windows.Forms.Label lblPasswordSignIn;
        private System.Windows.Forms.MaskedTextBox mtxtPasswordSignIn;
        private System.Windows.Forms.Label lblTitleSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label lblPasswordSignUp;
        private System.Windows.Forms.Label lblUserNameSignUp;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.TextBox txtAgeSignUp;
        private System.Windows.Forms.Label lblAgeSignUp;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveAllUsers;
        private System.Windows.Forms.Button btnRemoveUser;
    }
}

