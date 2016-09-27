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
    class Program
    {
        // Precondition:  None
        // Postcondition: three letters are displayed
        static void Main(string[] args)
        {
            // variables to represent fixed cost for new letters
           const decimal cost1 = 3.43m;
           const decimal cost2 = 2.67m;
           const decimal cost3 = 1.99m;

            // create derived class objects
            Address address1 = new Address("Quinn Banet", "1234 4th Street",
                "Appt# 4", "Louisville", "KY", 40209);
            Address address2 = new Address("Rush Ouer", "115 Nassau St",
                "Appt# 9024982", "New York", "NY", 10038);
            Address address3 = new Address("Hana Lulu","1383 Opelo Rd",
                "", "Kamuela", "HI", 96743);
            Address address4 = new Address("Ima Moose", "4603 E 9th Ave",
                "Appt# 244", "Anchorage", "AK", 99508);
            Address address5 = new Address("Tim Cook", "1 Infinite Loop",
                "", "Cupertino", "CA", 95014);
            Address address6 = new Address("Andrew Wright", "W Brandeis Ave",
                "CoB Room 008", "Louisville", "KY", 40292);

            // create new letters from derived addresses
            Letter letter1 = new Letter(address2, address3, cost1);
            Letter letter2 = new Letter(address4, address5, cost2);
            Letter letter3 = new Letter(address1, address6, cost3);

            // Create list and add letters to list 
            List<Parcel> items = new List<Parcel>();
            items.Add(letter1);
            items.Add(letter2);
            items.Add(letter3);


                // output all letters
            Console.Write("-------------Letter 1-------------\n\n{0}\n\n-------------"
                + "Letter 2-------------\n\n{1}\n\n-------------Letter 3-------------\n\n{2}"
                            ,letter1,letter2,letter3);
 
            // end program
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
