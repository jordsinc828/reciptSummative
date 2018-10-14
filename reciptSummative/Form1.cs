using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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
            newOrderButton.Visible = false;
            subTotalAmount.Text = "";
            taxAmountLabel.Text = "";
            totalAmountLabel.Text = "";
            changeAmountLabel.Text = "";
            tenderedBox.Text = "0";
            itemOneBox.Text = "0";
            itemTwoBox.Text = "0";
            itemThreebox.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font errorFont = new Font("Times New Roman", 12, FontStyle.Underline);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            //counting amount of things purchased
            try
            {
                g.Clear(Color.White);
                amountOfBurgers = Convert.ToInt16(itemOneBox.Text);
                amountOfDrinks = Convert.ToInt16(itemTwoBox.Text);
                amountOfFries = Convert.ToInt16(itemThreebox.Text);

                //storing costs
                subTotal =
                    amountOfFries * fryCost +
                    amountOfDrinks * drinkCost +
                    amountOfBurgers * burgerCost;
                taxTotal = subTotal * taxCost;
                totalPrice = taxTotal + subTotal;

                //displaying cost
                subTotalAmount.Text = subTotal.ToString("C");
                taxAmountLabel.Text = taxTotal.ToString("C");
                totalAmountLabel.Text = totalPrice.ToString("C");
            }
            catch
            {
                subTotalAmount.Text = "";
                taxAmountLabel.Text = "";
                totalAmountLabel.Text = "";
                changeAmountLabel.Text = "";
                g.DrawString("*you must enter a value in all boxes*", errorFont, drawBrush, 240, 20);
            }
           

            
        }

        private void changeAmount_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font errorFont = new Font("Times New Roman", 12, FontStyle.Underline);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            try
            {
                //calculating and displaying change
                g.Clear(Color.White);
                amountTendered = Convert.ToDouble(tenderedBox.Text);
                changeRequired = amountTendered - totalPrice;
                changeAmountLabel.Text = changeRequired.ToString("C");
            }
            catch
            {
                g.DrawString("*you must enter a value in all boxes*", errorFont, drawBrush, 240, 20);
                changeAmountLabel.Text = "";
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawOutline = new Pen(Color.Black, 2);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SoundPlayer player = new SoundPlayer(Properties.Resources.register);
            g.Clear(Color.White);

            Font reciptTitleFont = new Font("Times New Roman", 18, FontStyle.Bold);
            Font reciptFont = new Font("Times New Roman", 12, FontStyle.Underline);


            //Building reciept
            player.Play();
            g.DrawRectangle(drawOutline, 280, 45, 180, 340);
            g.DrawString("Burger Store.", reciptTitleFont, drawBrush, 290, 55);
            Thread.Sleep(200);
            g.DrawString("Order Number 324", reciptFont, drawBrush, 285, 85);
            Thread.Sleep(200);
            g.DrawString("October 10, 2018", reciptFont, drawBrush, 285, 105);
            Thread.Sleep(200);
            g.DrawString("Burgers   x" + amountOfBurgers, reciptFont, drawBrush, 285, 140);
            Thread.Sleep(200);
            g.DrawString("Fries       x" + amountOfFries, reciptFont, drawBrush, 285, 155);
            Thread.Sleep(200);
            g.DrawString("Drinks    x" + amountOfDrinks, reciptFont, drawBrush, 285, 170);
            Thread.Sleep(200);
            g.DrawString("Subtotal         " + subTotal.ToString("C"), reciptFont, drawBrush, 285, 200);
            Thread.Sleep(200);  
            g.DrawString("Tax                " + taxTotal.ToString("C"), reciptFont, drawBrush, 285, 220);
            Thread.Sleep(200);
            g.DrawString("Total              " + totalPrice.ToString("C"), reciptFont, drawBrush, 285, 240);
            Thread.Sleep(250);
            g.DrawString("Tendered       " + amountTendered.ToString("C"), reciptFont, drawBrush, 285, 270);
            Thread.Sleep(200);
            g.DrawString("Change          " + changeRequired.ToString("C"), reciptFont, drawBrush, 285, 290);
            Thread.Sleep(200);
            g.DrawString("Have a Nice Day!", reciptFont, drawBrush, 285, 330);
            Thread.Sleep(400);
            newOrderButton.Visible = true;

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            //clearing variables
            amountOfBurgers = 0;
            amountOfFries = 0;
            amountOfDrinks = 0;
            totalPrice = 0;
            amountTendered = 0;
            taxTotal = 0;
            changeRequired = 0;
            subTotal = 0;

            //clearing labels and boxes
            newOrderButton.Visible = false;
            subTotalAmount.Text = "";
            taxAmountLabel.Text = "";
            totalAmountLabel.Text = "";
            changeAmountLabel.Text = "";
            tenderedBox.Text = "0";
            itemOneBox.Text = "0";
            itemTwoBox.Text = "0";
            itemThreebox.Text = "0";

        }
    }
}
