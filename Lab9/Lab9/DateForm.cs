// Grading ID: B9073
// Lab #: 9
// Due Date: November 29, 2016 11:59 PM
// Class Section: CIS199-75
//Brief Description: Program contains a created class, the Date class, and allows the user to input a month, day, and year
// into a text box and then update the Date at the top of the form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class DateForm : Form
    {
        private Date date = new Date(1, 1, 2000); // Creates a new date object set to 1/1/00

        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load (object sender, EventArgs e) // Load event on form
        {
            dateOutputLabel.Text = date.ToString(); // Makes the dateOutputLabel display the object date made above
        }

        private void updateMonthButton_Click(object sender, EventArgs e)  // Click event for Update Month
        {
            int month; // Creates variable month of type int

            if (int.TryParse (monthTextBox.Text, out month)) // Parses data from monthTextBox, places in month
            {
                date.Month = month; // Updates the date object using the Month property with variable month
                dateOutputLabel.Text = date.ToString();  // Displays new updated month
            }
            else // If left blank
            {
                MessageBox.Show("Please enter an integer value for the Month"); // Displays MessageBox when button clicked with no input
            }
        }

        private void updateDayButton_Click(object sender, EventArgs e) // Creates click event for updateDayButton
        {
            int day; // Creates variable day of type int

            if (int.TryParse (dayTextBox.Text, out day)) // Parses data from dayTextBox and places it in day
            {
                date.Day = day; // Updates date object using Day property with day
                dateOutputLabel.Text = date.ToString(); // Displays updated date with new day
            }
            else // If left blank
            {
                MessageBox.Show("Please enter an integer value for the Day"); // Displays MessageBox when button clicked with no input
            }
        }

        private void updateYearButton_Click(object sender, EventArgs e) // Creates click event for updateYearButton
        {
            int year; // Creates variable year of type int

            if (int.TryParse (yearTextBox.Text, out year)) // Parses yearTextBox and places data in year variable
            {
                date.Year = year; // Updates date object using Year property with year
                dateOutputLabel.Text = date.ToString(); // Displays updated date with new year
            }
            else // if left blank
            {
                MessageBox.Show("Please enter an integer value for the Year"); // Displays MessageBox when button is clicked with no input
            }
        }
    }
}
