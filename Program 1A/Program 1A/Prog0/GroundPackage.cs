// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Quinn Banet

// File: GroundPackage.cs
// Ground Package serves as a derived/concrete class of the package hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
   public class GroundPackage : Package
    {
        double pointTwenty = .20;      // variable for CalcCost method to represent a fixed cost element
        double pointOhFive = .05;      // variable for CalcCost method to represent a fixed cost element
        private decimal Cost;          // varibale for CalcCost method to hold the total

        // Precondition: None
        // Postcondition: The Package is created with specified values for origin address, 
        //                destination address, length, width, height, and weight
        // six-argument constructor
        public GroundPackage(Address originAddress, Address destinationAddress, 
            double l, double wi, double h, double we)
            : base(originAddress, destinationAddress, l, wi, h, we)
        {

        }
       

       public int ZoneDistance
       {
           // Precondition: None
           // Postcondition: The zone distance has been calculated and returned
           get
           {
               // CODE BELOW ADOPTED FROM PROG4 by Andrew Wright          
               const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
               int dist;                             // Calculated zone distance

               dist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));

               return dist;         
               // CODE ABOVE ADOPTED FROM PROG4 by Andrew Wright
           }
       }
       // Precondition: None
       // Postcondition: The cost has been calculated and returned
       public override decimal CalcCost()
       {
           Cost = decimal.Parse((pointTwenty * (Length + Width + Height) + pointOhFive * (ZoneDistance + 1) * (Weight)).ToString());
           return Cost;
       }

       // Precondition:  None
       // Postcondition: A String with the ground package's data has been returned
       public override string ToString()
       {
           return String.Format("GroundPackage:{4}{4}{5}{4}{4}Package Dimensions:{4}Length: {0}{4}Width: {1}{4}Height: {2}{4}Weight: {3}{4}Zone Distance: {6}{4}Cost: {7:C}",
               Length, Width, Height, Weight, Environment.NewLine, base.ToString(),ZoneDistance,CalcCost());
       }
    }
}
