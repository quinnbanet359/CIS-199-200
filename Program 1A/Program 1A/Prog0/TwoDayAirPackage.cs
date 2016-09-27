// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Quinn Banet

// File: TwoDayAirPackage.cs
// TwoDayAirPackage serves as a concrete/derived class of the AirPackage hierachy.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
   public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver };
        private Delivery _earlyOrSave;   // private delivery object (backing field)

        // Precondition: None
        // Postcondition: The Package is created with specified values for origin address, 
        //                destination address, length, width, height, and weight, and delivery type
        public TwoDayAirPackage (Address originAddress, Address destinationAddress, 
            double l, double wi, double h, double we, Delivery deliveryType) 
            : base (originAddress,destinationAddress,l,wi,h,we)
        {
            _earlyOrSave = deliveryType;
        }
        public Delivery DeliveryType
        {
            // Precondition: None
            // Postcondition: The delivery type has been returned
            get
            {

                return _earlyOrSave;
            }
            // Precondition: None
            // Postcondition: The delivery type has been set as the value
            set
            {
                _earlyOrSave = value;
            }
        }
        // Precondition: None
        // Postcondition: The base cost has been returned and calculated using a series of if statements
        public override decimal CalcCost()
        {
            decimal total;
            decimal cost = .25m;
            decimal tenPercent = .1m;

            total = cost * decimal.Parse((Length + Width + Height).ToString()) + cost * decimal.Parse((Weight).ToString());
            if (DeliveryType == Delivery.Saver)
            {
                total = total - (total * tenPercent);
            }

            return total;
        }

        // Precondition:  None
        // Postcondition: A String with the next two air package's data has been returned
        public override string ToString()
        {
            return string.Format("Two Day Air Package:{1}{0}{1}{1}Package Dimensions:{1}Length: {2}{1}Width: {3}{1}Height: {4}{1}Weight: {5}{1}Delivery Type: {6}{1}Cost: {7:C}"
                , base.ToString(), Environment.NewLine, Length, Width, Height, Weight, DeliveryType.ToString(),CalcCost());
        }
    }
}
