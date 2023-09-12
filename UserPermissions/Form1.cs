using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserPermissions
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        sbyte Permtions = 0;

        void chkPermtionsAllUser(TreeNode nodes , Boolean isCheck)
        {
            

            foreach (TreeNode node in nodes.Nodes)
            {
                
               node.Checked = isCheck;

                if(node.Nodes.Count > 0)
                {
                    this.chkPermtionsAllUser(nodes,isCheck);
                }
            }
        }

        
        List<TreeNode> chkNodes = new List<TreeNode>();

        void FillListUserPermtionsChecked(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if(node.Checked)
                {
                    chkNodes.Add(node);
                }else
                {
                    FillListUserPermtionsChecked(node.Nodes);
                }
            }
        }

        void GetUserPermtions()
        {
            FillListUserPermtionsChecked(treeViewPermtions.Nodes);

            List<TreeNode> nodes = chkNodes;

            foreach (TreeNode node in nodes)
            {
                if (sbyte.Parse(node.Tag.ToString()) == -1)
                {
                    Permtions = -1;
                    break;
                }
                else
                {
                    Permtions += sbyte.Parse(node.Tag.ToString());              
                }
               
            }

            if (Permtions == 7)
            {
                Permtions = -1;
            }

        }

        void AddUser()
        {
            GetUserPermtions();

            ListViewItem item = new ListViewItem();

            item.Text = txtID.Text.Trim();
            item.SubItems.Add(txtFirstName.Text.Trim());
            item.SubItems.Add(txtLastName.Text.Trim());
            item.SubItems.Add(Permtions.ToString());

            listViewUserPermtions.Items.Add(item);

            RestInput();
        }

        void UpdateUser()
        {
            GetUserPermtions();

            if (listViewUserPermtions.SelectedItems.Count > 0)
            {
                listViewUserPermtions.SelectedItems[0].SubItems[0].Text = txtID.Text.Trim();
                listViewUserPermtions.SelectedItems[0].SubItems[1].Text = txtFirstName.Text.Trim();
                listViewUserPermtions.SelectedItems[0].SubItems[2].Text = txtLastName.Text.Trim();
                listViewUserPermtions.SelectedItems[0].SubItems[3].Text = Permtions.ToString().Trim();
            }

            RestInput();
        }

        void DeleteUser()
        {
            if (listViewUserPermtions.SelectedItems.Count > 0)
            {
                listViewUserPermtions.SelectedItems[0].Remove();
            }
        }

        void DeleteAllUser()
        {
            while (listViewUserPermtions.Items.Count > 0)
            {
                listViewUserPermtions.Items.RemoveAt(0);
            }
        }

        void RestInput()
        {
            // clear input
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            Permtions = 0;
            chkPermtionsAllUser(treeViewPermtions.TopNode, false);
            treeViewPermtions.TopNode.Checked = false;
            chkNodes.Clear();
        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
      
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAllUser();
        }

        private void treeViewPermtions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            chkPermtionsAllUser(e.Node, e.Node.Checked);

        }


    }
}
