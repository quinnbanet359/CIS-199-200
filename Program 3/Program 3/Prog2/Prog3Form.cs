// Quinn Banet
// Program 3
// Due: 6/22/15
// CIS 200-10

// File: Prog2Form.cs
// This class creates the main GUI for Program 3. It provides a File menu with About, Exit,
// Open Addresses, and Save Addresses items, an Insert menu with Address and Letter items,
// and edit menu with Addresses, and a Report menu with List Addresses and List Parcels items.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Prog2
{
    public partial class Prog3Form : Form
    {
        private List<Address> addressList; // The list of addresses
        private List<Parcel> parcelList;   // The list of parcels

        // object for serializing RecordSerializables in binary format
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output; // stream for writing to a file

        // object for deserializing RecordSerializable in binary format
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input; // stream for reading from a file

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog3Form()
        {
            InitializeComponent();

            addressList = new List<Address>();
            parcelList = new List<Parcel>();
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 3{0}By: Quinn Banet{0}" +
                "CIS 200{0}Summer 2015", Environment.NewLine), "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    Address newAddress = new Address(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        int.Parse(addressForm.ZipText)); // Use form's properties to create address
                    addressList.Add(newAddress);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String

            result.Append("Addresses:");
            result.Append(Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(Environment.NewLine);

            foreach (Address a in addressList)
            {
                result.Append(a.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog

            if (addressList.Count < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return;
            }

            letterForm = new LetterForm(addressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as addressList
                    Letter newLetter = new Letter(addressList[letterForm.OriginAddressIndex],
                        addressList[letterForm.DestinationAddressIndex],
                        decimal.Parse(letterForm.FixedCostText)); // Letter to be inserted
                    parcelList.Add(newLetter);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs

            result.Append("Parcels:");
            result.Append(Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(Environment.NewLine);

            foreach (Parcel p in parcelList)
            {
                result.Append(p.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
                totalCost += p.CalcCost();
            }

            result.Append("------------------------------");
            result.Append(Environment.NewLine);
            result.Append(String.Format("Total Cost: {0:C}", totalCost));

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }
        // Precondition:  File, Open Addresses Menu item activated
        // Postcondition: A user selected file has been opened and 
        //                addresses have been loaded into the form
        //                OR.....a bad file has been selected and an 
        //                error message has been displayed
        private void openAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file
            DialogResult result; // result of OpenFileDialog
            string fileName; // name of file containing data

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified name
            } // end using

            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // create FileStream to obtain read access to file
                    input = new FileStream(
                       fileName, FileMode.Open, FileAccess.Read);
                    // deserialize RecordSerializable and store data in TextBoxes
                    try
                    {
                        // create temporary list of type Address to hold each deserialized input item
                        List<Address> tempAddressList = (List<Address>)reader.Deserialize(input);
                            // cycle through each temporary list item of type Address and add to existing addressList
                            foreach (var newAddItem in tempAddressList)
                            addressList.Add(newAddItem);
                    } // end try
                    // handle exception when there are no AddressSerializables in file
                    catch (SerializationException)
                    {
                        input.Close(); // close FileStream 

                        // notify user if no RecordSerializables in file
                        MessageBox.Show("No more Addresses in file", string.Empty,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } // end catch
                } // end else
            } // end if
        }
        // Precondition:  File, Save Addresses menu item has been activated
        // Postcondition: A user named file has been saved and 
        //                addresses have been saved into the file
        //                OR.....something went wrong and an 
        //                error message has been displayed
        private void saveAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to save file
            DialogResult result;
            string fileName; // name of file to save data

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file

                // retrieve the result of the dialog box
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified file name
            } // end using

            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // save file via FileStream if user specified valid file
                    try
                    {
                        // open file with write access
                        output = new FileStream(fileName,
                           FileMode.Create, FileAccess.Write);

                        // store addressList values in list of addresses
                        List<Address> values = addressList;

                        foreach (var addressListItem in values)
                        {
                            // addressSerializable containing addresslist values to serialize
                            Address addressSerializable = new Address(addressListItem.Name, addressListItem.Address1, 
                                addressListItem.Address2, addressListItem.City, addressListItem.State, addressListItem.Zip);

                             // store addressList values in addressSerializable
                            addressSerializable.Name = addressListItem.Name;
                            addressSerializable.Address1 = addressListItem.Address1;
                            addressSerializable.Address2 = addressListItem.Address2;
                            addressSerializable.City = addressListItem.City;
                            addressSerializable.State = addressListItem.State;
                            addressSerializable.Zip = addressListItem.Zip;

                            // write Record to FileStream ( serialize object )
                            formatter.Serialize(output, addressList);
                        }
                    } // end try
                    // handle exception if there is a problem opening the file
                    catch (IOException)
                    {
                        // notify user if file could not be opened
                        MessageBox.Show("Error opening file", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end catch
                } // end else
            } // end if
        }
        // Precondition:  Edit, Addresses menu item has been activated
        // Postcondition: An existing address has been selected 
        //                and edited...OR...an address was not selected
        //                and an error message was displayed
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseAddressForm chooseAddressForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog

            chooseAddressForm = new ChooseAddressForm(addressList); // Send list of addresses
            result = chooseAddressForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    AddressForm editAddForm = new AddressForm();

                    int index;
                    index = chooseAddressForm.ChooseAddressIndex;
                    Address a = addressList[index];
                    
                    editAddForm.AddressName = a.Name;
                    editAddForm.Address1 = a.Address1;
                    editAddForm.Address2 = a.Address2;
                    editAddForm.City = a.City;
                    editAddForm.State = a.State;
                    editAddForm.ZipText = a.Zip.ToString();


                    DialogResult result2 = editAddForm.ShowDialog();
                    if (result2 == DialogResult.OK) // only accept changes if OK
                    {
                        try
                        {
                            a.Name = editAddForm.AddressName;
                            a.Address1 = editAddForm.Address1;
                            a.Address2 = editAddForm.Address2;
                            a.City = editAddForm.City;
                            a.State = editAddForm.State;
                            a.Zip = int.Parse(editAddForm.ZipText);
                        }
                        catch (FormatException) // this should never happen if form validation works
                        {
                            MessageBox.Show("Problem with Address Validation!", "Validation Error");
                        }
                    }
                    editAddForm.Dispose();  // Best practice for dialog boxes
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            chooseAddressForm.Dispose(); // Best practice for dialog boxes
        }
    }
}