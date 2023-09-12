using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Paper_Scissors_Game
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStarGame_Click(object sender, EventArgs e)
        {
            Form frm = new frmStonePaperScissorsGame();
            frm.Show();
        }
    }
}
