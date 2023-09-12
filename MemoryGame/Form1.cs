using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MemoryGame.Properties;

namespace MemoryGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        Image[] images = new Image[16];

        byte CountDurationGame = 30;

        bool isFirstClick = true;

        byte PrevTag;

        PictureBox PrevPicture;

        PictureBox CurrentPicture;

        byte NumberOfIdenticalClicks = 0;

      


        void FillArrayImages()
        {
            images[0] = Resources.Cat;
            images[1] = Resources.Dog;
            images[2] = Resources.Lion;
            images[3] = Resources.Trutle;
            images[4] = Resources.Panda;
            images[5] = Resources.Penguin;
            images[6] = Resources.Checken;
            images[7] = Resources.Monkey;

            images[8] = Resources.Cat;
            images[9] = Resources.Dog;
            images[10] = Resources.Lion;
            images[11] = Resources.Trutle;
            images[12] = Resources.Panda;
            images[13] = Resources.Penguin;
            images[14] = Resources.Checken;
            images[15] = Resources.Monkey;

        }

        byte RandomNumber(byte num1, byte num2)
        {
            return Convert.ToByte(rnd.Next(num1, num2));
        }

        void SwappingArrayImages(Image[] images, byte index1, byte index2)
        {
            Image temp = images[index1];
            images[index1] = images[index2];
            images[index2] = temp;
        }

        void EnabledPictures()
        {
            pbQuestion1.Enabled = true;
            pbQuestion2.Enabled = true;
            pbQuestion3.Enabled = true;
            pbQuestion4.Enabled = true;
            pbQuestion5.Enabled = true;
            pbQuestion6.Enabled = true;
            pbQuestion7.Enabled = true;
            pbQuestion8.Enabled = true;
            pbQuestion9.Enabled = true;
            pbQuestion10.Enabled = true;
            pbQuestion11.Enabled = true;
            pbQuestion12.Enabled = true;
            pbQuestion13.Enabled = true;
            pbQuestion14.Enabled = true;
            pbQuestion15.Enabled = true;
            pbQuestion16.Enabled = true;
        }

        void DisabledPictures()
        {
            pbQuestion1.Enabled = false;
            pbQuestion2.Enabled = false;
            pbQuestion3.Enabled = false;
            pbQuestion4.Enabled = false;
            pbQuestion5.Enabled = false;
            pbQuestion6.Enabled = false;
            pbQuestion7.Enabled = false;
            pbQuestion8.Enabled = false;
            pbQuestion9.Enabled = false;
            pbQuestion10.Enabled = false;
            pbQuestion11.Enabled = false;
            pbQuestion12.Enabled = false;
            pbQuestion13.Enabled = false;
            pbQuestion14.Enabled = false;
            pbQuestion15.Enabled = false;
            pbQuestion16.Enabled = false;
        }

        void FillPicturesBoxToImages()
        {
            pbQuestion1.Image = images[0];
            pbQuestion2.Image = images[1];
            pbQuestion3.Image = images[2];
            pbQuestion4.Image = images[3];
            pbQuestion5.Image = images[4];
            pbQuestion6.Image = images[5];
            pbQuestion7.Image = images[6];
            pbQuestion8.Image = images[7];
            pbQuestion9.Image = images[8];
            pbQuestion10.Image = images[9];
            pbQuestion11.Image = images[10];
            pbQuestion12.Image = images[11];
            pbQuestion13.Image = images[12];
            pbQuestion14.Image = images[13];
            pbQuestion15.Image = images[14];
            pbQuestion16.Image = images[15];                       
           

        }

        void ChangePicturesRandomly()
        {
            FillArrayImages();

            for (byte i = 0; i < 16; i++)
            {
                SwappingArrayImages(images, RandomNumber(0, 16),
                                            RandomNumber(0, 16));

            }

            FillPicturesBoxToImages();

        }

        void FillPicturesBoxToQuestionImage()
        {
            pbQuestion1.Image = Resources.Question;
            pbQuestion2.Image = Resources.Question;
            pbQuestion3.Image = Resources.Question;
            pbQuestion4.Image = Resources.Question;
            pbQuestion5.Image = Resources.Question;
            pbQuestion6.Image = Resources.Question;
            pbQuestion7.Image = Resources.Question;
            pbQuestion8.Image = Resources.Question;
            pbQuestion9.Image = Resources.Question;
            pbQuestion10.Image = Resources.Question;
            pbQuestion11.Image = Resources.Question;
            pbQuestion12.Image = Resources.Question;
            pbQuestion13.Image = Resources.Question;
            pbQuestion14.Image = Resources.Question;
            pbQuestion15.Image = Resources.Question;
            pbQuestion16.Image = Resources.Question;
        }

        bool AreImagesEqual(Image image1, Image image2)
        {
            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);

            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
            {
                return false;
            }

            for (int x = 0; x < bitmap1.Width; x++)
            {
                for (int y = 0; y < bitmap1.Height; y++)
                {
                    if (bitmap1.GetPixel(x, y) != bitmap2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        void Win()
        {
            NumberOfIdenticalClicks = 0;
            tmDurationGame.Stop();
            MessageBox.Show("Congratulations, you win! \n" + "The duration it took was "+(30-CountDurationGame-1)+" seconds ", "Win",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CountDurationGame = 30;
            btnStart.Enabled = true;
        }

        void Play(PictureBox picture)
        {
            if (isFirstClick)
            {
                // The first click

                byte tag = Convert.ToByte(picture.Tag);
       
                picture.Image = images[tag];

                PrevPicture = picture;
                PrevTag = tag;

                picture.Enabled = false;

                isFirstClick = false;

            }
            else
            {
                // The second click

                Image img = images[Convert.ToByte(picture.Tag)];
                picture.Image = img;

                picture.Enabled = false;

                CurrentPicture = picture;

                if (AreImagesEqual(images[PrevTag], img))
                {
                    // The two pictures are identical

                    picture.Image = img;
                    PrevPicture.Image = images[PrevTag];

                    picture.Enabled = false;
                    PrevPicture.Enabled = false;

                    NumberOfIdenticalClicks++;

                    if(NumberOfIdenticalClicks == 8) 
                    {
                        // If all pictures match he wins

                        Win();
                    }

                }
                else
                {
                    // The two pictures are different

                    tmShowImageForMoment.Start();
                }

                isFirstClick= true;

            }
        }
     
        private void pbQuestion_Click(object sender, EventArgs e)
        {
            Play((PictureBox)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePicturesRandomly();
            tmStartGame.Start();
        }

        private void tmStartGame_Tick(object sender, EventArgs e)
        {
            FillPicturesBoxToQuestionImage();
            EnabledPictures();
            tmDurationGame.Start();
            btnStart.Enabled = false;
            tmStartGame.Stop();
        }

        void DurationExpired()
        {
            CountDurationGame = 31;
            tmDurationGame.Stop();
            NumberOfIdenticalClicks = 0;
            DisabledPictures();
            MessageBox.Show("Game Over", "Game Over",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnStart.Enabled = true;
        }

        private void tmDurationGame_Tick(object sender, EventArgs e)
        {
            lblGameDurationValue.Text = CountDurationGame.ToString() + " s";

            if (CountDurationGame == 0)
            {
                DurationExpired();
            }
            CountDurationGame--;
        }

        private void tmShowTic_Tick(object sender, EventArgs e)
        {
            CurrentPicture.Image = Resources.Question;
            PrevPicture.Image = Resources.Question;

            CurrentPicture.Enabled = true;
            PrevPicture.Enabled = true;

            tmShowImageForMoment.Stop();
        }


    }
}
