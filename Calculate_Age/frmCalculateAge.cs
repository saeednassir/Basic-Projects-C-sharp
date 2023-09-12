using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Age
{
    public partial class frmCalculateAge : Form
    {
        public frmCalculateAge()
        {
            InitializeComponent();
        }

        struct stCulcAge
        {
            public int DaysNumber;
            public int HoursNumber;
            public int MinutesNumber;
            public int SecondsNumber;
            public int WeeksNumber;

            public byte years ;
            public byte Months ;
            public byte Days ;

        }

        

        int CalcDaysNumber(DateTimePicker Date)
        {
            int DaysNumber = 1;

            while (Date.Value.Date.ToString() != DateTime.Now.Date.ToString() && dtpAge.Value.AddDays(DaysNumber).Date.ToString() != DateTime.Now.Date.ToString())
            {
                DaysNumber++;
            }

            return DaysNumber;
        }

        int CalcHoursNumber(int DaysNumber) 
        {
            return DaysNumber * 24;
        }

        int CalcMinutesNumber(int DaysNumber) 
        {
            return CalcHoursNumber(DaysNumber) * 60;
        }

        int CalcSecondsNumber(int DaysNumber) 
        {
            return CalcMinutesNumber(DaysNumber) * 60;
        }

        int CalcWeeksNumber(int DaysNumber)
        {
            return DaysNumber / 7;
        }

        byte CalcYears(int DaysNumber) 
        {
            return Convert.ToByte(DaysNumber / 365);
        }

        byte CalcMonths(int DaysNumber)
        {
            return Convert.ToByte((DaysNumber % 365) / 30);
        }

        byte CalcDays(int DaysNumber)
        {
            return Convert.ToByte((DaysNumber % 365) % 30);
        }

        stCulcAge CalculateAge(DateTimePicker Date)
        {
            stCulcAge CalcAge;

            CalcAge.DaysNumber = CalcDaysNumber(Date);

            CalcAge.HoursNumber = CalcHoursNumber(CalcAge.DaysNumber);

            CalcAge.MinutesNumber = CalcMinutesNumber(CalcAge.DaysNumber);

            CalcAge.SecondsNumber = CalcSecondsNumber(CalcAge.DaysNumber);

            CalcAge.WeeksNumber = CalcWeeksNumber(CalcAge.DaysNumber);

            CalcAge.years = CalcYears(CalcAge.DaysNumber);

            CalcAge.Months = CalcMonths(CalcAge.DaysNumber);

            CalcAge.Days = CalcDays(CalcAge.DaysNumber);
            return CalcAge;
        }

        void ShowCalculateAge()
        {
            stCulcAge CalcAge = CalculateAge(dtpAge);

            lblDaysNumber.Text = CalcAge.DaysNumber.ToString();
            lblHoursNumber.Text = CalcAge.HoursNumber.ToString();
            lblMinutesNumber.Text = CalcAge.MinutesNumber.ToString();
            lblSecondsNumber.Text = CalcAge.SecondsNumber.ToString();
            lblWeeksNumber.Text = CalcAge.WeeksNumber.ToString();

            lblYourAge.Text = $"العمر: {CalcAge.years} سنة، {CalcAge.Months} شهر  ، {CalcAge.Days} يوم";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ShowCalculateAge();
        }


        private void frmCalculateAge_Load(object sender, EventArgs e)
        {
            dtpAge.MaxDate = DateTime.Now;

        }


    }
}
