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
    public partial class frmStonePaperScissorsGame : Form
    {
        public frmStonePaperScissorsGame()
        {
            InitializeComponent();
        }

        enum enWinner { Player = 1, Computer = 2, Draw = 3 }
        enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 }

        struct stRoundInfo
        {     
            public enGameChoice PlayerChoice;
            public enGameChoice ComputerChoice;
            public enWinner Winner;
            
        }

        struct stGameResults
        {
            public short GameRounds;
            public short PlayerWinTimes;
            public short ComputerWinTimes;
            public short DrawTimes;
            public enWinner GameWinner;            

        };

        stRoundInfo RoundInfo = new stRoundInfo();

        stGameResults GameResults = new stGameResults();

        Button btnClick = new Button();

        Random random = new Random();

        int RandomNumber(int From, int To)
        {
            return random.Next(From, To+1);
        }

        enGameChoice GetComputerChoice()
        {
            return (enGameChoice)RandomNumber(1, 3);
        }

        void EnableBtnPlayerChoice()
        {
            btnPlayerStone.Enabled = true;
            btnPlayerPaper.Enabled = true;
            btnPlayerScissors.Enabled = true;

        }

        void DisableBtnPlayerChoice()
        {
            btnPlayerStone.Enabled = false;
            btnPlayerPaper.Enabled = false;
            btnPlayerScissors.Enabled = false;

        }

        void changeBackColorBtnComputer()
        {
            if (RoundInfo.ComputerChoice == enGameChoice.Stone)
            {
                if (btnComputerStone.BackColor == Color.GreenYellow)
                {
                    btnComputerStone.BackColor = Color.Transparent;
                    return;
                }

                btnComputerStone.BackColor = Color.GreenYellow;
                return;

            }
            else if(RoundInfo.ComputerChoice == enGameChoice.Paper)
            {

                if (btnComputerPaper.BackColor == Color.GreenYellow)
                {
                    btnComputerPaper.BackColor = Color.Transparent;
                    return;
                }

                btnComputerPaper.BackColor = Color.GreenYellow;
                return;
            }
            else
            {
                if (btnComputerScissors.BackColor == Color.GreenYellow)
                {
                    btnComputerScissors.BackColor = Color.Transparent;
                    return;
                }

                btnComputerScissors.BackColor = Color.GreenYellow;
            }


        }

        enWinner WhoIsWinner()
        {
            if (RoundInfo.PlayerChoice == RoundInfo.ComputerChoice)
            {
                return enWinner.Draw;
            }

            switch (RoundInfo.PlayerChoice)
            {
                case enGameChoice.Stone:
                    if (RoundInfo.ComputerChoice == enGameChoice.Paper)
                    {
                        return enWinner.Computer;
                    }
                    break;

                case enGameChoice.Paper:
                    if (RoundInfo.ComputerChoice == enGameChoice.Scissors)
                    {
                        return enWinner.Computer;
                    }
                    break;

                case enGameChoice.Scissors:
                    if (RoundInfo.ComputerChoice == enGameChoice.Stone)
                    {
                        return enWinner.Computer;
                    }
                    break;
            }

            return enWinner.Player;

        }

        void WinnerTimes()
        {
            if (RoundInfo.Winner == enWinner.Player)
            {
                GameResults.PlayerWinTimes++;
                lblPlayerWineerTimes.Text = GameResults.PlayerWinTimes.ToString();
                return;

            }
            else if (RoundInfo.Winner == enWinner.Computer)
            {
                GameResults.ComputerWinTimes++;
                lblComputerWineerTimes.Text = GameResults.ComputerWinTimes.ToString();
                return;
            }
            else
            {
                GameResults.DrawTimes++;
                lblDrawTimes.Text = GameResults.DrawTimes.ToString();
            }

        }

        enWinner WhoWinnerGame()
        {

            if (GameResults.PlayerWinTimes == GameResults.ComputerWinTimes)
                return GameResults.GameWinner = enWinner.Draw;
            else if (GameResults.PlayerWinTimes > GameResults.ComputerWinTimes)
                return GameResults.GameWinner = enWinner.Player;
            else
                return GameResults.GameWinner = enWinner.Computer;
        }

        void RestGame()
        {
            GameResults.PlayerWinTimes = 0;
            GameResults.ComputerWinTimes = 0;
            GameResults.GameRounds = 0;
            GameResults.DrawTimes = 0;

            lblComputerWineerTimes.Text = "0";
            lblPlayerWineerTimes.Text = "0";
            lblDrawTimes.Text = "0";
            lblRoundNumber.Text = "0";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RestGame();
            EnableBtnPlayerChoice();

            GameResults.GameRounds = 0;
            imgPlayerNext.Visible = true;

        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            

            imgNextComputer.Visible =true;
            imgPlayerNext.Visible = false;

            btnClick = (Button)sender;

            btnClick.BackColor = Color.GreenYellow;

            GameResults.GameRounds++;
            lblRoundNumber.Text = GameResults.GameRounds.ToString();

            RoundInfo.PlayerChoice = (enGameChoice)Convert.ToInt32(btnClick.Tag);

            RoundInfo.ComputerChoice = GetComputerChoice();

            changeBackColorBtnComputer();

            RoundInfo.Winner = WhoIsWinner();

            WinnerTimes();
            if(RoundInfo.Winner == enWinner.Computer)
            {
                MessageBox.Show("Winner is Computer !", "Round Winner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show($"Winner is {RoundInfo.Winner} !", "Round Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnClick.BackColor = Color.Transparent;

            changeBackColorBtnComputer();

            imgPlayerNext.Visible = true;
            imgNextComputer.Visible = false;

            if (GameResults.GameRounds == 5)
            {
                WhoWinnerGame();
                if(WhoWinnerGame( )== enWinner.Computer)
                {
                    MessageBox.Show("Winner Game is Computer ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else
                { 
                    MessageBox.Show($"Winner Game is {GameResults.GameWinner.ToString()} !", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DisableBtnPlayerChoice();
                
            }

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestGame();
        }


    }
}
