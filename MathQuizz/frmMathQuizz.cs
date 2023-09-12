using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizz
{
    public partial class frmMathQuizz : Form
    {
        public frmMathQuizz()
        {
            InitializeComponent();
        }

        enum enQuestionsLevel { EasyLevel = 1, MedLevel = 2, HardLevel = 3, Mix = 4 };

        enum enOperationType { Add = 1, Sub = 2, Mult = 3, Div = 4, MixOp = 5 };

        struct stQuestion
        {
            public int Number1;
            public int Number2;
            public enOperationType OperationType;
            public enQuestionsLevel QuestionLevel;
            public int CorrectAnswer;
            public int PlayerAnswer;
            public bool AnswerResult;

        };

        struct stQuizz
        {
            public stQuestion[] QuestionList;
            public short NumberOfQuestions;
            public enQuestionsLevel QuestionsLevel;
            public enOperationType OpType;
            public short NumberOfWrongAnswers;
            public short NumberOfRightAnswers;
            public bool isPass;
        };
        
        stQuizz Quizz =new stQuizz();

        int CounterTimer = (int)frmMain.NumberOfTime;

        Random random = new Random();

        short NumberQuestion = 0;

        int RandomNumber(int From,int To)
        { 
            return random.Next(From,To+1);
        }

        enOperationType GetRandomOperationType()
        {
            return (enOperationType)RandomNumber(1, 4);
        }

        enQuestionsLevel GetRandomQuestionsLevel()
        {
            return (enQuestionsLevel)RandomNumber(1, 3);
        }

        int SimpleCalculator(int Number1, int Number2, enOperationType OpType)
        { 
            

            switch(OpType)
            {
                case enOperationType.Add: 
                    return Number1 + Number2;

                case enOperationType.Sub: 
                    return Number1 - Number2;

                case enOperationType.Mult: 
                    return Number1 * Number2;

                case enOperationType.Div:
                    {
                        if(Number1 < Number2)
                        {
                            return 0;
                        }else
                        {
                        return Number1 / Number2;

                        }

                    }
                                  

                default: 
                    return Number1 + Number2;
            }
        }

        stQuestion GenerateQuestion(enQuestionsLevel QuestionsLevel, enOperationType OpType)
        {
            stQuestion Question = new stQuestion();

            if(QuestionsLevel == enQuestionsLevel.Mix)
            {
                QuestionsLevel = GetRandomQuestionsLevel();
            }

            if(OpType == enOperationType.MixOp)
            {
                OpType = GetRandomOperationType();
            }

            Question.OperationType = OpType;

            switch(QuestionsLevel)
            {
                case enQuestionsLevel.EasyLevel:
                {
                    Question.Number1 = RandomNumber(1, 10);
                    Question.Number2 = RandomNumber(1, 10);

                    Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
                    Question.QuestionLevel = QuestionsLevel;

                    return Question;
                }
                    
                case enQuestionsLevel.MedLevel:
                {
                        Question.Number1 = RandomNumber(10, 50);
                        Question.Number2 = RandomNumber(10, 50);

                        Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
                        Question.QuestionLevel = QuestionsLevel;

                        return Question;
                }

                case enQuestionsLevel.HardLevel:
                {
                        Question.Number1 = RandomNumber(50, 100);
                        Question.Number2 = RandomNumber(50, 100);

                        Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
                        Question.QuestionLevel = QuestionsLevel;

                        return Question;
                }
                default:
                    return Question;
            }


        }

        void GenerateQuizzQuestions()
        {
            for (int i = 0; i < Quizz.NumberOfQuestions; i++)
            {
                Quizz.QuestionList[i] = GenerateQuestion(Quizz.QuestionsLevel, Quizz.OpType);
            }
        }

        string GetOpTypeSymbol(enOperationType OpType)
        {
            switch (OpType)
            {
                case enOperationType.Add:
                    return "+";
                case enOperationType.Sub:
                    return "-";
                case enOperationType.Mult:
                    return "x";
                case enOperationType.Div:
                    return "/";
                default:
                    return "Mix";
            }

        }

        void CorrectTheQuestionAnswer(short QuestionNumber)
        {
            if (Quizz.QuestionList[QuestionNumber].CorrectAnswer != Quizz.QuestionList[QuestionNumber].PlayerAnswer)
            {
                Quizz.QuestionList[QuestionNumber].AnswerResult = false;
                Quizz.NumberOfWrongAnswers++;
            }else
            {
                Quizz.QuestionList[QuestionNumber].AnswerResult = true;
                Quizz.NumberOfRightAnswers++;
            }
        }

        bool IsPass()
        {
            return Quizz.isPass = (Quizz.NumberOfRightAnswers >= Quizz.NumberOfWrongAnswers);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();



            lblNumber1.Text = Quizz.QuestionList[NumberQuestion].Number1.ToString();
            lblNumber2.Text = Quizz.QuestionList[NumberQuestion].Number2.ToString();

            lblOpertion.Text = GetOpTypeSymbol(Quizz.QuestionList[NumberQuestion].OperationType);

            RandomAnswers();

            EnableBtnAnswers();

            btnStart.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CounterTimer--;
            lblTimer.Text = CounterTimer.ToString() + " s";

            if(CounterTimer == 0)
            {
                DisableBtnAnswers();
                timer1.Stop();
                MessageBox.Show("Time is Over","Time Over",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmMathQuizz_Load(object sender, EventArgs e)
        {
            DisableBtnAnswers();

            Quizz.NumberOfQuestions = (short)frmMain.NumberOfQuestions;
            Quizz.QuestionsLevel = (enQuestionsLevel)(frmMain.QuizzLevel+1);
            Quizz.OpType = (enOperationType)(frmMain.OpertionType+1);
            
            lblNumberOfQuestions.Text = Quizz.NumberOfQuestions.ToString();

            Quizz.QuestionList = new stQuestion[Quizz.NumberOfQuestions];

            GenerateQuizzQuestions();

            lblTimer.Text = frmMain.NumberOfTime.ToString()+" s";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SwapArray(int[] Array, int index1, int index2)
        {
            int temp = Array[index1];
            Array[index1] = Array[index2];
            Array[index2] = temp;
        }

        void RandomAnswers()
        {

            int[] arr = new int[4];

            int cAnswer = Quizz.QuestionList[NumberQuestion].CorrectAnswer;

            

            arr[0] = cAnswer;
            arr[1] = RandomNumber(cAnswer+1,cAnswer+20);

            if (Quizz.QuestionList[NumberQuestion].OperationType == enOperationType.Sub
                || Quizz.QuestionList[NumberQuestion].OperationType == enOperationType.Div)
            {
                arr[2] = RandomNumber(cAnswer - 20, cAnswer - 1);
                arr[3] = RandomNumber(cAnswer - 20, cAnswer - 1);

                
            }else
            {
                arr[2] = RandomNumber(1, cAnswer - 1);
                arr[3] = RandomNumber(1, cAnswer - 1);
            }
            

            for (int i = 0; i <= 3; i++)
            {
                SwapArray(arr, RandomNumber(0, 3), RandomNumber(0, 3));
            }

            btnResult1.Text = arr[0].ToString();
            btnResult2.Text = arr[1].ToString();
            btnResult3.Text = arr[2].ToString();
            btnResult4.Text = arr[3].ToString();


            
        }

        void DisableBtnAnswers()
        {
            btnResult1.Enabled = false; 
            btnResult2.Enabled = false;
            btnResult3.Enabled = false;
            btnResult4.Enabled = false;
        }

        void EnableBtnAnswers()
        {
            btnResult1.Enabled = true;
            btnResult2.Enabled = true;
            btnResult3.Enabled = true;
            btnResult4.Enabled = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            if (NumberQuestion+1 == Quizz.NumberOfQuestions)
            {
                timer1.Stop();
            }

            Quizz.QuestionList[NumberQuestion].PlayerAnswer = Convert.ToInt32(((Button)sender).Text);

            CorrectTheQuestionAnswer(NumberQuestion);

            if (Quizz.QuestionList[NumberQuestion].AnswerResult)
            {
                lblNumberOfCorrectAnswers.Text = Quizz.NumberOfRightAnswers.ToString();
                ((Button)sender).BackColor = Color.DarkGreen;

                MessageBox.Show("Correct answer");
            }
            else
            {
                lblNumberOfWrongAnswers.Text = Quizz.NumberOfWrongAnswers.ToString();
                ((Button)sender).BackColor = Color.DarkRed;
                                  
                MessageBox.Show("wrong answer");
            }

            ((Button)sender).BackColor = Color.Pink;

            NumberQuestion++;

            if (NumberQuestion == Quizz.NumberOfQuestions)
            {
                if (IsPass())
                {
                    MessageBox.Show("successful !", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("fail !", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DisableBtnAnswers();
                timer1.Stop();
                return;
            }

            

            

            lblNumberQuestions.Text = (NumberQuestion + 1).ToString();

            
            lblNumber1.Text = Quizz.QuestionList[NumberQuestion].Number1.ToString();
            lblNumber2.Text = Quizz.QuestionList[NumberQuestion].Number2.ToString();

            lblOpertion.Text = GetOpTypeSymbol(Quizz.QuestionList[NumberQuestion].OperationType);

            
            RandomAnswers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
