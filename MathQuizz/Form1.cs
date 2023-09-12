using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static decimal NumberOfTime = 1;
        public static decimal NumberOfQuestions = 1;
        public static int QuizzLevel = 1;
        public static int OpertionType = 1;
        

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(nudNumberOfTime.Value == 0 || nudNumberOfQuestions.Value == 0 ||  
                cbOpertionType.Text == "" || cbQuizzLevel.Text == "")
            {
                MessageBox.Show("Enter values !", "Required",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            NumberOfTime = nudNumberOfTime.Value;
            NumberOfQuestions = nudNumberOfQuestions.Value;
            QuizzLevel = cbQuizzLevel.SelectedIndex;
            OpertionType = cbOpertionType.SelectedIndex;


            Form frm = new frmMathQuizz();
            frm.Show();

        }
    }
}
