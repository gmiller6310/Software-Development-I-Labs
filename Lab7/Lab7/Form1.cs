//Grading ID: B9073
// Lab #: 7
// Due Date: November 6, 2016 11:59 P.M.
// Course Section: CIS199-75
// Brief Description: User inputs a desired month number and selects a language and the program returns the corresponding month in the selected language
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class lab7 : Form
    {
        public lab7()
        {
            InitializeComponent();
        }

        const int SIZE = 12; // Creates constant SIZE that is equal to 12

         // Precondition: An int value 1 - 12 must be entered in the monthTextBox
         // Postcondition: A month corresponding to the number entered will be displayed in English
         private string GetEnglishMonth(int monthNumber) // Creates GetEnglishMonth method
        {
            monthNumber = monthNumber - 1; // Takes number from text box and subtracts 1 from it and then saves the new value

            string[] months = new string [SIZE] { "January", "February", "March", "April", "May", "June", "July", "August",
                "September", "October", "November", "December" }; // Makes the array months and assigns all the english months as strings for values 0 - 11

           return outputLabel.Text = months[monthNumber].ToString(); // Method returns the course of action of displaying the month corresponding to an array value
        }

        // Precondition: An int value 1 - 12 must be entered in the monthTextBox
        // Postcondition: A month corresponding to the number entered will be displayed in Spanish
        private string GetSpanishMonth(int monthNumber) // Creates GetSpanishMethod
        {
            monthNumber = monthNumber - 1; // Takes number from text box and subtracts 1 from it and then saves the new value

            string[] months = new string [SIZE] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
                "Septiembre", "Octubre", "Noviembre", "Diciembre" }; // Makes the array months and assigns all the spanish months as strings for values 0 - 11

            return outputLabel.Text = months[monthNumber].ToString(); // Method returns the course of action of displaying the month corresponding to an array value

        }

        // Precondition: An int value 1 - 12 must be entered in the monthTextBox
        // Postcondition: A month corresponding to the number entered will be displayed in Italian
        private string GetItalianMonth(int monthNumber) // Creates GetItalianMethod
        {
            monthNumber = monthNumber - 1; // Takes number from text box and subtracts 1 from it and then saves the new value

            string[] months = new string[SIZE] { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto",
            "Settembre", "Ottobre", "Novembre", "Dicembre" }; // Makes the array months and assigns all the italian months as strings for values 0 - 11

            return outputLabel.Text = months[monthNumber].ToString(); // Method returns the course of action of displaying the month corresponding to an array value
        }

        private void lookUpButton_Click(object sender, EventArgs e) // Creates click event for the lookUpButton
        {
            int monthNumber; // Creates variable monthNumber as type int


            if (int.TryParse(monthTextBox.Text, out monthNumber)) // TryParses the monthTextBox and puts value in monthNumber

            {
                if (englishRadioButton.Checked) // Establishes what happens if parse succeeds and English is checked
                {
                    GetEnglishMonth(monthNumber); // Calls GetEnglishMonth method
                }
                else if (spanishRadioButton.Checked) // Establishes what happens if Spanish is checked
                {
                    GetSpanishMonth(monthNumber); // Calls GetSpanishMonth method
                }
                else if(italianRadioButton.Checked) // Establishes what happens if Italian is checked
                {
                    GetItalianMonth(monthNumber); // Calls GetItalianMonth method
                }
            }
            else // What happens if the TryParse fails
            {
                MessageBox.Show("Error!"); // If TryParse fails, dispalys "Error!" in a message box
            }
            
        }
        
    }
}
