// Grading ID: B9073
// Lab Number: 5
// Due Date: 10/23/16 11:59 PM
// Course and Section: 199-75
// Brief Description: Form that allows user to input two integer values and choose which type of loop to use to display the numbers in between the values.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Click event for the Run Loop Button 
        private void runLoopButton_Click(object sender, EventArgs e)
        {
            int from; // Declares the variable from as an integer value
            int to; // Declares the variable to as an integer value
            

            if (int.TryParse(fromTextBox.Text, out from)) // Parsing data from the fromTextBox to store in from variable
            {
                if(int.TryParse(toTextBox.Text, out to)) // Parsing data from the toTextBox to store in the to variable
                {
                    if(whileRadioButton.Checked) // Says what will occur to the data entered if the while radio button is checked 
                    {
                        while(from <= to) // While loop with pretest saying to continue as long as from is less than or equal to to
                        {
                            
                            loopListBox.Items.Add(from++); // When while loop is true, display from = from + 1 in the list box
                        }
                    }
                    else if(forRadioButton.Checked) // Says what will occur to the data entered if the for radio button is checked
                    {
                        for (; from <= to; from++) // For loop saying if from is less than or equal to to, from = from + 1
                        {
                            loopListBox.Items.Add(from); // When for loop is true, display from = from + 1 in list box
                        }
                    }
                    else if(doWhileRadioButton.Checked) // Says what will occur to the data entered if the do-while radio button is checked
                    {
                        do // Initiates the do-while loop
                        {
                            loopListBox.Items.Add(from++); // Display from = from + 1 in the list box
                        } while (from <= to); // Post test that notes the loop should continue while from is less than or equal to to
                    }


                }
                else // If toTextBox is unsuccessfully parsed
                {
                    MessageBox.Show("Please enter an integer value in the To text box."); // Display a message box describing what should be entered in toTextBox
                }
            }
            else // If fromTextBox is unsuccessfully parsed
            {
                MessageBox.Show("Please enter an integer value in the From text box."); // Display a message box describing what should be entered in fromTextBox
            }
        }

        // Click event for the Clear List Button
        private void clearListButton_Click(object sender, EventArgs e)
        {
            loopListBox.Items.Clear(); // Clear entire contents of the list box 
        }
    }
}
