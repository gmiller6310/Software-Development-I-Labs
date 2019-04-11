// Grading ID: B9073
// Lab #: 6
// Due Date: October 30, 2016 11:59 PM
// Course Section: CIS199-75
// Brief Description: Uses nested loops to generate patterns of stars in different formations.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pattern A
            Console.Write("Pattern A"); // Writes "Pattern A" into the writing
            Console.WriteLine(); // Tells code to go to the next line

            const int MAX_ROWS = 10; // Creates constant int MAX_ROWS and makes it equal to 10
            const int MIN_ROWS = 1; // Creates constant int MIN_ROWS and makes it equal to 1

            for (int row = 1; row <= MAX_ROWS; row++) // for outer loop that adds rows until it reaches the value of MAX_ROWS
            {
                for (int star = 1; star <= row; star++) // for inner loop that adds stars for every row
                    Console.Write("*"); // Writes a star equivalent to the number of rows per line
                Console.WriteLine(); // Tells code to go to next line
            }

            // Pattern B
            Console.WriteLine(); // Tells code to go to next line
            Console.Write("Pattern B"); // Writes "Pattern B" into the writing
            Console.WriteLine(); // Tells code to go to the next line

            for (int row = 10; row >= MIN_ROWS; row--) // for outer loop that subtracts rows until it reaches value of MIN_ROWS
            {
                for (int star = 1; star <= row; star++) // for inner loop that adds stars for every row
                    Console.Write("*"); // Writes a star euivalent to the number of rows per line
                Console.WriteLine(); // Tells code to go to next line
            }

            // Pattern C
            Console.WriteLine(); // Tells code to go to next line
            Console.Write("Pattern C"); // Writes "Pattern C" into the writing
            Console.WriteLine(); // Tells code to go to the next line of code

            for (int row = 10; row >= MIN_ROWS; row--) // for outer loop that subtracts rows until it reaches value of MIN_ROWS
            {
                for (int spaces = 10; spaces >= row; spaces--) // for inner loop that subtracts spaces for every row
                    Console.Write(" "); // Writes a space equivalent to the number of rows per line
                for (int star = 1; star <= row; star++) // for inner loop that adds stars for every row
                    Console.Write("*"); // Writes a star equivalent to the number of rows per line
                Console.WriteLine(); // Tells code to go to the next line
            }

                // Pattern D
                Console.WriteLine(); // Tells code to go to the next line
            Console.Write("Pattern D"); // Writes "Pattern D" into the writing
            Console.WriteLine(); // Tells code to go to the next line
        
            for (int row = 1; row <= MAX_ROWS; row++) // for outer loop that adds rows until it reaches value of MAX_ROWS
            {
                for (int spaces = 10; spaces >= row; spaces--) // for inner loop that subtracts spaces for every row
                    Console.Write(" "); // Writes a space equivalent to the number of rows per line
                for (int star = 1; star <= row; star++) // for inner loop that adds stars for every row
                    Console.Write("*"); // Writes a star equivalent to the number of rows per line
                    Console.WriteLine(); // Tells code to go to the next line
            }
        }
    }
}
