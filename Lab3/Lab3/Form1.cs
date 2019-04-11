// Grading ID: B9073
// Lab Number: 3
// Due Date: September 25, 2016 11:59 PM
// Course Section: 75
// Brief Description: Creates a tip calulator for a small, medium, and large sized tip value based on the price of the meal entered by the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class lab3Form : Form
    {
        public lab3Form()
        {
            InitializeComponent();
        }

        // Creates click event for the calculateTipButton
        private void calculateTipButton_Click(object sender, EventArgs e)
        {
            const float SMALL_TIP_RATE = .15F; // Creates constant value for the small tip rate in the float format in the form of 15%
            const float MEDIUM_TIP_RATE = .18F; // Creates constant value for the medium tip rate in the float format in the form of 18%
            const float LARGE_TIP_RATE = .20F; // Creates a constant value for the large tip rate in the float format in the form of 20%

            float priceOfMeal; // Declares a float variable named priceOfMeal that will hold the price of the meal
            float smallTipRateOutput; // Declares a float variable named smallTipRateOutput that will hold the product of priceOfMeal and SMALL_TIP_RATE
            float mediumTipRateOutput; // Declares a float variable named mediumTipRateOutput that will hold the product of priceOfMeal and MEDIUM_TIP_RATE
            float largeTipRateOutput; // Declares a float variable named mediumTipRateOutput that will hold the product of priceOfMeal and LARGE_TIP_RATE

            priceOfMeal = float.Parse(mealPriceTextBox.Text); // Takes the number entered in the mealPriceTextBox and stores it in priceOfMeal variable

            smallTipRateOutput = priceOfMeal * SMALL_TIP_RATE; // Multiplies the price of the meal by the SMALL_TIP_RATE value and stores the product in smallTipRateOutput
            smallTipOutputLabel.Text = smallTipRateOutput.ToString("c"); // Converts the smallTipRateOutput to be displayed as text in the smallTipOutputLabel

            mediumTipRateOutput = priceOfMeal * MEDIUM_TIP_RATE; // Multiplies the price of the meal by the MEDIUM_TIP_RATE value and stores the product in mediumTipRateOutput
            mediumTipOutputLabel.Text = mediumTipRateOutput.ToString("c"); // Converts the mediumTipRateOutput to be displayed as text in the mediumTipOutputLabel

            largeTipRateOutput = priceOfMeal * LARGE_TIP_RATE; // Multiplies the price of the meal by the LARGE_TIP_RATE value and stores the product in largeTipRateOutput
            largeTipOutputLabel.Text = largeTipRateOutput.ToString("c"); // Converts the largeTipRateOutput to be displayed as text in the largeTipOutputLabel


          
        }
    }
}
