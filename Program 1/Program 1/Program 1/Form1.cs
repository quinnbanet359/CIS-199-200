//Quinn Banet
//Program 1
//Due: February 16, 2015
//CIS 199-01
//this program takes user entered data and performs calculations, then displays information to help a painting business keep track of things

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1 : Form
    {
        public program1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        
        {
            double costOfLaborUnit = 10.50; //represents the company charge for the cost of labor
            int unitOfSQFeet = 325;     //represents the unit that every 325 sq ft, the company charges another unit
            int hoursOfLaborUnit = 8;       //represents that every 325 sq ft, 8 more hours of labor is charged

            double totalSquareFeetPainted;  //holds the value for the total square feet to be painted
            double numberOfGallonsPainted;  //holds the value for the number of gallons to be painted
            double hoursOfLaborRequired;    //holds the hours of labor to be required
            double costOfPaint;             //holds the cost of paint
            double costofLabor;             //holds the cost of labor
            double totalCostofJob;          //holds the total cost of the job
         
            //DO CALCULATIONS
            //calculate the total sq ft to be painted 
            totalSquareFeetPainted = double.Parse(squareFeetTextBox.Text) * double.Parse(paintDesiredTextBox.Text);

            //calculate the numbeer of gallons of paint
            numberOfGallonsPainted = Math.Ceiling(totalSquareFeetPainted / unitOfSQFeet);

            //calculate the hours of labor required
            hoursOfLaborRequired = (totalSquareFeetPainted / unitOfSQFeet) * hoursOfLaborUnit;

            //calculate the cost of paint
            costOfPaint = numberOfGallonsPainted * double.Parse(priceOfPaintTextBox.Text);

            //calculate the cost of labor
            costofLabor = hoursOfLaborRequired * costOfLaborUnit;

            //calculate the total cost of the job
            totalCostofJob = costOfPaint + costofLabor;

            //DISPLAY CALCULATIONS IN THE LABELS
            //display the total sq ft to be painted 
            displayLabelSquareFeet.Text = totalSquareFeetPainted.ToString("F1");

            //display the numbeer of gallons of paint
            displayLabelPaint.Text = numberOfGallonsPainted.ToString("");


            //display the hours of labor required
            displayLabelLabor.Text = hoursOfLaborRequired.ToString("F1");

            //display the cost of paint
            displayLabelCostofPaint.Text = costOfPaint.ToString("c");

            //display the cost of labor
            displayLabelCostofLabor.Text = costofLabor.ToString("c");

            //display the total cost of the job
            displayLabelTotalCost.Text = totalCostofJob.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes.
            squareFeetTextBox.Text = "";
            paintDesiredTextBox.Text = "";
            priceOfPaintTextBox.Text = "";

            //Clear the Labels
            displayLabelCostofLabor.Text = "";
            displayLabelCostofPaint.Text = "";
            displayLabelLabor.Text = "";
            displayLabelPaint.Text = "";
            displayLabelSquareFeet.Text = "";
            displayLabelTotalCost.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Come on Dr. Wright, you don't need help!");
        }
    }
}
