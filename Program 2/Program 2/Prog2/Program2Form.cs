// Quinn Banet
// Due: 6/11/15
// CIS 200-10
// File: Program2Form.cs
// Class Program2Form: relays to a GUI form that directs the user to a series of menu items where the user can display 
//                     a list of addresses and parcels, create new addresses and parcels, as well as view info about the program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Program2Form : Form
    {
        // Create new Lists to add to the data
        List<Address> addresssesList = new List<Address>();
        List<Parcel> parcelsList = new List<Parcel>();

        public Program2Form()
        {
            InitializeComponent();

            // enter test data
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
               "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Doe", "111 Market St.", "",
                "Jeffersonville", "IN", 47130); // Test Address 5
            Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a4, 4.25M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);     // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, // Next Day test object
                5.25, 5.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, // Next Day test object
                15.5, 5.00M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5,   // Two Day test object
                75.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0,  // Two Day test object
                5.5, TwoDayAirPackage.Delivery.Saver);

            // add test data to lists
            addresssesList.Add(a1); addresssesList.Add(a2); addresssesList.Add(a3); addresssesList.Add(a4);
            addresssesList.Add(a5); addresssesList.Add(a6); addresssesList.Add(a7); addresssesList.Add(a8);

            parcelsList.Add(letter1); parcelsList.Add(letter2); parcelsList.Add(gp1); parcelsList.Add(gp2);
            parcelsList.Add(ndap1); parcelsList.Add(ndap2); parcelsList.Add(ndap3); parcelsList.Add(tdap1);
            parcelsList.Add(tdap2); parcelsList.Add(tdap2); parcelsList.Add(tdap3);

            // obtain calc cost for each parcel and add to "result"
            decimal finalCost = 0;
            finalCost += letter1.CalcCost();
            finalCost += letter2.CalcCost();
            finalCost += gp1.CalcCost();
            finalCost += gp2.CalcCost();
            finalCost += ndap1.CalcCost();
            finalCost += ndap2.CalcCost();
            finalCost += ndap3.CalcCost();
            finalCost += tdap1.CalcCost();
            finalCost += tdap2.CalcCost();
            finalCost += tdap3.CalcCost();
        }
        // Precondition:  None
        // Postcondition:  entire application has been closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Precondition:  None
        // Postcondition:  about dialog box is displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "Quinn Banet";
            string dueDate = "6/11/15";
            string section = "CIS 200-10";

            MessageBox.Show(name + Environment.NewLine + dueDate + Environment.NewLine + section, "About",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Precondition:  None
        // Postcondition:  Address form has been displayed and either accepted user entry or returned "cancel"
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The dialog box form
            DialogResult result;                            // Result from dialog - OK/Cancel?

        // used to store user entered Address fields
        string enteredName;
        string enteredAd1;
        string enteredAd2;
        string enteredCity;
        string enteredState;
        int enteredZip;

            result = addressForm.ShowDialog(); // Show dialog box form - modal, waits for OK/Cancel
            // Even after user dismisses, the form still exists
            // and can be interacted with using methods/properties
            if (result == DialogResult.OK)
            {
                // relates user entered Address fields to the properties
                enteredName = addressForm.EnteredName;
                enteredAd1 = addressForm.EnteredAddress1;
                enteredAd2 = addressForm.EnteredAddress2;
                enteredCity = addressForm.EnteredCity;
                enteredState = addressForm.EnteredState;
                enteredZip = int.Parse(addressForm.EnteredZip);

                // Makes new user data and adds it to the list
                Address userAddress = new Address(enteredName, enteredAd1, enteredAd2, enteredCity, enteredState, enteredZip);
                addresssesList.Add(userAddress);

                MessageBox.Show("Your Address has been added to the list!");
            }

            if (result == DialogResult.Cancel)
            {
                addressForm.Close();
            }
        }

        
        // Precondition:  None
        // Postcondition:  Letter form has been displayed and either accepted user entry or returned "cancel"
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(addresssesList);    // The dialog box form

            DialogResult result;                            // Result from dialog - OK/Cancel?

              // fields to associate properties to user selected values
              int chosenOrAdd;
              int chosenDestAdd;
              decimal enteredCost;

            result = letterForm.ShowDialog(); // Show dialog box form - modal, waits for OK/Cancel
            // Even after user dismisses, the form still exists
            // and can be interacted with using methods/properties
            if (result == DialogResult.OK)
            {
                // relates user entered Address fields to the properties
                enteredCost = letterForm.FixedCost;
                chosenDestAdd = letterForm.ChosenDestAdd;
                chosenOrAdd = letterForm.ChosenOrAdd;

                int ORindex = chosenOrAdd;
                int DESTindex = chosenDestAdd;
                Address chosenOrigin;
                Address chosenDest;
                if (ORindex > 0 && DESTindex > 0)
                {                
                    // Makes new user data and adds it to the list
                    chosenOrigin = addresssesList[ORindex];
                    chosenDest = addresssesList[DESTindex];
                    Letter userLetter = new Letter(chosenOrigin, chosenDest, enteredCost);
                    parcelsList.Add(userLetter);
                }

                MessageBox.Show("Your Letter has been added to the list!");
            }

            if (result == DialogResult.Cancel)
            {
                letterForm.Close();
            }
        }
        // Precondition:  None
        // Postcondition:  Prints a report the the textbox of all the entered Addresses
        public void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Before new report is run, checks to see if textbox still has text in it
            // if not it leaves it alone, if so it clears the textbox
            if (reportTextBox.Text != "")
            {
                reportTextBox.Clear();
            }

            // output built into "result"
            string result="";
            result += "Addresses:";
            result += Environment.NewLine + Environment.NewLine;
            foreach (var items in addresssesList)
            {
                result += items.ToString();
                result += Environment.NewLine;
                result += Environment.NewLine;
            }
            reportTextBox.Text += result;
        }
        // Precondition:  None
        // Postcondition:  Prints a report the the textbox of all the entered Parcels
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Before new report is run, checks to see if textbox still has text in it
            // if not it leaves it alone, if so it clears the textbox
            if (reportTextBox.Text != "")
            {
                reportTextBox.Clear();
            }
            // output built into "result"
            string result = "";
            result += "Parcels:";
            result += Environment.NewLine + Environment.NewLine;
            foreach (var items in parcelsList)
            {
                result += items.ToString();
                result += Environment.NewLine;
                result += Environment.NewLine;
            }
            AddressForm addressForm = new AddressForm();    // The dialog box form

            decimal finalCost = 0M;
            foreach (var item in parcelsList)
            {
                finalCost += item.CalcCost();
            }
            // final output
            reportTextBox.Text += result;
            reportTextBox.Text += "-------------------------------" + Environment.NewLine;
            reportTextBox.Text += "Total Cost: ";
            reportTextBox.Text += finalCost.ToString("C");
            reportTextBox.Text += Environment.NewLine + Environment.NewLine;

           
        }
    }
}
