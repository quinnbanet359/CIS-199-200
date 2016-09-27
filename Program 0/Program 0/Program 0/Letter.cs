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
    class Letter : Parcel
    {
        private decimal _fixedCost;     // fixed cost backing field

        // Precondition: Both Address and parcel must be valid
        // Postcondition: creates an IS A Relationship
        // 3-argument constructor 
        public Letter(Address orAddress, Address destAddress, decimal fixedCost) 
            : base (orAddress,destAddress)

        {
            FixedCost = fixedCost;     // validate fixed cost via property
        }

        // Property that gets and sets the fixed cost 
        public decimal FixedCost
        {
            // Precondition: None
            // Postcondition: return the fixed cost backing field
            get
            {
                return _fixedCost;
            }
            // Precondition: There must be a provided get in order to set
            // Postcondition: as long as the fixed cost is >0 the value will be 
            //                the fixed cost backing field
            set
            {
                if (value >= 0)
                 _fixedCost = value;
                else
                {
                    throw new ArgumentOutOfRangeException("FixedCost",
                         value, "FixedCost must be >= 0");
                }
            }
        }
        // Precondition: None
        // Postcondition: Returns fixed cost to the letter
        public override decimal CalcCost()
        {
            return FixedCost;
        }
        // Precondition: Address and Parcels have already been formatted
        // Postcondition: Returns origin/destination addresses and fixed cost in formatted strings
        public override string ToString()
        {
            return string.Format("Origin Address:\n\n{0}\nDestination Address:\n\n{1}\nFixed Cost: {2:C}"
                ,OriginAddress,DestinationAddress,FixedCost);
        } 
    }
}
