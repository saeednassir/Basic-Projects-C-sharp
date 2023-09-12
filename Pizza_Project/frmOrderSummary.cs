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
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary()
        {
            InitializeComponent();
        }

       

        private void frmOrderSummary_Load(object sender, EventArgs e)
        {
           
            
            lblValueSize.Text = Form1.GetLblValueSize();
            lblOrderToppings.Text = Form1.GetLblOrderToppings();
            lblValueCrustType.Text = Form1.GetLblValueCrustType();
            lblValueWhereToEat.Text = Form1.GetLblValueWhereToEat();
            lblValueTotoalPrice.Text = Form1.GetLblValueTotoalPrice();
            lblValueCountPizza.Text = Form1.GetLblValueCountPizza();
           
        }




    }
}
