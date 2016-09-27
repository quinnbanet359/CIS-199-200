namespace Prog2
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.address1Txt = new System.Windows.Forms.TextBox();
            this.address2Txt = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.zipTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.address2Lbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipLbl = new System.Windows.Forms.Label();
            this.okayBttn = new System.Windows.Forms.Button();
            this.cnclBttn = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.add1Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.stateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.zipError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add1Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipError)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(76, 14);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            this.nameTxt.Validated += new System.EventHandler(this.nameTxt_Validated);
            // 
            // address1Txt
            // 
            this.address1Txt.Location = new System.Drawing.Point(76, 40);
            this.address1Txt.Name = "address1Txt";
            this.address1Txt.Size = new System.Drawing.Size(100, 20);
            this.address1Txt.TabIndex = 1;
            this.address1Txt.Validating += new System.ComponentModel.CancelEventHandler(this.address1Txt_Validating);
            this.address1Txt.Validated += new System.EventHandler(this.address1Txt_Validated);
            // 
            // address2Txt
            // 
            this.address2Txt.Location = new System.Drawing.Point(76, 66);
            this.address2Txt.Name = "address2Txt";
            this.address2Txt.Size = new System.Drawing.Size(100, 20);
            this.address2Txt.TabIndex = 2;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(76, 92);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 3;
            this.cityText.Validating += new System.ComponentModel.CancelEventHandler(this.cityText_Validating);
            this.cityText.Validated += new System.EventHandler(this.cityText_Validated);
            // 
            // zipTxt
            // 
            this.zipTxt.Location = new System.Drawing.Point(76, 144);
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(100, 20);
            this.zipTxt.TabIndex = 5;
            this.zipTxt.Validating += new System.ComponentModel.CancelEventHandler(this.zipTxt_Validating);
            this.zipTxt.Validated += new System.EventHandler(this.zipTxt_Validated);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(28, 17);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(18, 43);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(48, 13);
            this.addressLbl.TabIndex = 9;
            this.addressLbl.Text = "Address:";
            // 
            // address2Lbl
            // 
            this.address2Lbl.AutoSize = true;
            this.address2Lbl.Location = new System.Drawing.Point(9, 69);
            this.address2Lbl.Name = "address2Lbl";
            this.address2Lbl.Size = new System.Drawing.Size(0, 13);
            this.address2Lbl.TabIndex = 10;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(39, 95);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(27, 13);
            this.cityLbl.TabIndex = 11;
            this.cityLbl.Text = "City:";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(31, 121);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 12;
            this.stateLbl.Text = "State:";
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(17, 147);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(53, 13);
            this.zipLbl.TabIndex = 13;
            this.zipLbl.Text = "Zip Code:";
            // 
            // okayBttn
            // 
            this.okayBttn.Location = new System.Drawing.Point(42, 170);
            this.okayBttn.Name = "okayBttn";
            this.okayBttn.Size = new System.Drawing.Size(75, 23);
            this.okayBttn.TabIndex = 6;
            this.okayBttn.Text = "OK";
            this.okayBttn.UseVisualStyleBackColor = true;
            this.okayBttn.Click += new System.EventHandler(this.okayBttn_Click);
            // 
            // cnclBttn
            // 
            this.cnclBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnclBttn.Location = new System.Drawing.Point(123, 170);
            this.cnclBttn.Name = "cnclBttn";
            this.cnclBttn.Size = new System.Drawing.Size(75, 23);
            this.cnclBttn.TabIndex = 7;
            this.cnclBttn.Text = "Cancel";
            this.cnclBttn.UseVisualStyleBackColor = true;
            this.cnclBttn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cnclBttn_MouseDown);
            // 
            // stateComboBox
            // 
            this.stateComboBox.AllowDrop = true;
            this.stateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV ",
            "WI"});
            this.stateComboBox.Location = new System.Drawing.Point(76, 117);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(100, 21);
            this.stateComboBox.TabIndex = 4;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            this.stateComboBox.Validated += new System.EventHandler(this.stateComboBox_Validated);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // add1Error
            // 
            this.add1Error.ContainerControl = this;
            // 
            // cityError
            // 
            this.cityError.ContainerControl = this;
            // 
            // stateError
            // 
            this.stateError.ContainerControl = this;
            // 
            // zipError
            // 
            this.zipError.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AcceptButton = this.okayBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cnclBttn;
            this.ClientSize = new System.Drawing.Size(240, 214);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cnclBttn);
            this.Controls.Add(this.okayBttn);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.address2Lbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.zipTxt);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.address2Txt);
            this.Controls.Add(this.address1Txt);
            this.Controls.Add(this.nameTxt);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add1Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox address1Txt;
        private System.Windows.Forms.TextBox address2Txt;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox zipTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label address2Lbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Button okayBttn;
        private System.Windows.Forms.Button cnclBttn;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider add1Error;
        private System.Windows.Forms.ErrorProvider cityError;
        private System.Windows.Forms.ErrorProvider stateError;
        private System.Windows.Forms.ErrorProvider zipError;
    }
}