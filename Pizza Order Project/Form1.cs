using System;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form
    {
        private enum enSize
        {
            Small = 10 , Medium = 20 , Large = 30 
        };
        private enum enCrustType
        {
            ThinCrust = 5 , ThickCrust = 10
        };
        private enum enToppings
        {
            ExtraChess = 8 , Onion = 3 ,  Mushrooms = 10 , Tomato = 5 , Olives = 4 , GreenPeppers = 2
        };
        private enum enWheretoEat
        {
            EatIn =5 , TakeOut =0
        };

        byte TotalPrice = 0;
        byte CountToppings = 1;
   
        // Total Prices
        byte TotalPriceOfSize = 0;
        byte TotalPriceOfToppings = 0;
        byte TotalPriceOfCrustType = 0;
   
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        // Where to Eat
        private bool IsEatIn()
        {
            return rbEatIn.Checked;
        }
        private void WheretoEatImplementation(enWheretoEat WheretoEat,char CurrencyPrfix = '$')
        {
            labelWheretoEatRes.Text = Convert.ToString(WheretoEat);

            TotalPrice = (byte)(TotalPriceOfCrustType + TotalPriceOfSize + TotalPriceOfToppings);

            if (IsEatIn())
                TotalPrice += Convert.ToByte(WheretoEat);

            labelTotalPriceRes.Text = CurrencyPrfix + Convert.ToString(TotalPrice);
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            WheretoEatImplementation(enWheretoEat.EatIn);
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            WheretoEatImplementation(enWheretoEat.TakeOut);
        }

        // Pizza Size
        private void SizeImplementation(enSize Size , char CurrencyPrfix = '$')
        {
            labelSizeRes.Text = Convert.ToString(Size);
            TotalPriceOfSize = Convert.ToByte(Size);

            if (IsEatIn())
                TotalPrice += Convert.ToByte(enWheretoEat.EatIn);

            TotalPrice = (byte)(TotalPriceOfCrustType + TotalPriceOfSize + TotalPriceOfToppings);
            labelTotalPriceRes.Text = CurrencyPrfix + Convert.ToString(TotalPrice);
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            SizeImplementation(enSize.Small);
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            SizeImplementation(enSize.Medium);
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            SizeImplementation(enSize.Large);
        }

        // Pizza Crust Type
        private void CrustTypeImplementation(enCrustType CrustType, char CurrencyPrfix = '$')
        {
            labelCrustTypeRes.Text = Convert.ToString(CrustType);
            TotalPriceOfCrustType = Convert.ToByte(CrustType);

            if (IsEatIn())
                TotalPrice += Convert.ToByte(enWheretoEat.EatIn);

            TotalPrice = (byte)(TotalPriceOfCrustType + TotalPriceOfSize + TotalPriceOfToppings);
            labelTotalPriceRes.Text = CurrencyPrfix + Convert.ToString(TotalPrice);
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            CrustTypeImplementation(enCrustType.ThinCrust);
        }
        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            CrustTypeImplementation(enCrustType.ThickCrust);
        }

        // Pizza Toppings
        private void ToppingsIsCheckedImplementation(enToppings Toppings , char CurrencyPrfix = '$')
        {
                if (labelToppingsRes.Text == "No Toppings" || labelToppingsRes.Text == "")
                    labelToppingsRes.Text = Convert.ToString(Toppings);
                else
                    labelToppingsRes.Text = labelToppingsRes.Text + ", " + Convert.ToString(Toppings);

                if (CountToppings % 2 == 0)
                    labelToppingsRes.Text = labelToppingsRes.Text + "\n";

                CountToppings++;

                TotalPriceOfToppings += Convert.ToByte(Toppings); 

                TotalPrice = (byte)(TotalPriceOfCrustType + TotalPriceOfSize + TotalPriceOfToppings);

                if (rbEatIn.Checked)
                    TotalPrice += Convert.ToByte(enWheretoEat.EatIn);

                labelTotalPriceRes.Text = CurrencyPrfix + Convert.ToString(TotalPrice);    
        }
        private void ToppingsProcessIsNotChecked(enToppings Toppings, char CurrencyPrfix = '$')
        {
                if (labelToppingsRes.Text[0] == Convert.ToString(Toppings)[0])
                    labelToppingsRes.Text = labelToppingsRes.Text.Replace(Convert.ToString(Toppings), "");
                else
                    labelToppingsRes.Text = labelToppingsRes.Text.Replace(", " + Convert.ToString(Toppings), "");

                if (CountToppings % 2 == 0)
                    labelToppingsRes.Text = labelToppingsRes.Text.Replace("\n", "");

                CountToppings--;

                TotalPriceOfToppings -= Convert.ToByte(Toppings);

                TotalPrice = (byte)(TotalPriceOfCrustType + TotalPriceOfSize + TotalPriceOfToppings);

                if (rbEatIn.Checked)
                    TotalPrice += Convert.ToByte(enWheretoEat.EatIn);

                labelTotalPriceRes.Text = CurrencyPrfix + Convert.ToString(TotalPrice);       
        }
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraChees.Checked)
                ToppingsIsCheckedImplementation(enToppings.ExtraChess);
            else
                ToppingsProcessIsNotChecked(enToppings.ExtraChess);
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
                ToppingsIsCheckedImplementation(enToppings.Onion);
            else
                ToppingsProcessIsNotChecked(enToppings.Onion);
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
                ToppingsIsCheckedImplementation(enToppings.Mushrooms);
            else
                ToppingsProcessIsNotChecked(enToppings.Mushrooms);
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
                ToppingsIsCheckedImplementation(enToppings.Olives);
            else
                ToppingsProcessIsNotChecked(enToppings.Olives);
        }
        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomato.Checked)
                ToppingsIsCheckedImplementation(enToppings.Tomato);
            else
                ToppingsProcessIsNotChecked(enToppings.Tomato);
        }
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPeppers.Checked)
                ToppingsIsCheckedImplementation(enToppings.GreenPeppers);
            else
                ToppingsProcessIsNotChecked(enToppings.GreenPeppers);
        }

        // Program Buttons
        private void btnPickOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    panelPizzaComponent.Enabled = false;                
            }
        }
        private void btnRestOrder_Click(object sender, EventArgs e)
        {
            panelPizzaComponent.Enabled = true;

            labelSizeRes.Text = "NULL";
            labelToppingsRes.Text = "No Toppings";
            labelCrustTypeRes.Text = "NULL";
            labelWheretoEatRes.Text = "NULL";
            labelTotalPriceRes.Text = "$0";

            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            rbThinCrust.Checked = false;
            rbThinkCrust.Checked = false;
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;
            
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;   
            chkOlives.Checked = false;  
            chkTomato.Checked = false; 
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
        }

      
    }
}
