namespace CSharpCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.CalcNumber = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonDecimalSeparator = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.CurrentSumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(32, 430);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(135, 430);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 23);
            this.SubtractButton.TabIndex = 1;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // CalcNumber
            // 
            this.CalcNumber.Location = new System.Drawing.Point(32, 350);
            this.CalcNumber.Name = "CalcNumber";
            this.CalcNumber.Size = new System.Drawing.Size(388, 23);
            this.CalcNumber.TabIndex = 2;
            this.CalcNumber.Click += new System.EventHandler(this.CalcNumber_Click);
            this.CalcNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcNumber_KeyPress);
            this.CalcNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalcNumber_KeyUp);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(32, 468);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(67, 15);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "ResultLabel";
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(239, 430);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(345, 430);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(83, 136);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(186, 136);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(290, 136);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(83, 184);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(186, 184);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 23);
            this.Button5.TabIndex = 10;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(290, 184);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 23);
            this.Button6.TabIndex = 11;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(83, 234);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(75, 23);
            this.Button7.TabIndex = 12;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(186, 234);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(75, 23);
            this.Button8.TabIndex = 13;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(290, 234);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(75, 23);
            this.Button9.TabIndex = 14;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(186, 287);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(75, 23);
            this.Button0.TabIndex = 15;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonDecimalSeparator
            // 
            this.ButtonDecimalSeparator.Location = new System.Drawing.Point(83, 287);
            this.ButtonDecimalSeparator.Name = "ButtonDecimalSeparator";
            this.ButtonDecimalSeparator.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecimalSeparator.TabIndex = 16;
            this.ButtonDecimalSeparator.Text = ".";
            this.ButtonDecimalSeparator.UseVisualStyleBackColor = true;
            this.ButtonDecimalSeparator.Click += new System.EventHandler(this.ButtonDecimalSeparator_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.Location = new System.Drawing.Point(290, 287);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(75, 23);
            this.ButtonC.TabIndex = 17;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // CurrentSumLabel
            // 
            this.CurrentSumLabel.AutoSize = true;
            this.CurrentSumLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentSumLabel.Location = new System.Drawing.Point(32, 20);
            this.CurrentSumLabel.Name = "CurrentSumLabel";
            this.CurrentSumLabel.Size = new System.Drawing.Size(221, 37);
            this.CurrentSumLabel.TabIndex = 18;
            this.CurrentSumLabel.Text = "CurrentSumLabel";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 557);
            this.Controls.Add(this.CurrentSumLabel);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonDecimalSeparator);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalcNumber);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.TextBox CalcNumber;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonDecimalSeparator;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Label CurrentSumLabel;
    }
}
