using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private static string varLblValueSize = "";
        private static string varLblOrderToppings = "";
        private static string varLblValueCrustType = "";
        private static string varLblValueWhereToEat = "";
        private static string varLblValueTotoalPrice = "";
        public static string varLblValueCountPizza = "";

        public static string GetLblValueSize()
        {
            return varLblValueSize;
        }
        public static string GetLblOrderToppings()
        {
            return varLblOrderToppings;
        }
        public static string GetLblValueCrustType()
        {
           return varLblValueCrustType;
        }
        public static string GetLblValueWhereToEat()
        {
            return varLblValueWhereToEat;
        }
        public static string GetLblValueTotoalPrice()
        {
            return varLblValueTotoalPrice;
        }
        public static string GetLblValueCountPizza()
        {
            return varLblValueCountPizza;
        }

        float GetSelectedSizePrice()
        {
            if(rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            
            else if(rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

            
        }

        float GetSelectedCrustTypePrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThinkCrust.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppongsTotalPrice = 0;

            if (chkExtraChees.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);

            if(chkMushrooms.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            if(chkTomatoes.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            if(chkOnion.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkOnion.Tag);

            if(chkOlives.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkOlives.Tag);

            if(chkGreenPeppers.Checked)
                ToppongsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            return ToppongsTotalPrice;

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustTypePrice();
        }       

        void UpdateTotalPrice()
        {
            lblValueTotoalPrice.Text = CalculateTotalPrice().ToString();
            
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblValueSize.Text = "Small";             
                return;
            }

            if (rbMeduim.Checked)
            {
                lblValueSize.Text = "Meduim";
                return;
            }
            else
                lblValueSize.Text = "Large";

        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblValueCrustType.Text = "Thin Crust";               
                return;
            }
            else
                lblValueCrustType.Text = "Think Crust";
            
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            
            if(chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }

            if(chkMushrooms.Checked) 
            {
                sToppings += ", Mushrooms";
            }

            if(chkTomatoes.Checked) 
            {
                sToppings += ", Tomatoes";
            }

            if(chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if(chkOlives.Checked)
            {
                sToppings += ", Olive";
            }

            if(chkGreenPeppers.Checked)
            {
                sToppings += ", GreenPeppers";
            }

            if (sToppings.StartsWith(","))
            {
               sToppings = sToppings.Substring(1,sToppings.Length-1).Trim();
            }

            if(string.IsNullOrWhiteSpace(sToppings))
            {
                sToppings = "No Toppings";
            }

            lblOrderToppings.Text = sToppings;
            
        }
     
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblValueWhereToEat.Text = "Eat In";              
                return;
            }
            else
                lblValueWhereToEat.Text = "Take Out";

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
            
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }


        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }


        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void btnRestForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCtustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbMeduim.Checked = true;

            rbThinCrust.Checked = true;

            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            //btnOrderPizza.Enabled = true;
            chkReadyToOrder.Enabled = true;
            chkReadyToOrder.Checked = false;

            rbEatIn.Checked = true;

            lblValueSize.Text = "Meduim";
            lblValueCrustType.Text = "Thin Crust";
            lblValueWhereToEat.Text = "Eat In";

            nudCountPizaa.Value = 1;

            UpdateTotalPrice();

        }

        private void chkReadyToOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(chkReadyToOrder.Checked)
                btnOrderPizza.Enabled = true;
            else
                btnOrderPizza.Enabled = false;       
            
        }

        void ShowNotifyIconOrder()
        {
            notifyOrder.Icon = SystemIcons.Application;
            notifyOrder.BalloonTipIcon = ToolTipIcon.None;
            notifyOrder.BalloonTipTitle = "Order Pizza";
            notifyOrder.BalloonTipText = "Your pizza order has been sent successfully.";
            notifyOrder.ShowBalloonTip(10000);
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Confirm Order ?","Confirm",MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                GetValueToFormOrderSummary();
                ShowNotifyIconOrder();
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                Form frm = new frmOrderSummary();
                frm.ShowDialog();

                gbSize.Enabled = false;
                gbCtustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
                chkReadyToOrder.Enabled = false;
                
            }


        }

        void GetValueToFormOrderSummary()
        {
            varLblValueSize = lblValueSize.Text;
            varLblValueTotoalPrice = lblValueTotoalPrice.Text;
            varLblValueCrustType = lblValueCrustType.Text;
            varLblOrderToppings = lblOrderToppings.Text;
            varLblValueWhereToEat = lblValueWhereToEat.Text;
            varLblValueCountPizza = nudCountPizaa.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            lblValueTotoalPrice.Text = ((float)nudCountPizaa.Value * CalculateTotalPrice()).ToString(); ;
        }


    }
}
