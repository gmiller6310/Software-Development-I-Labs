// Grading ID: B9073
// Lab Number: 2
// Due Date: September 18, 2016
// Course Section: 75
// Brief Description: This program takes data input from the user in th form of their First Name, Middle Name, Last Name, and Preferred Title and displays them combined in different formats.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class lab2Form : Form
    {
        public lab2Form()
        {
            InitializeComponent();
        }

        // Creates a click event for the format1Button to display input in format 1.
        private void format1Button_Click(object sender, EventArgs e)
        {
            string format1; // Creates a string variable that holds the value of the preferredTitleTextBox, firstNameTextBox, middleNameTextBox, and the lastNameTextBox.
          

            format1 = preferredTitleTextBox.Text + " " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text; // Defines what the string variable format1 consists of.

            formattedNameLabel.Text = format1; // Takes the value of the String format1 and displays its value on the formattedNameLabel.
        }

        // Creates a click event for the format2Button to display input in format 2.
        private void format2Button_Click(object sender, EventArgs e)
        {
            string format2; // Creates a string variable that holds the value of the firstNameTextBox, middleNameTextBox, and lastNameTextBox

            format2 = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text; // Defines what the string variable format2 consists of.

            formattedNameLabel.Text = format2; // Takes the value of the String format2 and displays its value on the formattedNameLabel.
        }

        // Creates a click event for the format3Button to display input in format 3.
        private void format3Button_Click(object sender, EventArgs e)
        {
            string format3; // Creates a string variable that holds the value of the firstNameTextBox and lastNameTextBox.

            format3 = firstNameTextBox.Text + " " + lastNameTextBox.Text; // Defines what the string variable format3 consists of.

            formattedNameLabel.Text = format3; // Takes the value of the String format3 and displays its value on the formattedNameLabel.
        }

        // Creates a click event for the format4Button to display input in format 4.
        private void format4Button_Click(object sender, EventArgs e)
        {
            string format4; // Creates a string variable that holds the value of the lastNameTextBox, firstNameTextBox, middleNameTextBox, and preferredTitleTextBox.

            format4 = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + preferredTitleTextBox.Text; // Defines what the string variable format 4 consists of.

            formattedNameLabel.Text = format4; // Takes the value of the String format4 and displays its value on the formattedNameLabel.
        }

        // Creates a click event for the format5Button to display input in format 5.
        private void format5Button_Click(object sender, EventArgs e)
        {
            string format5; // Creates a string variable that holds the value of the lastNameTextBox, firstNameTextBox, and middleNameTextBox.

            format5 = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text; // Defines what the string variable format5 consists of.

            formattedNameLabel.Text = format5; // Takes the value of the string format5 and displays its value on the formattedNameLabel.
        }

        // Creates a click event for the format6Button to display input in format 6.
        private void format6Button_Click(object sender, EventArgs e)
        {
            string format6; // Creates a string variable tat holds the value of the lastNameTextBox and the firstNameTextBox.

            format6 = lastNameTextBox.Text + ", " + firstNameTextBox.Text; // Defines what the string variable format 6 consists of.

            formattedNameLabel.Text = format6; // Takes the value of the string format6 and displats its value on the formattedNameLabel.
        }
    }
    }

