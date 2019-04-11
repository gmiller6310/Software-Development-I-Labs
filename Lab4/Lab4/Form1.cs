// Grading ID: B9073
// Lab Number: 4
// Due Date: October 2, 2016 11:59 PM
// Course Section: 75
// Brief Description: Tool that determines whether someone is accepted or rejected to a school based off of GPA and an admission test, and keeps a running total of accepts and rejects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class lab4Form : Form
    {
        int accepted = 0; // Creates accepted field for running total
        int rejected = 0; // Creates rejected field for running total

        public lab4Form()
        {
            InitializeComponent();
        }

        // Creates click event for the calculateButton
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double gpaInput; // Declares gpaInput as a double variable
            int admissionTest; // Declares admissionTest as an integer variable
            bool acceptance; // Declares acceptance as a boolean variable

            if (double.TryParse(gpaTextBox.Text, out gpaInput)) // Starts if statement for TryParsing the gpaTextBox and storing its value in gpaInput
            {
                if (int.TryParse(admissionTestTextBox.Text, out admissionTest)) // If first parse succeeds, store admissionTestTextBox value in admissionTest
                {
                    if (gpaInput >= 3.0 & admissionTest >= 60 || gpaInput < 3.0 & admissionTest >= 80) // If both parses succeed use stored values to test if conditions for acceptance are met
                    {
                        acceptance = true; // States that boolean value is either true...
                    }
                    else
                    {
                        acceptance = false; // ...or false
                    }
                    if (acceptance) // If true:
                    {
                        resultOutputLabel.Text = "Accepted"; // Display the text "Accepted" on the label if either condition is met
                        accepted = accepted + 1; // Increases running total of accepted by 1 if true
                        acceptedTotalLabel.Text = accepted.ToString("n0"); // Display the value of accepted field on acceptedTotalLabel using ToString in number format with 0 decimal places
                    }
                    if (!acceptance) // If false:
                    {
                        resultOutputLabel.Text = "Rejected"; // Display the text "Rejected" on the label if neither condition is met
                        rejected = rejected + 1; // Increases running total of rejected by 1 if not true
                        rejectedTotalLabel.Text = rejected.ToString("n0"); // Display the value of rejected on rejectedTotalLabel using ToString in number format with 0 decimal places
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for admission score"); // If parsing the admission score did not work a message box will appear stating there is an invalid score
                }
            }
            else
            {
                MessageBox.Show("Invalid input for GPA"); // If parsing the GPA did not work a message box will appear stating there is an invalid GPA
            }
        }    
        

    }
}
