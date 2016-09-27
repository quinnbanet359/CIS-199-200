namespace Program_1
{
    partial class program1
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
            this.squareFeetLabelPrompt = new System.Windows.Forms.Label();
            this.paintDesiredPromptLabel = new System.Windows.Forms.Label();
            this.priceOfPaintPromptLabel = new System.Windows.Forms.Label();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.paintDesiredTextBox = new System.Windows.Forms.TextBox();
            this.priceOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.promptLabelSqFt = new System.Windows.Forms.Label();
            this.promptLabelPaintReq = new System.Windows.Forms.Label();
            this.promptLabelHoursReq = new System.Windows.Forms.Label();
            this.promptLabelCostPaint = new System.Windows.Forms.Label();
            this.promptLabelCostLabor = new System.Windows.Forms.Label();
            this.promptLabelTotalCost = new System.Windows.Forms.Label();
            this.displayLabelSquareFeet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.displayLabelPaint = new System.Windows.Forms.Label();
            this.displayLabelLabor = new System.Windows.Forms.Label();
            this.displayLabelCostofPaint = new System.Windows.Forms.Label();
            this.displayLabelCostofLabor = new System.Windows.Forms.Label();
            this.displayLabelTotalCost = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.textBox1ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBox3ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // squareFeetLabelPrompt
            // 
            this.squareFeetLabelPrompt.Location = new System.Drawing.Point(86, 100);
            this.squareFeetLabelPrompt.Name = "squareFeetLabelPrompt";
            this.squareFeetLabelPrompt.Size = new System.Drawing.Size(239, 13);
            this.squareFeetLabelPrompt.TabIndex = 0;
            this.squareFeetLabelPrompt.Text = "Enter the square feet of wall space to be painted:";
            this.squareFeetLabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintDesiredPromptLabel
            // 
            this.paintDesiredPromptLabel.AutoSize = true;
            this.paintDesiredPromptLabel.Location = new System.Drawing.Point(115, 130);
            this.paintDesiredPromptLabel.Name = "paintDesiredPromptLabel";
            this.paintDesiredPromptLabel.Size = new System.Drawing.Size(210, 13);
            this.paintDesiredPromptLabel.TabIndex = 1;
            this.paintDesiredPromptLabel.Text = "Enter  the number of coats of paint desired:";
            // 
            // priceOfPaintPromptLabel
            // 
            this.priceOfPaintPromptLabel.AutoSize = true;
            this.priceOfPaintPromptLabel.Location = new System.Drawing.Point(141, 159);
            this.priceOfPaintPromptLabel.Name = "priceOfPaintPromptLabel";
            this.priceOfPaintPromptLabel.Size = new System.Drawing.Size(184, 13);
            this.priceOfPaintPromptLabel.TabIndex = 2;
            this.priceOfPaintPromptLabel.Text = "Enter the price of the paint per gallon:";
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(331, 97);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareFeetTextBox.TabIndex = 3;
            this.textBox1ToolTip.SetToolTip(this.squareFeetTextBox, "Enter the square feet of wall space to be painted in this text box.\r\n(hint: do no" +
        "t add \"square feet\" or \"sq. ft.,\" just enter digits)");
            // 
            // paintDesiredTextBox
            // 
            this.paintDesiredTextBox.Location = new System.Drawing.Point(331, 127);
            this.paintDesiredTextBox.Name = "paintDesiredTextBox";
            this.paintDesiredTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintDesiredTextBox.TabIndex = 4;
            this.textBox2ToolTip.SetToolTip(this.paintDesiredTextBox, "Enter the number of coats of paint desired in this text box.\r\n(hint: do not add \"" +
        "coats of paint\" or \"coats,\" just enter digits)");
            // 
            // priceOfPaintTextBox
            // 
            this.priceOfPaintTextBox.AccessibleDescription = "";
            this.priceOfPaintTextBox.Location = new System.Drawing.Point(331, 156);
            this.priceOfPaintTextBox.Name = "priceOfPaintTextBox";
            this.priceOfPaintTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceOfPaintTextBox.TabIndex = 5;
            this.textBox3ToolTip.SetToolTip(this.priceOfPaintTextBox, "Enter the price of the paint per gallon in this text box.\r\n(hint: do not add \"$\" " +
        "or \"dollars,\" just enter digits)");
            // 
            // promptLabelSqFt
            // 
            this.promptLabelSqFt.AutoSize = true;
            this.promptLabelSqFt.Location = new System.Drawing.Point(72, 209);
            this.promptLabelSqFt.Name = "promptLabelSqFt";
            this.promptLabelSqFt.Size = new System.Drawing.Size(155, 13);
            this.promptLabelSqFt.TabIndex = 6;
            this.promptLabelSqFt.Text = "Total square feet to be painted:";
            // 
            // promptLabelPaintReq
            // 
            this.promptLabelPaintReq.AutoSize = true;
            this.promptLabelPaintReq.Location = new System.Drawing.Point(53, 237);
            this.promptLabelPaintReq.Name = "promptLabelPaintReq";
            this.promptLabelPaintReq.Size = new System.Drawing.Size(174, 13);
            this.promptLabelPaintReq.TabIndex = 7;
            this.promptLabelPaintReq.Text = "Number of gallons of paint required:";
            // 
            // promptLabelHoursReq
            // 
            this.promptLabelHoursReq.AutoSize = true;
            this.promptLabelHoursReq.Location = new System.Drawing.Point(110, 265);
            this.promptLabelHoursReq.Name = "promptLabelHoursReq";
            this.promptLabelHoursReq.Size = new System.Drawing.Size(117, 13);
            this.promptLabelHoursReq.TabIndex = 8;
            this.promptLabelHoursReq.Text = "Hours of labor required:";
            // 
            // promptLabelCostPaint
            // 
            this.promptLabelCostPaint.AutoSize = true;
            this.promptLabelCostPaint.Location = new System.Drawing.Point(158, 292);
            this.promptLabelCostPaint.Name = "promptLabelCostPaint";
            this.promptLabelCostPaint.Size = new System.Drawing.Size(69, 13);
            this.promptLabelCostPaint.TabIndex = 9;
            this.promptLabelCostPaint.Text = "Cost of paint:";
            // 
            // promptLabelCostLabor
            // 
            this.promptLabelCostLabor.AutoSize = true;
            this.promptLabelCostLabor.Location = new System.Drawing.Point(158, 320);
            this.promptLabelCostLabor.Name = "promptLabelCostLabor";
            this.promptLabelCostLabor.Size = new System.Drawing.Size(69, 13);
            this.promptLabelCostLabor.TabIndex = 10;
            this.promptLabelCostLabor.Text = "Cost of labor:";
            // 
            // promptLabelTotalCost
            // 
            this.promptLabelTotalCost.AutoSize = true;
            this.promptLabelTotalCost.Location = new System.Drawing.Point(115, 349);
            this.promptLabelTotalCost.Name = "promptLabelTotalCost";
            this.promptLabelTotalCost.Size = new System.Drawing.Size(112, 13);
            this.promptLabelTotalCost.TabIndex = 11;
            this.promptLabelTotalCost.Text = "Total cost of paint job:";
            // 
            // displayLabelSquareFeet
            // 
            this.displayLabelSquareFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelSquareFeet.Location = new System.Drawing.Point(246, 208);
            this.displayLabelSquareFeet.Name = "displayLabelSquareFeet";
            this.displayLabelSquareFeet.Size = new System.Drawing.Size(185, 17);
            this.displayLabelSquareFeet.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 15;
            // 
            // displayLabelPaint
            // 
            this.displayLabelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelPaint.Location = new System.Drawing.Point(246, 236);
            this.displayLabelPaint.Name = "displayLabelPaint";
            this.displayLabelPaint.Size = new System.Drawing.Size(185, 17);
            this.displayLabelPaint.TabIndex = 16;
            // 
            // displayLabelLabor
            // 
            this.displayLabelLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelLabor.Location = new System.Drawing.Point(246, 264);
            this.displayLabelLabor.Name = "displayLabelLabor";
            this.displayLabelLabor.Size = new System.Drawing.Size(185, 17);
            this.displayLabelLabor.TabIndex = 17;
            // 
            // displayLabelCostofPaint
            // 
            this.displayLabelCostofPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelCostofPaint.Location = new System.Drawing.Point(246, 291);
            this.displayLabelCostofPaint.Name = "displayLabelCostofPaint";
            this.displayLabelCostofPaint.Size = new System.Drawing.Size(185, 17);
            this.displayLabelCostofPaint.TabIndex = 18;
            // 
            // displayLabelCostofLabor
            // 
            this.displayLabelCostofLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelCostofLabor.Location = new System.Drawing.Point(246, 319);
            this.displayLabelCostofLabor.Name = "displayLabelCostofLabor";
            this.displayLabelCostofLabor.Size = new System.Drawing.Size(185, 17);
            this.displayLabelCostofLabor.TabIndex = 19;
            // 
            // displayLabelTotalCost
            // 
            this.displayLabelTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabelTotalCost.Location = new System.Drawing.Point(246, 348);
            this.displayLabelTotalCost.Name = "displayLabelTotalCost";
            this.displayLabelTotalCost.Size = new System.Drawing.Size(185, 17);
            this.displayLabelTotalCost.TabIndex = 20;
            // 
            // calculateButton
            // 
            this.calculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculateButton.Location = new System.Drawing.Point(343, 182);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(430, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(511, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.helpButton.Location = new System.Drawing.Point(12, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 24;
            this.helpButton.Text = "Help";
            this.helpButtonToolTip.SetToolTip(this.helpButton, "Don\'t click this......you can do this all on your own.");
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click_1);
            // 
            // directionsLabel
            // 
            this.directionsLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.directionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.directionsLabel.Location = new System.Drawing.Point(161, 48);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(236, 33);
            this.directionsLabel.TabIndex = 25;
            this.directionsLabel.Text = "Directions: Enter only numerical digits in the text boxes. (123.45 not $123.45)";
            // 
            // program1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(587, 385);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayLabelTotalCost);
            this.Controls.Add(this.displayLabelCostofLabor);
            this.Controls.Add(this.displayLabelCostofPaint);
            this.Controls.Add(this.displayLabelLabor);
            this.Controls.Add(this.displayLabelPaint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.displayLabelSquareFeet);
            this.Controls.Add(this.promptLabelTotalCost);
            this.Controls.Add(this.promptLabelCostLabor);
            this.Controls.Add(this.promptLabelCostPaint);
            this.Controls.Add(this.promptLabelHoursReq);
            this.Controls.Add(this.promptLabelPaintReq);
            this.Controls.Add(this.promptLabelSqFt);
            this.Controls.Add(this.priceOfPaintTextBox);
            this.Controls.Add(this.paintDesiredTextBox);
            this.Controls.Add(this.squareFeetTextBox);
            this.Controls.Add(this.priceOfPaintPromptLabel);
            this.Controls.Add(this.paintDesiredPromptLabel);
            this.Controls.Add(this.squareFeetLabelPrompt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label squareFeetLabelPrompt;
        private System.Windows.Forms.Label paintDesiredPromptLabel;
        private System.Windows.Forms.Label priceOfPaintPromptLabel;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.TextBox paintDesiredTextBox;
        private System.Windows.Forms.TextBox priceOfPaintTextBox;
        private System.Windows.Forms.Label promptLabelSqFt;
        private System.Windows.Forms.Label promptLabelPaintReq;
        private System.Windows.Forms.Label promptLabelHoursReq;
        private System.Windows.Forms.Label promptLabelCostPaint;
        private System.Windows.Forms.Label promptLabelCostLabor;
        private System.Windows.Forms.Label promptLabelTotalCost;
        private System.Windows.Forms.Label displayLabelSquareFeet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label displayLabelPaint;
        private System.Windows.Forms.Label displayLabelLabor;
        private System.Windows.Forms.Label displayLabelCostofPaint;
        private System.Windows.Forms.Label displayLabelCostofLabor;
        private System.Windows.Forms.Label displayLabelTotalCost;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.ToolTip textBox1ToolTip;
        private System.Windows.Forms.ToolTip textBox2ToolTip;
        private System.Windows.Forms.ToolTip textBox3ToolTip;
        private System.Windows.Forms.ToolTip helpButtonToolTip;
    }
}

