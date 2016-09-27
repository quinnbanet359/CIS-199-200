// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Quinn Banet

// File: NextDayAirPackage.cs
// NextDayAirPackage serves as a concrete/derived class of the AirPackage hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee;      // validate express fee

        // Precondition: None
        // Postcondition: The Package is created with specified values for origin address, 
        //                destination address, length, width, height, and weight, and express fee
        // six-argument constructor
        public NextDayAirPackage(Address originAddress, Address destinationAddress, 
                                 double l, double wi, double h, double we, decimal expressFee) 
                                : base (originAddress,destinationAddress, l,wi,h,we)
        {
            _expressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Precondition: None
            // Postcondition: The express fee has been returned
            get
            {
                return _expressFee;
            }
        }

        // Precondition: None
        // Postcondition: The base cost has been returned and calculated using a series of if statements
        public override decimal CalcCost()
        {
            decimal cost1 = .40m;             // variable to represent a fixed cost
            decimal cost2 = .30m;             // variable to represent a fixed cost
            decimal cost3 = .25m;             // variable to represent a fixed cost
            decimal baseCost;

            // initial cost before any extra charges are added
            baseCost = cost1 * decimal.Parse((Length + Width + Height).ToString()) + cost2 * decimal.Parse((Weight).ToString());


            if (IsHeavy() == true && IsLarge() == true)     // is heavy and large
            {
                _expressFee = cost3 * decimal.Parse((Weight).ToString()); // is heavy charges
                _expressFee += cost3 * decimal.Parse((Length + Width + Height).ToString()); // is large charges
                baseCost += _expressFee;

            }
            if (IsHeavy() == true && IsLarge() == false)        // is just heavy
            {
                _expressFee = cost3 * decimal.Parse((Weight).ToString()); // is heavy charges
                baseCost += _expressFee;
            }
            if (IsHeavy() == false && IsLarge() == true)    // is just large
            {
                _expressFee = cost3 * decimal.Parse((Length + Width + Height).ToString()); // is large charges
                baseCost += _expressFee;
            }
            return baseCost;
        }

        // Precondition:  None
        // Postcondition: A String with the next day air package's data has been returned
        public override string ToString()
        {
            return string.Format("Next Day Air Package:{1}{0}{1}{1}Package Dimensions:{1}Length: {2}{1}Width: {3}{1}Height: {4}{1}Weight: {5}{1}Package is Extra Heavy: {7}{1}Package is Extra Large: {8}{1}Express Fee: {6:C}"
                ,base.ToString(), Environment.NewLine, Length, Width, Height, Weight, CalcCost(),IsHeavy(),IsLarge());
        }
    }
}
