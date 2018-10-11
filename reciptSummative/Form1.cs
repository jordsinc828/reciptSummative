using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reciptSummative
{
    public partial class Form1 : Form
    {
        const double burgerCost = 2.49;
        const double fryCost = 1.89;
        const double drinkCost = 0.99;
        const double taxCost = 0.13;
        int amountOfBurgers;
        int amountOfFries;
        int amountOfDrinks;
        double totalPrice;
        double amountTendered;
        double taxTotal;
        double changeRequired;
        double subTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //counting amount of things purchased
            amountOfBurgers = Convert.ToInt16(itemOneBox.Text);
            amountOfDrinks = Convert.ToInt16(itemTwoBox.Text);
            amountOfFries = Convert.ToInt16(itemThreebox.Text);

            //storing costs
            subTotal = 
                amountOfFries * fryCost +
                amountOfDrinks * drinkCost +
                amountOfBurgers * burgerCost;
            taxTotal = subTotal * taxCost;
           
            //displaying cost
            subTotalAmount.Text = subTotal + "";
            taxAmountLabel.Text = subTotal * taxCost + "";
            totalAmountLabel.Text = taxTotal + subTotal + "";

            
        }
    }
}
