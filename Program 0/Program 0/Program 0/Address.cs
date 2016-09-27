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
   public class Address
    {
        int maxZipCode = 99999;  // variable to represent the max allowed zip code 

        private int _zipCode;   // validate zip code

        // Precondition: None 
        // Postcondition: Declares 5 auto implemented string properties
        public string Name { get; set; }        // auto implemented Name
        public string Address1 { get; set; }    // auto implemented Address1
        public string Address2 { get; set; }    // auto implemented Address2
        public string City { get; set; }        // auto implemented City
        public string State { get; set; }       // auto implemented State


        // Precondition: Must contain 6 arguments
        // Postcondition: uses 5 of the six constructors and validates zip code
        // six-argument constructor 
        public Address(string name, string address1, string address2,
                        string city, string state, int zipCode)
        {
            // initilaize backing field 
                ZipCode = zipCode;

                // initilaize properties
                Name = name;
                Address1 = address1;
                Address2 = address2;
                City = city;
                State = state;
            }
        public int ZipCode
        {
            // Precondition: None
            // Postcondition: zip code backing field is returned
            get
            {
                return _zipCode;
            }
            // Precondition: There must be a get provided in order to set
            // Postcondition: As long as Zip code is between 00000-99999,
            //                the zip code backing field becomes th value
           private set
            {
                if (value > 0 && value <= maxZipCode) // validate zip code
                    _zipCode = value;
                else // month is invalid
                    throw new ArgumentOutOfRangeException(
                       "Zip Code", value, "Zip Code must be 00000-99999");
            }
        }
        // Precondition: None
        // Postcondition: Retuurns formatted string
        public override string ToString()
        {
            return string.Format("{0}\n{1} {2}\n{3}, {4} {5}\n"
                ,Name,Address1,Address2,City,State,ZipCode);
        }
    }
}
