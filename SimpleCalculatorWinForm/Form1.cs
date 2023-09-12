using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
               
                label6.Text = label4.Text;

                label4.Text = (Convert.ToSingle(textBox1.Text) +
                   Convert.ToSingle(textBox2.Text)).ToString();
            }
           else
            {
                MessageBox.Show("Enter Number 1  and 2 !","alerat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label6.Text = label4.Text;

                label4.Text = (Convert.ToSingle(textBox1.Text) -
                    Convert.ToSingle(textBox2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Enter Number 1  and 2 !","alerat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label6.Text = label4.Text;

                label4.Text = (Convert.ToSingle(textBox1.Text) *
                    Convert.ToSingle(textBox2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Enter Number 1  and 2 !","alerat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label6.Text = label4.Text;

                label4.Text = (Convert.ToSingle(textBox1.Text) /
                    Convert.ToSingle(textBox2.Text)).ToString();

            }
            else
            {
                MessageBox.Show("Enter Number 1  and 2 !","alerat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you want clear?","Confirm!"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                label4.Text = "0";
                label6.Text = "0";
            }
            
           
        }
    }
}
