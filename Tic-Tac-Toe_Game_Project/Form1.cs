using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game_Project.Properties;

namespace Tic_Tac_Toe_Game_Project
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        struct stGameStatus
        {
            public byte PlayCount;
            public byte WinsPlayer1;
            public byte WinsPlayer2;
            public byte Draw;
        }

        stGameStatus GameStatus;

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen Pen = new Pen(White,12);

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen,300,250,850,250);
            e.Graphics.DrawLine(Pen,300,400,850,400);


            e.Graphics.DrawLine(Pen,480,100,480,550);
            e.Graphics.DrawLine(Pen,680,100,680,550);

           

        }
        
        void DisableImage()
        {
            imgQ_0_0.Enabled = false;
            imgQ_0_1.Enabled = false;
            imgQ_0_2.Enabled = false;
            imgQ_1_0.Enabled = false;
            imgQ_1_1.Enabled = false;
            imgQ_1_2.Enabled = false;
            imgQ_2_0.Enabled = false;
            imgQ_2_1.Enabled = false;
            imgQ_2_2.Enabled = false;
        }

        bool checkWinner(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3)
        {
            if(pictureBox1.Tag.ToString() != "?" && pictureBox1.Tag.ToString() == pictureBox2.Tag.ToString() && pictureBox1.Tag.ToString() == pictureBox3.Tag.ToString())
            {
                lblWinner.Text = (pictureBox1.Tag.ToString() == "X") ? "Player 1" : "Player 2";

                if ((pictureBox1.Tag.ToString() == "X"))
                {
                    GameStatus.WinsPlayer1++;
                    lblWinsPlayer1.Text = GameStatus.WinsPlayer1.ToString();
                }
                else
                {
                    GameStatus.WinsPlayer2++;
                    lblWinsPlayer2.Text = GameStatus.WinsPlayer2.ToString();
                }

                lblGamesCount.Text = (GameStatus.WinsPlayer1 + GameStatus.WinsPlayer2 + GameStatus.Draw).ToString();

                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
                pictureBox3.BackColor = Color.Yellow;
                DisableImage();
                lblTurn.Text = "Game Over";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        bool IsWinner()
        {
            //Row

            if (checkWinner(imgQ_0_0, imgQ_0_1, imgQ_0_2))
            {
                return true;
            }

            if(checkWinner(imgQ_1_0, imgQ_1_1, imgQ_1_2))
            {
                return true;
            }


            if(checkWinner(imgQ_2_0, imgQ_2_1, imgQ_2_2))
            {
                return true;
            }



            //Coulm

            if(checkWinner(imgQ_0_0, imgQ_1_0, imgQ_2_0))
            {
                return true;
            }


            if(checkWinner(imgQ_0_1, imgQ_1_1, imgQ_2_1))
            {
                return true;
            }


            if(checkWinner(imgQ_0_2, imgQ_1_2, imgQ_2_2))
            {
                return true;
            }




            //Diagonal

            if(checkWinner(imgQ_0_0, imgQ_1_1, imgQ_2_2))
            {
                return true;
            }


            if(checkWinner(imgQ_0_2, imgQ_1_1, imgQ_2_0))
            {
                return true;
            }


            return false;

        }

        void ChangeImag(PictureBox img)
        {

            if(img.Tag.ToString() == "X" || img.Tag.ToString() == "O")
            {
                MessageBox.Show("Wrong Choice", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GameStatus.PlayCount++;

            if (lblTurn.Text == "Player 1")
            {
                img.Image = Resources.X;
                lblTurn.Text = "Player 2";

                img.Tag = "X";
            }
            else
            {
                img.Image = Resources.O;
                lblTurn.Text = "Player 1";

                img.Tag = "O";
            }


            if (!IsWinner())
            {
                if (GameStatus.PlayCount == 9)
                {
                    lblWinner.Text = "Draw";
                    lblTurn.Text = "Game Over";
                    DisableImage();
                    GameStatus.Draw++;
                    lblCountDrawing.Text = GameStatus.Draw.ToString();
                    lblGamesCount.Text = (GameStatus.WinsPlayer1 + GameStatus.WinsPlayer2 + GameStatus.Draw).ToString();

                }
            }




        }

        private void imgClick(object sender, EventArgs e)
        {
            ChangeImag((PictureBox)sender);

        }

        void RestImage(PictureBox img)
        {
            img.Image = Resources.question_mark_96;
            img.Tag = "?";
            img.Enabled = true;
            img.BackColor = Color.Black;
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            GameStatus.PlayCount = 0;

            RestImage(imgQ_0_0);
            RestImage(imgQ_0_1);
            RestImage(imgQ_0_2);
            RestImage(imgQ_1_0);
            RestImage(imgQ_1_1);
            RestImage(imgQ_1_2);
            RestImage(imgQ_2_0);
            RestImage(imgQ_2_1);
            RestImage(imgQ_2_2);

            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Prograess";


        }



    }
}
