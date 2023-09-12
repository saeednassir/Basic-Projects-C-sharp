using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn_SignUp_Basic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsernameSignUp.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordSignUp.Text))
            {
                MessageBox.Show("Enter Username and Password !", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if(listView1.Items.Count > 0)
            {
                foreach(ListViewItem item in listView1.Items)
                {
                    if(item.Text == txtUsernameSignUp.Text)
                    {
                        MessageBox.Show("Username already exists !", "User Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
            }

            ListViewItem Item = new ListViewItem();

            Item.Text = txtUsernameSignUp.Text;
            Item.SubItems.Add(txtPasswordSignUp.Text);
            Item.SubItems.Add(txtAgeSignUp.Text);
            Item.Tag = txtPasswordSignUp.Text;
            listView1.Items.Add(Item);

            MessageBox.Show("The user has been added successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsernameSignUp.Clear();
            txtPasswordSignUp.Clear();
            txtAgeSignUp.Clear();
        }

        bool CheckValidPasswordAndUsername()
        {
            foreach (ListViewItem Item in listView1.Items)
            {
                if (txtUserNameSignIn.Text == Item.Text &&
                     mtxtPasswordSignIn.Text == Item.Tag.ToString())
                {
                    return true;
                }
            }

           return false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
                if (CheckValidPasswordAndUsername())
                {
                    MessageBox.Show("You are logged in successfully", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserNameSignIn.Clear();
                    mtxtPasswordSignIn.Clear();
                }
                else
                {
                    txtUserNameSignIn.Clear();
                    mtxtPasswordSignIn.Clear();
                    MessageBox.Show("Invalid password or username", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            {
                mtxtPasswordSignIn.UseSystemPasswordChar = false;
               
            }
            else
            {
                mtxtPasswordSignIn.UseSystemPasswordChar = true;
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), ((TextBox)sender).Name + " you should have a value!");
            }else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender),"");

            }
        }

        private void mtxtPasswordSignIn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtPasswordSignIn.Text))
            {
                e.Cancel = true;
                mtxtPasswordSignIn.Focus();
                errorProvider1.SetError(mtxtPasswordSignIn, mtxtPasswordSignIn.Name + " you should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtPasswordSignIn, "");

            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                listView1.SelectedItems[0].Remove();
                MessageBox.Show("The user has been removed successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                MessageBox.Show("Not selected User !", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRemoveAllUsers_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Remove();
                }
                    MessageBox.Show("The user has been removed all users successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Found Users !", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



    }
}
