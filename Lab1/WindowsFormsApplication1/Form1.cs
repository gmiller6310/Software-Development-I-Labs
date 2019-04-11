//Grading ID: B9073
//Lab Number: Lab 1
//Due Date: September 7, 2016 11:59 P.M.
//Class Section: 75
//Program Description: Contains an image of my favorite animal, my name, and 3 clickable buttons describing my interests.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Renamed the form to lab1Form
    public partial class lab1Form : Form
    {
        public lab1Form()
        {
            InitializeComponent();
        }
    //label1 represents myNameLabel
        private void label1_Click(object sender, EventArgs e)
        {

        }
//Renamed the picture box to otterPictureBox
        private void otterPictureBox_Click(object sender, EventArgs e)
        {

        }
    //Set up the hobbiesButton to be clickable and display text when clicked
        private void hobbiesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Following the NBA and Playing Video Games");

        }
//Set up the bookButton to be clickable and display text when clicked
        private void bookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Hunger Games");
        }
//Set up the movieButton to be clickable and display text when clicked
        private void movieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Dark Knight");
        }
    }
}
