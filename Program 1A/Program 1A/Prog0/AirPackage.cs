// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Quinn Banet

// File: AirPackage.cs
// AirPackage serves as the abstract base class of the AirPackage hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        int maxPkgWeight = 75;      // variable to represent the maximum allowed package weight
        int maxpkgDimension = 100;  // variable to represent the maximum allowed package dimensions

        // Precondition: None
        // Postcondition: The Package is created with specified values for origin address, 
        //                destination address, length, width, height, and weight
        // six-argument constructor
        public AirPackage(Address originAddress, Address destinationAddress, 
            double l, double wi, double h, double we)
            : base(originAddress, destinationAddress, l, wi, h, we)
        {

        }
        // Precondition: None
        // Postcondition: IsHeavy method tests the weight of the package and returns a boolean value
        public bool IsHeavy()
        {
            bool isHeavy;
            if (Weight >= maxPkgWeight)
            {
                 isHeavy = true;
            }
            else
            {
                isHeavy = false;
            }
            return isHeavy;
        }

        // Precondition: None
        // Postcondition: IsLarge method tests the length, width, and height of the package and returns a boolean value
        public bool IsLarge()
        {
            bool isLarge;
            if ((Length + Width + Height) >= maxpkgDimension)
            { isLarge = true; }
            else { isLarge = false; }
            return isLarge;
        }

        // Precondition:  None
        // Postcondition: A String with the air package's data has been returned
        public override string ToString()
        {
            return string.Format("{1:C}{0}", base.ToString(), Environment.NewLine);
        }
    }
}
