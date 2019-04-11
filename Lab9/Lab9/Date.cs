// Grading ID: B9073
// Lab #: 9
// Due Date: November 29, 2016 11:59 PM
// Class Section: CIS199-75
//Brief Description: Program contains a created class, the Date class, and allows the user to input a month, day, and year
// into a text box and then update the Date at the top of the form.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Date
    {
        private int _month; // Creates backing field for month
        private int _day; // Creates backing field for day
        private int _year; // Creates backing field for year

        public Date(int m = 0, int d = 0, int y = 0) // Creates constructor for the Date
        {
            Month = m; // set the Month property
            Day = d; // set the Day property
            Year = y; // set the Year property
        }

        public void SetDate(int m, int d, int y) // Creates method for setting the date
        {
            Month = m; // set using the Month property
            Day = d; // set using the Day property
            Year = y; // set using the Year property
        }

        public int Month // Creates Month property
        {
            // Precondition:  None
            // Postcondition: The month has been returned
            get
            {
                return _month; // Return backing field 
            }

            // Precondition:  1 <= value <= 12
            // Postcondition: The month has been set to the specified value
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value; // If input follows requirements, set the backing field equal to the value
                else 
                    _month = 1; // When invalid, set to 1 instead
            }
        }

        public int Day // Creates Month property
        {
            // Precondition:  None
            // Postcondition: The day has been returned
            get
            {
                return _day; // Return backing field
            }

            // Precondition:  1 <= value < 31
            // Postcondition: The day has been set to the specified value
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value; // If conditions are met, set backing field equal to value
                else 
                    _day = 1; // When invalid, set to 1 instead
            }
        }

        public int Year // Creates Year property
        {
            // Precondition:  None
            // Postcondition: The year has been returned
            get
            {
                return _year; // Return year backing field
            }

            // Precondition:  value >= 0
            // Postcondition: The year has been set to the specified value
            set
            {
                if (value >= 0)
                    _year = value; // If conditions are met, set backing field equal to value
                else 
                    _year = 2000; // When invalid, set to 2000 instead
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the date
        public override string ToString() // Creates Method ToString
        {
            string result; // Builds result in steps

            result = Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year.ToString("D4"); // Takes all information and displays it in the correct format 

            return result; // ToString when called, gives this value
        }
    }
}
