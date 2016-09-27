// Quinn Banet
// Program 3
// Due: 6/22/15
// CIS 200-10

// File: ChooseAddressForm.cs
// This file creates a sub GUI for Program 3. When The edit menu is selected and Addresses
// have been selected a GUI displays that allows the user to select an address to edit. After
// selecting an address the user can now edit an exising address which will update selected 
// address based on the user's changes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class ChooseAddressForm : Form
    {
        public const int MIN_ADDRESSES = 2; // Minimum number of addresses needed

        private List<Address> addressList;  // List of addresses used to fill combo boxes

        public ChooseAddressForm(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }
        public int ChooseAddressIndex
        {
            // Precondition:  User has selected from choseAddCombo
            // Postcondition: The index of the selected address returned
            get
            {
                return chooseAddCombo.SelectedIndex;
            }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in chooseAddCombo
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    chooseAddCombo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("OriginAddressIndex", value,
                        "Index must be valid");
            }
        }
        // Precondition:  None
        // Postcondition: When the form is loaded, items are added to the combo box
        private void ChooseAddressForm_Load(object sender, EventArgs e)
        {
            int MIN_EDITADDRESS = 1;
            if (addressList.Count < MIN_EDITADDRESS) // Violated precondition!
            {
                MessageBox.Show("Need at least " + MIN_EDITADDRESS + " address to edit!",
                    "Addresses Error");
                this.DialogResult = DialogResult.Abort; // Dismiss immediately
            }
            else
            foreach (Address a in addressList)
            {
                chooseAddCombo.Items.Add(a.Name);
            }
        }
        // Precondition:  None
        // Postcondition: The form is validated
        private void chooseAddCombo_Validating(object sender, CancelEventArgs e)
        {
            if (chooseAddCombo.SelectedIndex == -1) // Didn't select anything from cbo
            {
                e.Cancel = true;
                comboError.SetError(chooseAddCombo, "Must select an Address!");
            }
        }
        // Precondition:  The form's error provider still remains
        // Postcondition: The form's error provider is cleared
        private void chooseAddCombo_Validated(object sender, EventArgs e)
        {
            comboError.SetError(chooseAddCombo, "");    // clears error message
        }
        // Precondition:  None
        // Postcondition: The okay button was clicked and all 
        //                children have been validated
        private void okBttn_Click(object sender, EventArgs e)
        {
            // Raise validating event for all enabled controls on form
            // If all pass, ValidateChildren() will be true
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        // Precondition:  None
        // Postcondition: If the left mouse button was clicked, 
        //                the form's dialog result has been set to cancel
        //                and therefore the form has been closed
        private void cnclBttn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
