// Program 4
// CIS 200-10
// Summer 2015
// Due: 6/25/2015
// By: Quinn Banet / Andrew L. Wright

// File: DestZipOrder.cs
// DestZipOrder serves as a comparer class to order destination zip codes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class DestZipOrder : IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: When d1 < d2, method returns negative #
        //                When d1 == d2, method returns zero
        //                When d1 > d2, method returns positive #
        public int Compare(Parcel d1, Parcel d2)
        {
            if (d1 == null && d2 == null) // Both null?
                return 0;

            if (d2 == null) // Only t2 is null
                return -1;


            int zipComparer = d2.DestinationAddress.Zip - d1.DestinationAddress.Zip;    // dest zip, descending
            return zipComparer;
        }
    }
}
