// Grading ID: B9073
// Lab #: 8
// Due Date: November 13, 2016 11:59 P.M.
// Course Section: CIS199-75
// Brief Description: Application that allows user to input a travel distance and then receive a ticket price based on a 
// range of values that correlate.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creates a click event for the findTicketPriceButton
        private void findTicketPriceButton_Click(object sender, EventArgs e)
        {
            double tripDistance; // Creates the variable tripDistance as a double

            if (double.TryParse(tripDistanceTextBox.Text, out tripDistance)) // Parses out the user input for distance travelled and stores it in tripDistance
            {
                int[] tripDistanceLowLimit = { 0, 100, 300, 500}; // Creates an array that stores the lower limits of the ranges of trip distances
                int[] ticketPrice = { 25, 40, 55, 70}; // Creates an array that stores the ticket prices that correspond to the trip distance
                bool found = false; // Creates boolean value to help control loop, starting at false
                int customerTicket = 0; //Assume no discount for bad input

                int index = tripDistanceLowLimit.Length - 1; // Start from end
                                                              // since lower limits
                while (index >= 0 && !found) // Loop continues to perform until the index value is >= 0 and boolean value found is true
                {
                    if (tripDistance >= tripDistanceLowLimit[index]) // Checks to see if trip distance is greater than or equal to the low limit of distances array
                        found = true; // If trip distance is greater than or equal to, change boolean value found to true
                    else
                        --index; // If not greater than or equal to, subtract one from the index
                }

                if (found) // When the variable found is true...
                    customerTicket = ticketPrice[index]; // Make variable customerTicket equal to the corresponding ticketPrice according to index

                ticketPriceOutputLabel.Text = customerTicket.ToString("c"); // Display variable customerTicket on the ticketPriceOutputLabel

            }
            else
            {
                MessageBox.Show("Please enter a postive value."); // If parse fails, display "Please enter a positive value"
            }
          
        }
    }
}
