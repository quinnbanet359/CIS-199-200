// Quinn Banet
// Program 0
// Due 5/21/15
// This program uses polymorphism and class heirarchy to output three letters.
// These letters consist of origin & destination addresses (name, address, city, state, zip)
// as well as fixed costs. This program has an "address" at the bottom of the hierarchy,
// followed by an abstract class: a "parcel", and a derived class: a "letter."

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel
    {
        // Precondition: Address class must all be valid
        // Postcondition: Creates a HAS A relationship
        // two-argument constructor 
        public Parcel (Address originAddress, Address destinationAddress) 
        {
            // initilaize properties
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        // Precondition: None
        // Postcondition: Declared two auto implemented properties w/ HAS A relationships
        public Address OriginAddress { get; set; }      // read only origin address property
        public Address DestinationAddress { get; set; } // read only destination address property        

        // Precondition: None
        // Postcondition: Returns cost of parcel
        // abstract CalcCost method to be instantiated in Letter class
         public abstract decimal CalcCost();

         // Precondition: Each Address has already been formatted
         // Postcondition: Returns each origin & destination addresses in formatted strings
        // ToString method to format all costs and fees in currency formatting 
        public override string ToString()
        {
            return string.Format("Origin Address: \n\n{0} \nDestination Address:\n\n{1}",
         OriginAddress,DestinationAddress);
        }
    }
}
