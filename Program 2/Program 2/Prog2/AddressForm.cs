// Quinn Banet
// Due: 6/11/15
// CIS 200-10
// File: AddressForm.cs
// Class AddressForm: relays to a GUI form that accepts user input Address information (name,address,city,etc)
//                    and stores it for use in LetterForm and when the program form selects to report Addresses

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
    public partial class AddressForm : Form 
    {
        public AddressForm()
        {

            InitializeComponent();
        }
        public string EnteredName
        {
            // Precondition:  None
            // Postcondition: Text in nameTxt is returned
            get { return nameTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in nameTxt is set to specified value
            set { nameTxt.Text = value; }
        }
        public string EnteredAddress1
        {
            // Precondition:  None
            // Postcondition: Text in ad 1 is returned
            get { return address1Txt.Text; }

            // Precondition:  None
            // Postcondition: Text in ad 1 is set to specified value
            set { address1Txt.Text = value; }
        }
        public string EnteredAddress2
        {
            // Precondition:  None
            // Postcondition: Text in ad 2 is returned
            get { return address2Txt.Text; }

            // Precondition:  None
            // Postcondition: Text in ad 2 is set to specified value
            set { address2Txt.Text = value; }
        }
        public string EnteredCity
        {
            // Precondition:  None
            // Postcondition: Text in cityText is returned
            get { return cityText.Text; }

            // Precondition:  None
            // Postcondition: Text in cityText is set to specified value
            set { cityText.Text = value; }
        }
        public string EnteredState
        {
            // Precondition:  None
            // Postcondition: Text in stateComboBox is returned
            get { return stateComboBox.Text; }

            // Precondition:  None
            // Postcondition: Text in stateComboBox is set to specified value
            set { stateComboBox.Text = value; }
        }
        public string EnteredZip
        {
            // Precondition:  None
            // Postcondition: Text in zipTxt is returned
            get { return zipTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in zipTxt is set to specified value
            set { zipTxt.Text = value; }
        }
        // Precondition:  Error messages still remain
        // Postcondition:  Error message has been cleared
        private void nameTxt_Validated(object sender, EventArgs e)
        {
            nameError.SetError(nameTxt, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  Name text box has been validated from incorrect user enrty
        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {

            // Validate Name
            if (String.IsNullOrEmpty(nameTxt.Text))
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                nameError.SetError(nameTxt, "Enter a Name!");  // set error message

                nameTxt.SelectAll();    // select all text in nameTxt to ease correction
            }
            else
            {
                // further validation
                if (String.IsNullOrWhiteSpace(nameTxt.Text))
                {
                    e.Cancel = true;    // stops focus changing process
                    // Will NOT proceed to validated event
                    nameError.SetError(nameTxt, "Enter a Name!");  // set error message

                    nameTxt.SelectAll();    // select all text in nameTxt to ease correction
                }
            }
        }

        // Precondition:  None
        // Postcondition:  Address1 text box has been validated from incorrect user enrty
        private void address1Txt_Validating(object sender, CancelEventArgs e)
        {
            // Validate Address 1
            if (String.IsNullOrEmpty(address1Txt.Text))
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                add1Error.SetError(address1Txt, "Enter an Address!");  // set error message

                address1Txt.SelectAll();    // select all text in nameTxt to ease correction
            }
            else
            {
                // further validation
                if (String.IsNullOrWhiteSpace(address1Txt.Text))
                {
                    e.Cancel = true;    // stops focus changing process
                    // Will NOT proceed to validated event
                    add1Error.SetError(address1Txt, "Enter an Address!");  // set error message

                    address1Txt.SelectAll();    // select all text in nameTxt to ease correction
                }
            }
        }
        // Precondition:  Error messages still remain
        // Postcondition:  Error message has been cleared
        private void address1Txt_Validated(object sender, EventArgs e)
        {
            add1Error.SetError(address1Txt, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  City text box has been validated from incorrect user enrty
        private void cityText_Validating(object sender, CancelEventArgs e)
        {
            // Validate city
            if (String.IsNullOrEmpty(cityText.Text))
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                cityError.SetError(cityText, "Enter a City!");  // set error message

                cityText.SelectAll();    // select all text in nameTxt to ease correction
            }
            else
            {
                // further validation
                if (String.IsNullOrWhiteSpace(cityText.Text))
                {
                    e.Cancel = true;    // stops focus changing process
                    // Will NOT proceed to validated event
                    cityError.SetError(cityText, "Enter a City!");  // set error message

                    cityText.SelectAll();    // select all text in nameTxt to ease correction
                }
            }
        }
        // Precondition:  Error messages still remain
        // Postcondition:  Error message has been cleared
        private void cityText_Validated(object sender, EventArgs e)
        {
            cityError.SetError(cityText, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  Zip text box has been validated from incorrect user enrty
        private void zipTxt_Validating(object sender, CancelEventArgs e)
        {
                int number;             // Value entered into zipTxt
                int maxZip = 99999;     // max allowed zip code 
                int minZip = 00000;     // min allowed zip code

                // Will try to parse text as int
                // If fails, TryParse returns false
                // If succeeds, TryParse returns true and number stores parsed value
                if (!int.TryParse(zipTxt.Text, out number))
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    zipError.SetError(zipTxt, "Enter an integer!"); // Set error message

                    zipTxt.SelectAll(); // Select all text in zipTxt to ease correction
                }
                else
                {
                    if (number < minZip || number > maxZip)
                    {
                        e.Cancel = true; // Stops focus changing process
                        // Will NOT proceed to Validated event

                        zipError.SetError(zipTxt, "Enter a zip code between 00000 and 99999"); // Set error message

                        zipTxt.SelectAll(); // Select all text in zipTxt to ease correction
                    }
                }
        }
        // Precondition:  Error messages still remain
        // Postcondition:  Error message has been cleared
        private void zipTxt_Validated(object sender, EventArgs e)
        {
            zipError.SetError(zipTxt, ""); // clears error message
        }

        // Precondition:  None
        // Postcondition:  State combo box has been validated from incorrect user enrty
        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Validate state
            int lowState = 0;
            int highState = 49;

            // tests the range of states (0-49) to ensure the user has selcted a value
            if (stateComboBox.SelectedIndex < lowState || stateComboBox.SelectedIndex > highState)
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                stateError.SetError(stateComboBox, "Choose a State!");  // set error message

                stateComboBox.SelectAll(); // Select all text in stateComboBox to ease correction
            }
        }
        // Precondition:  Error messages still remain
        // Postcondition:  Error message has been cleared
        private void stateComboBox_Validated(object sender, EventArgs e)
        {
            stateError.SetError(stateComboBox, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  if user clicks cancel the form is closed
        private void cnclBttn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        // Precondition:  None
        // Postcondition:  when the ok button has been selected children have been validated
        private void okayBttn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
