// Program 4
// CIS 200-10
// Summer 2015
// Due: 6/25/2015
// By: Quinn Banet / Andrew L. Wright

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    
public abstract class Parcel : IComparable<Parcel>  // makes parcel class IComparable
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }
    // Precondition:  None
    // Postcondition: When this < p2, method returns negative #
    //                When this == p2, method returns zero
    //                When this > p2, method returns positive #
    public int CompareTo(Parcel p2)
    {
        // Implements correct handling of null values
        if (this == null && p2 == null) // Both null?
            return 0;

        if (this == null) // only this is null?
            return -1;

        if (p2 == null) // only p2 is null?
            return 1;

        int costCompare = decimal.ToInt32(this.CalcCost()) - decimal.ToInt32(p2.CalcCost()); // cost difference?
        return costCompare;
    }
}
