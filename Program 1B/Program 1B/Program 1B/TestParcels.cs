// Program 1B
// CIS 200-10
// Summer 2015
// Due: 6/3/2015
// By: Quinn Banet

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them using a series of different LINQ expressions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Quinn Banet", "1234 4th Street",
               "Appt# 4", "Louisville", "KY", 40209);
            Address a6 = new Address("Rush Ouer", "115 Nassau St",
                "Appt# 9024982", "New York", "NY", 10038);
            Address a7 = new Address("Hana Lulu", "1383 Opelo Rd",
                "", "Kamuela", "HI", 96743);
            Address a8 = new Address("Ima Moose", "4603 E 9th Ave",
                "Appt# 244", "Anchorage", "AK", 99508);
            Address a9 = new Address("Tim Cook", "1 Infinite Loop",
                "", "Cupertino", "CA", 95014);
            Address a10 = new Address("Andrew Wright", "W Brandeis Ave",
                "CoB Room 008", "Louisville", "KY", 40292);

            Letter l1 = new Letter(a1, a2, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a3, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a5, a6, 1.75M); // Test Letter 3

            GroundPackage ground1 = new GroundPackage(a1, a2, 10, 9, 8, 7);  // test ground package 1
            GroundPackage ground2 = new GroundPackage(a3, a4, 5, 6, 4, 3);  // test ground package 2

            NextDayAirPackage nextDayAir1 = new NextDayAirPackage(a4, a5, 5, 4, 3, 167, 10.50m);   // test next day air package 1
            NextDayAirPackage nextDayAir2 = new NextDayAirPackage(a6, a7, 51, 354, 34, 101, 11.03m);  // test next day air package 2

            TwoDayAirPackage twoDayAir1 = new TwoDayAirPackage(a8, a9, 12, 7, 2, 4, TwoDayAirPackage.Delivery.Early); // test two day air package 1
            TwoDayAirPackage twoDayAir2 = new TwoDayAirPackage(a10, a1, 43, 83, 73, 23, TwoDayAirPackage.Delivery.Saver); // test two day air package 2


            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(ground1);
            parcels.Add(ground2);
            parcels.Add(nextDayAir1);
            parcels.Add(nextDayAir2);
            parcels.Add(twoDayAir1);
            parcels.Add(twoDayAir2);

            Console.WriteLine("Program 1B - List of Parcels\n\n");

            // use LINQ to sort the parcels by dest zip and display in descending order
            Console.WriteLine();
            Console.WriteLine("Use LINQ to sort the parcels by dest zip and display in descending order");
            Console.WriteLine();
            var byDestZip =
                from destZip in parcels
                orderby destZip.DestinationAddress.Zip descending
                select destZip;
            //output by dest zip
            Console.WriteLine();
            foreach (var element in byDestZip)
            {
                Console.WriteLine("Sorted by Destination Zip (descending): ");
                Console.WriteLine(element);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to see the next set of LINQ expressions");
            Console.ReadKey();
            Console.Clear();

            // use LINQ to sort the parcels by price and display in ascending order
            Console.WriteLine();
            Console.WriteLine("Use LINQ to sort the parcels by price and display in ascending order");
            Console.WriteLine();
            var byPrice =
                from price in parcels
                orderby price.CalcCost()
                select price;
            //output by price
            Console.WriteLine();
            foreach (var element1 in byPrice)
            {
                Console.WriteLine("Sorted by Price (ascending): ");
                Console.WriteLine(element1);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to see the next set of LINQ expressions");
            Console.ReadKey();
            Console.Clear();

            // use LINQ to select all Parcels and order by Parcel type (ascending) and then cost (descending)
            Console.WriteLine();
            Console.WriteLine("Use LINQ to select all Parcels and order by Parcel type (ascending) and then cost (descending)");
            Console.WriteLine();
            var byTypeAndCost =
                from typeCost in parcels
                orderby typeCost.GetType().ToString(), typeCost.CalcCost() descending
                select typeCost;
            //output by type and cost
            Console.WriteLine();
            foreach (var element2 in byTypeAndCost)
            {
                Console.WriteLine("Sorted by Parcel Type (ascending) and cost (descending): ");
                Console.WriteLine(element2);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to see the next set of LINQ expressions");
            Console.ReadKey();
            Console.Clear();

            // use LINQ select all AirPackage objects that are heavy and order by weight (descending)
            Console.WriteLine();
            Console.WriteLine("Use LINQ select all AirPackage objects that are heavy and order by weight (descending)");
            Console.WriteLine();
            var byWeight =
                from weight in parcels
                let aPWeight = weight as AirPackage
                where aPWeight != null
                orderby aPWeight.IsHeavy() == true descending
                select aPWeight;

            //output by weight in air packages
            Console.WriteLine();
            foreach (var element3 in byWeight)
            {
                Console.WriteLine("Sorted by Air Package Weight (descending): ");
                Console.WriteLine(element3);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
