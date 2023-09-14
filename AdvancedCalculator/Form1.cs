using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Button = System.Windows.Forms.Button;


namespace AdvancedCalculator
{
    public partial class frmMain : Form
    {

        double FirstNumber;
        string Operation;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
           Button btn = (Button)sender;

            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = btn.Tag.ToString();
            }
            else
            {
                txtScreen.Text += btn.Tag.ToString();
            }
        }

        private void btnOpertion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            FirstNumber = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
            Operation = btn.Tag.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            FirstNumber = 0;
            Operation = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "."; 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble((string)txtScreen.Text);

            switch(Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    txtScreen.Text = Result.ToString();
                    FirstNumber = Result;
                    break;

                case "-":
                    Result = FirstNumber - SecondNumber;
                    txtScreen.Text = Result.ToString();
                    FirstNumber = Result;
                    break;

                case "*":
                    Result = FirstNumber * SecondNumber;
                    txtScreen.Text = Result.ToString();
                    FirstNumber = Result;
                    break;

                case "/":
                    {
                        if (SecondNumber == 0)
                        {
                            MessageBox.Show("Canot divide by zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            Result = (FirstNumber / SecondNumber);
                            txtScreen.Text = Convert.ToString(Result);
                            FirstNumber = Result;
                        }

                        break;
                    }

                case "^":
                    Result = Math.Pow(FirstNumber, SecondNumber);
                    txtScreen.Text = Result.ToString();
                    FirstNumber = Result;
                    break;

                default:
                    Result = FirstNumber + SecondNumber;
                    txtScreen.Text = Result.ToString();
                    FirstNumber = Result;
                    break;

            }

        }

        private void btnSqrt_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Math.Sqrt(FirstNumber);
            txtScreen.Text = FirstNumber.ToString();
        }
      


        // Heder

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // #DRAGGABLE PANEL:

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
