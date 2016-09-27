namespace Prog2
{
    partial class ChooseAddressForm
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
            this.chooseAddCombo = new System.Windows.Forms.ComboBox();
            this.comboLabel = new System.Windows.Forms.Label();
            this.okBttn = new System.Windows.Forms.Button();
            this.cnclBttn = new System.Windows.Forms.Button();
            this.comboError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboError)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseAddCombo
            // 
            this.chooseAddCombo.FormattingEnabled = true;
            this.chooseAddCombo.Location = new System.Drawing.Point(41, 25);
            this.chooseAddCombo.Name = "chooseAddCombo";
            this.chooseAddCombo.Size = new System.Drawing.Size(121, 21);
            this.chooseAddCombo.TabIndex = 0;
            this.chooseAddCombo.Validating += new System.ComponentModel.CancelEventHandler(this.chooseAddCombo_Validating);
            this.chooseAddCombo.Validated += new System.EventHandler(this.chooseAddCombo_Validated);
            // 
            // comboLabel
            // 
            this.comboLabel.AutoSize = true;
            this.comboLabel.Location = new System.Drawing.Point(38, 9);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(120, 13);
            this.comboLabel.TabIndex = 1;
            this.comboLabel.Text = "Choose Address to Edit:";
            // 
            // okBttn
            // 
            this.okBttn.Location = new System.Drawing.Point(12, 52);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(75, 23);
            this.okBttn.TabIndex = 2;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // cnclBttn
            // 
            this.cnclBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnclBttn.Location = new System.Drawing.Point(114, 52);
            this.cnclBttn.Name = "cnclBttn";
            this.cnclBttn.Size = new System.Drawing.Size(75, 23);
            this.cnclBttn.TabIndex = 3;
            this.cnclBttn.Text = "Cancel";
            this.cnclBttn.UseVisualStyleBackColor = true;
            this.cnclBttn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cnclBttn_MouseDown);
            // 
            // comboError
            // 
            this.comboError.ContainerControl = this;
            // 
            // ChooseAddressForm
            // 
            this.AcceptButton = this.okBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cnclBttn;
            this.ClientSize = new System.Drawing.Size(240, 87);
            this.Controls.Add(this.cnclBttn);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.comboLabel);
            this.Controls.Add(this.chooseAddCombo);
            this.Name = "ChooseAddressForm";
            this.Text = "Choose Address";
            this.Load += new System.EventHandler(this.ChooseAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseAddCombo;
        private System.Windows.Forms.Label comboLabel;
        private System.Windows.Forms.Button okBttn;
        private System.Windows.Forms.Button cnclBttn;
        private System.Windows.Forms.ErrorProvider comboError;
    }
}