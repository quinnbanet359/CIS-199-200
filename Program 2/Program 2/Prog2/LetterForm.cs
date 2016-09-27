// Quinn Banet
// Due: 6/11/15
// CIS 200-10
// File: LetterForm.cs
// Class LetterForm: relays to a GUI that allows the user to select an origin address, a destination parcel, and enter a fixed cost.

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
    public partial class LetterForm : Form
    {
        public LetterForm(List<Address> aList)
        {
            InitializeComponent();

            // populates origin and destination addresses combo boxes
            foreach (var item in aList)
            {
                orCombo.Items.Add(item.Name);
                destCombo.Items.Add(item.Name);
            }
        }

        // Precondition:  origin address has already been validated with validating properties
        // Postcondition: the selected origin address is returned
        public int ChosenOrAdd
        {         
            // Precondition:  None
            // Postcondition: Text in destCombo is returned
            get { return orCombo.SelectedIndex;  }
            // Precondition:  None
            // Postcondition: Text in orCombo is set to specified value
            set {orCombo.SelectedIndex = value; }
        }
        // Precondition:  destination address has already been validated with validating properties
        // Postcondition: the selected destination address is returned
        public int ChosenDestAdd
        {
            // Precondition:  None
            // Postcondition: Text in destCombo is returned
            get { return destCombo.SelectedIndex; }
            // Precondition:  None
            // Postcondition: Text in destCombo is set to specified value
            set { destCombo.SelectedIndex = value; }
        }
        // Precondition:  fixed cost has already been validated with validating properties
        // Postcondition: the entered fixed cost is returned
        public decimal FixedCost
        {
            // Precondition:  None
            // Postcondition: Text in fxdCostTxt is returned
            get { return decimal.Parse(fxdCostTxt.Text); }

            // Precondition:  None
            // Postcondition: Text in fxdCostTxt is set to specified value
            set {value = decimal.Parse(fxdCostTxt.Text); }
        }
        // Precondition:  None
        // Postcondition:  Origin combo box has been validated from incorrect user enrty
        private void orCombo_Validating(object sender, CancelEventArgs e)
        {
            // Validate orCombo
            if (String.IsNullOrEmpty(orCombo.Text))
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                orError.SetError(orCombo, "Select an Address!");  // set error message

                orCombo.SelectAll();    // select all text in orCombo to ease correction
            }

                // validation against same entry
            if (destCombo.SelectedIndex == orCombo.SelectedIndex)
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                orError.SetError(orCombo, "Select a unique Address!");  // set error message

                orCombo.SelectAll();    // select all text in orCombo to ease correction
            }
            else
            {
                int minSelect = 0;  // first address position (a1)
                int maxSelect = 8;  // last address position (user address)
                // tests the range (0-8 addresses) to ensure the user has selcted a value
                if (orCombo.SelectedIndex < minSelect || orCombo.SelectedIndex > maxSelect)
                {
                    e.Cancel = true;    // stops focus changing process
                    // Will NOT proceed to validated event
                    orError.SetError(orCombo, "Select an Address!");  // set error message

                    orCombo.SelectAll();    // select all text in orCombo to ease correction
                }
            }
       }
        // Precondition:  Error messages from origin address errors still remain
        // Postcondition:  Error message has been cleared
        private void orCombo_Validated(object sender, EventArgs e)
        {
            orError.SetError(orCombo, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  destination combo box has been validated
        private void destCombo_Validating(object sender, CancelEventArgs e)
        {
            // Validate destCombo
            if (String.IsNullOrEmpty(destCombo.Text))
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                destError.SetError(destCombo, "Select an Address!");  // set error message

                destCombo.SelectAll();    // select all text in destCombo to ease correction
            }
            
                //// validation against same entry
            if (destCombo.SelectedIndex == orCombo.SelectedIndex)
            {
                e.Cancel = true;    // stops focus changing process
                // Will NOT proceed to validated event
                destError.SetError(destCombo, "Select a unique Address!");  // set error message

                destCombo.SelectAll();    // select all text in destCombo to ease correction
            }
                else
                {
                    int minSelect = 0;  // first address position (a1)
                    int maxSelect = 8;  // last address position (user address)

                    // tests the range (0-8 addresses) to ensure the user has selcted a value
                    if (destCombo.SelectedIndex < minSelect || destCombo.SelectedIndex > maxSelect)
                    {
                        e.Cancel = true;    // stops focus changing process
                        // Will NOT proceed to validated event
                        destError.SetError(destCombo, "Select an Address!");  // set error message

                        destCombo.SelectAll();    // select all text in destCombo to ease correction
                    }
                }
        }
        // Precondition:  Error messages from destination address errors still remain
        // Postcondition:  Error message has been cleared
        private void destCombo_Validated(object sender, EventArgs e)
        {
            destError.SetError(destCombo, ""); // clears error message
        }
        // Precondition:  None
        // Postcondition:  fixed cost text box has been validated
        private void fxdCostTxt_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;             // Value entered into zipTxt
     
            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!decimal.TryParse(fxdCostTxt.Text, out cost))
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to Validated event

                costError.SetError(fxdCostTxt, "Enter a Cost!"); // Set error message

                fxdCostTxt.SelectAll(); // Select all text in fxdCostTxt to ease correction
            }
            else
            {
                if (cost < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    costError.SetError(fxdCostTxt, "Cost must be > 0"); // Set error message

                    fxdCostTxt.SelectAll(); // Select all text in fxdCostTxt to ease correction
                }
            }
        }
        // Precondition:  Error messages from  fixed cost errors still remain
        // Postcondition:  Error message has been cleared
        private void fxdCostTxt_Validated(object sender, EventArgs e)
        {
            costError.SetError(fxdCostTxt, ""); // clears error message
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
        private void okBttn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
