// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Quinn Banet

// File: Package.cs
// Package serves as the abstract base class of the package hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{ 
    public abstract class Package : Parcel
    {
        private double _length;     // validate length
        private double _width;      // validate width
        private double _height;     // validate height
        private double _weight;     // validate weight
        // Precondition: None
        // Postcondition: The Package is created with specified values for origin address, 
        //                destination address, length, width, height, and weight
        public Package(Address originAddress, Address destinationAddress,
                       double l, double wi, double h, double we)
            : base(originAddress, destinationAddress)
        {
            _length = l;
            _width = wi;
            _height = h;
            _weight = we;
        }

        public double Length
        {
            // Precondition: None
            // Postcondition: The length has been returned
             get
            {
                return _length;
            }
            // Precondition:  value >= 0
            // Postcondition: The package's length has been set to the
            //                specified value
             set
            {
                if (value >= 0)
                    value = _length;
                else throw new ArgumentOutOfRangeException("LENGTH", value,
                    "length must be greater than 0");
            }
        }
        public double Width
        {
            // Precondition: None 
            // Postcondition: The width has been returned
             get
            {
                return _width;
            }
            // Precondition:  value >= 0
            // Postcondition: The package's width has been set to the
            //                specified value
             set
            {
                if (value >= 0)
                    value = _width;
                else throw new ArgumentOutOfRangeException("WIDTH", value,
                    "width must be greater than 0");
            }
        }
        public double Height
        {
            // Precondition:  value >= 0
            // Postcondition: The package's height has been set to the
            //                specified value
             get
            {
                return _height;
            }
            // Precondition:  value >= 0
            // Postcondition: The package's height has been set to the
            //                specified value
             set
            {
                if (value >= 0)
                    value = _height;
                else throw new ArgumentOutOfRangeException("HEIGHT", value,
                    "height must be greater than 0");
            }
        }
        public double Weight
        {
            // Precondition: None 
            // Postcondition: The weight has been returned
             get
            {
                return _weight;
            }
            // Precondition:  value >= 0
            // Postcondition: The package's weight has been set to the
            //                specified value
             set
            {
                if (value >= 0)
                    value = _weight;
                else throw new ArgumentOutOfRangeException("WEIGHT", value,
                    "weight must be greater than 0");
            }
        }
        // Precondition:  None
        // Postcondition: A String with the package's data has been returned
        public override string ToString()
        {
            return String.Format("{1}{0}", base.ToString(), Environment.NewLine);
        }
    }
}
