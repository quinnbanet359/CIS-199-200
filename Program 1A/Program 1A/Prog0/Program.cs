// Program 0
// CIS 200-10
// Summer 2015
// Due: 5/21/2015
// By: Andrew L. Wright

// File: Program.cs
// Simple test program for initial Parcel classes

// ****************** Program 0 test data has been "commented out" and only new program 1 data remains *****************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
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

            //Letter l1 = new Letter(a1, a2, 1.50M); // Test Letter 1
            //Letter l2 = new Letter(a3, a4, 1.25M); // Test Letter 2
            //Letter l3 = new Letter(a5, a6, 1.75M); // Test Letter 3

            GroundPackage ground1 = new GroundPackage(a1, a2, 10, 9, 8, 7);  // test ground package 1
            GroundPackage ground2 = new GroundPackage(a3, a4, 5, 6, 4, 3);  // test ground package 2

            NextDayAirPackage nextDayAir1 = new NextDayAirPackage(a4, a5, 5, 4, 3,167,10.50m);   // test next day air package 1
            NextDayAirPackage nextDayAir2 = new NextDayAirPackage(a6, a7, 51, 354, 34, 101, 11.03m);  // test next day air package 2

            TwoDayAirPackage twoDayAir1 = new TwoDayAirPackage(a8, a9, 12, 7, 2, 4, TwoDayAirPackage.Delivery.Early); // test two day air package 1
            TwoDayAirPackage twoDayAir2 = new TwoDayAirPackage(a10, a1, 43, 83, 73, 23,TwoDayAirPackage.Delivery.Saver); // test two day air package 2


            //List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            //// Add test data to list
            //parcels.Add(l1);
            //parcels.Add(l2);
            //parcels.Add(l3);

            //// Display data
            //Console.WriteLine("Program 0 - List of Parcels\n\n");

            //foreach (Parcel p in parcels)
            //{
            //    Console.WriteLine(p);
            //    Console.WriteLine("--------------------");
            //}

            // Display data
            Console.WriteLine("Program 1A\n\n");
            Console.WriteLine("DISPLAY NEW GROUND PACKAGES:");
            Console.WriteLine();
            Console.WriteLine();

            List<GroundPackage> groundPackages = new List<GroundPackage>();     // test list of groundPackages

            // Add test data to list
            groundPackages.Add(ground1);
            groundPackages.Add(ground2);

            foreach (GroundPackage gp in groundPackages)
            {
                Console.WriteLine(gp);
                Console.WriteLine("--------------------");
            }
            // Display data
            Console.WriteLine("DISPLAY NEW NEXT DAY AIR PACKAGES:");
            Console.WriteLine();
            Console.WriteLine();

            List<NextDayAirPackage> nextDayAirPackages = new List<NextDayAirPackage>();     // test list of nextDayAirPackages

            // Add test data to list
            nextDayAirPackages.Add(nextDayAir1);
            nextDayAirPackages.Add(nextDayAir2);

            foreach (NextDayAirPackage nextdayAP in nextDayAirPackages)
            {
                Console.WriteLine(nextdayAP);
                Console.WriteLine("--------------------");
            }

            // Display data
            Console.WriteLine("DISPLAY NEW TWO DAY AIR PACKAGES:");
            Console.WriteLine();
            Console.WriteLine();

            List<TwoDayAirPackage> twoDayAirPackages = new List<TwoDayAirPackage>();     // test list of twoDayAirPackages

            // Add test data to list
            twoDayAirPackages.Add(twoDayAir1);
            twoDayAirPackages.Add(twoDayAir2);

            foreach (TwoDayAirPackage twoDayAP in twoDayAirPackages)
            {
                Console.WriteLine(twoDayAP);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
