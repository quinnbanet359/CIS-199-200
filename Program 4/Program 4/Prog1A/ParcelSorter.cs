// Program 4
// CIS 200-10
// Summer 2015
// Due: 6/25/2015
// By: Quinn Banet / Andrew L. Wright

// File: ParcelSorter.cs
// ParcelSorter serves as a comparer class to order parcel type and then by cost

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelSorter : IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: When type1 < type2, method returns negative #
        //                When type1 == type2, method returns zero
        //                When type1 > type2, method returns positive #
        public int Compare(Parcel type1, Parcel type2)
        {
            if (type1 == null && type2 == null) // Both null?
                return 0;

            if (type2 == null) // Only t2 is null
                return -1;

            int typeComparer = string.Compare(type1.GetType().ToString(), type2.GetType().ToString());  // type, ascending
            if (typeComparer != 0) // Check for type difference first
                return typeComparer;

            int costComparer = decimal.ToInt32(type2.CalcCost() - type1.CalcCost()); // cost, descending
                return costComparer;
        }
    }
}
