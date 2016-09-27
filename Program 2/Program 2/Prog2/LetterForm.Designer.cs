namespace Prog2
{
    partial class LetterForm
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
            this.orAdLbl = new System.Windows.Forms.Label();
            this.destAdLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orCombo = new System.Windows.Forms.ComboBox();
            this.destCombo = new System.Windows.Forms.ComboBox();
            this.fxdCostTxt = new System.Windows.Forms.TextBox();
            this.okBttn = new System.Windows.Forms.Button();
            this.cnclBttn = new System.Windows.Forms.Button();
            this.orError = new System.Windows.Forms.ErrorProvider(this.components);
            this.destError = new System.Windows.Forms.ErrorProvider(this.components);
            this.costError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costError)).BeginInit();
            this.SuspendLayout();
            // 
            // orAdLbl
            // 
            this.orAdLbl.AutoSize = true;
            this.orAdLbl.Location = new System.Drawing.Point(32, 15);
            this.orAdLbl.Name = "orAdLbl";
            this.orAdLbl.Size = new System.Drawing.Size(78, 13);
            this.orAdLbl.TabIndex = 0;
            this.orAdLbl.Text = "Origin Address:";
            // 
            // destAdLbl
            // 
            this.destAdLbl.AutoSize = true;
            this.destAdLbl.Location = new System.Drawing.Point(6, 43);
            this.destAdLbl.Name = "destAdLbl";
            this.destAdLbl.Size = new System.Drawing.Size(104, 13);
            this.destAdLbl.TabIndex = 1;
            this.destAdLbl.Text = "Destination Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fixed Cost:";
            // 
            // orCombo
            // 
            this.orCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.orCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orCombo.FormattingEnabled = true;
            this.orCombo.Location = new System.Drawing.Point(116, 12);
            this.orCombo.Name = "orCombo";
            this.orCombo.Size = new System.Drawing.Size(121, 21);
            this.orCombo.TabIndex = 3;
            this.orCombo.Validating += new System.ComponentModel.CancelEventHandler(this.orCombo_Validating);
            this.orCombo.Validated += new System.EventHandler(this.orCombo_Validated);
            // 
            // destCombo
            // 
            this.destCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.destCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.destCombo.FormattingEnabled = true;
            this.destCombo.Location = new System.Drawing.Point(116, 40);
            this.destCombo.Name = "destCombo";
            this.destCombo.Size = new System.Drawing.Size(121, 21);
            this.destCombo.TabIndex = 4;
            this.destCombo.Validating += new System.ComponentModel.CancelEventHandler(this.destCombo_Validating);
            this.destCombo.Validated += new System.EventHandler(this.destCombo_Validated);
            // 
            // fxdCostTxt
            // 
            this.fxdCostTxt.Location = new System.Drawing.Point(116, 68);
            this.fxdCostTxt.Name = "fxdCostTxt";
            this.fxdCostTxt.Size = new System.Drawing.Size(121, 20);
            this.fxdCostTxt.TabIndex = 5;
            this.fxdCostTxt.Validating += new System.ComponentModel.CancelEventHandler(this.fxdCostTxt_Validating);
            this.fxdCostTxt.Validated += new System.EventHandler(this.fxdCostTxt_Validated);
            // 
            // okBttn
            // 
            this.okBttn.Location = new System.Drawing.Point(52, 100);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(75, 23);
            this.okBttn.TabIndex = 6;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // cnclBttn
            // 
            this.cnclBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnclBttn.Location = new System.Drawing.Point(133, 100);
            this.cnclBttn.Name = "cnclBttn";
            this.cnclBttn.Size = new System.Drawing.Size(75, 23);
            this.cnclBttn.TabIndex = 7;
            this.cnclBttn.Text = "Cancel";
            this.cnclBttn.UseVisualStyleBackColor = true;
            // 
            // orError
            // 
            this.orError.ContainerControl = this;
            // 
            // destError
            // 
            this.destError.ContainerControl = this;
            // 
            // costError
            // 
            this.costError.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AcceptButton = this.okBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cnclBttn;
            this.ClientSize = new System.Drawing.Size(262, 131);
            this.Controls.Add(this.cnclBttn);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.fxdCostTxt);
            this.Controls.Add(this.destCombo);
            this.Controls.Add(this.orCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destAdLbl);
            this.Controls.Add(this.orAdLbl);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.orError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orAdLbl;
        private System.Windows.Forms.Label destAdLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orCombo;
        private System.Windows.Forms.ComboBox destCombo;
        private System.Windows.Forms.TextBox fxdCostTxt;
        private System.Windows.Forms.Button okBttn;
        private System.Windows.Forms.Button cnclBttn;
        private System.Windows.Forms.ErrorProvider orError;
        private System.Windows.Forms.ErrorProvider destError;
        private System.Windows.Forms.ErrorProvider costError;
    }
}