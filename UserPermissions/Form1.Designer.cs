namespace UserPermissions
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Select All", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPermtions = new System.Windows.Forms.Label();
            this.treeViewPermtions = new System.Windows.Forms.TreeView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.listViewUserPermtions = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPermtions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblID.Location = new System.Drawing.Point(35, 343);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID  :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(164, 346);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(164, 386);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(31, 386);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(127, 23);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(164, 426);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastName.Location = new System.Drawing.Point(32, 426);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 23);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(108, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 42);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "User Permtions";
            // 
            // lblPermtions
            // 
            this.lblPermtions.AutoSize = true;
            this.lblPermtions.BackColor = System.Drawing.Color.Transparent;
            this.lblPermtions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermtions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPermtions.Location = new System.Drawing.Point(305, 326);
            this.lblPermtions.Name = "lblPermtions";
            this.lblPermtions.Size = new System.Drawing.Size(120, 23);
            this.lblPermtions.TabIndex = 8;
            this.lblPermtions.Text = "Permtions :";
            // 
            // treeViewPermtions
            // 
            this.treeViewPermtions.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeViewPermtions.CheckBoxes = true;
            this.treeViewPermtions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeViewPermtions.Location = new System.Drawing.Point(304, 352);
            this.treeViewPermtions.Name = "treeViewPermtions";
            treeNode1.Name = "nodeAddUser";
            treeNode1.Tag = "1";
            treeNode1.Text = "Add User";
            treeNode2.Name = "nodeUpdateUser";
            treeNode2.Tag = "2";
            treeNode2.Text = "Update";
            treeNode3.Name = "nodeDeleteUser";
            treeNode3.Tag = "4";
            treeNode3.Text = "Delete";
            treeNode4.Name = "nodeSelectAll";
            treeNode4.Tag = "-1";
            treeNode4.Text = "Select All";
            this.treeViewPermtions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewPermtions.Size = new System.Drawing.Size(121, 97);
            this.treeViewPermtions.TabIndex = 4;
            this.treeViewPermtions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermtions_AfterCheck);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(35, 502);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(104, 35);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(163, 502);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(104, 35);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(291, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(419, 502);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(115, 35);
            this.btnDeleteAll.TabIndex = 13;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // listViewUserPermtions
            // 
            this.listViewUserPermtions.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewUserPermtions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewUserPermtions.BackgroundImage")));
            this.listViewUserPermtions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chFirstName,
            this.chLastName,
            this.chPermtions});
            this.listViewUserPermtions.FullRowSelect = true;
            this.listViewUserPermtions.GridLines = true;
            this.listViewUserPermtions.HideSelection = false;
            this.listViewUserPermtions.Location = new System.Drawing.Point(38, 83);
            this.listViewUserPermtions.Name = "listViewUserPermtions";
            this.listViewUserPermtions.Size = new System.Drawing.Size(512, 215);
            this.listViewUserPermtions.TabIndex = 14;
            this.listViewUserPermtions.UseCompatibleStateImageBehavior = false;
            this.listViewUserPermtions.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First Name";
            this.chFirstName.Width = 130;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Last Name";
            this.chLastName.Width = 130;
            // 
            // chPermtions
            // 
            this.chPermtions.Text = "Permtions";
            this.chPermtions.Width = 130;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 571);
            this.Controls.Add(this.listViewUserPermtions);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.treeViewPermtions);
            this.Controls.Add(this.lblPermtions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPermtions;
        private System.Windows.Forms.TreeView treeViewPermtions;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.ListView listViewUserPermtions;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chPermtions;
    }
}

