using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmDigitalClock.Enabled = true;
            timer1.Enabled = true;
        }

        private void tmDigitalClock_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("سبحان الله");
        }
    }
}
