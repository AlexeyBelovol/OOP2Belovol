namespace OOP2Belovol
{
    partial class Form1
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
            textBoxStreet = new TextBox();
            textBoxCity = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxCountry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonClearStreet = new Button();
            buttonClearCity = new Button();
            buttonClearPostalCode = new Button();
            buttonClearCountry = new Button();
            buttonSetAddress = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(113, 29);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(100, 23);
            textBoxStreet.TabIndex = 0;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(290, 29);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(100, 23);
            textBoxCity.TabIndex = 1;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(113, 126);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(100, 23);
            textBoxPostalCode.TabIndex = 2;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(290, 126);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(100, 23);
            textBoxCountry.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Street -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 32);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "City -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Postal Code - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 129);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Country - ";
            // 
            // buttonClearStreet
            // 
            buttonClearStreet.Location = new Point(48, 73);
            buttonClearStreet.Name = "buttonClearStreet";
            buttonClearStreet.Size = new Size(165, 27);
            buttonClearStreet.TabIndex = 8;
            buttonClearStreet.Text = "Clear Street";
            buttonClearStreet.UseVisualStyleBackColor = true;
            buttonClearStreet.Click += buttonClearStreet_Click;
            // 
            // buttonClearCity
            // 
            buttonClearCity.Location = new Point(225, 73);
            buttonClearCity.Name = "buttonClearCity";
            buttonClearCity.Size = new Size(165, 27);
            buttonClearCity.TabIndex = 9;
            buttonClearCity.Text = "Clear City";
            buttonClearCity.UseVisualStyleBackColor = true;
            // 
            // buttonClearPostalCode
            // 
            buttonClearPostalCode.Location = new Point(48, 169);
            buttonClearPostalCode.Name = "buttonClearPostalCode";
            buttonClearPostalCode.Size = new Size(165, 27);
            buttonClearPostalCode.TabIndex = 10;
            buttonClearPostalCode.Text = "Clear Postal Code";
            buttonClearPostalCode.UseVisualStyleBackColor = true;
            // 
            // buttonClearCountry
            // 
            buttonClearCountry.Location = new Point(225, 169);
            buttonClearCountry.Name = "buttonClearCountry";
            buttonClearCountry.Size = new Size(165, 27);
            buttonClearCountry.TabIndex = 11;
            buttonClearCountry.Text = "Clear Country";
            buttonClearCountry.UseVisualStyleBackColor = true;
            // 
            // buttonSetAddress
            // 
            buttonSetAddress.Location = new Point(82, 211);
            buttonSetAddress.Name = "buttonSetAddress";
            buttonSetAddress.Size = new Size(96, 75);
            buttonSetAddress.TabIndex = 12;
            buttonSetAddress.Text = "Set Address";
            buttonSetAddress.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(248, 211);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(96, 75);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(156, 342);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(32, 15);
            labelResult.TabIndex = 14;
            labelResult.Text = "label";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 342);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 15;
            label5.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(label5);
            Controls.Add(labelResult);
            Controls.Add(buttonClear);
            Controls.Add(buttonSetAddress);
            Controls.Add(buttonClearCountry);
            Controls.Add(buttonClearPostalCode);
            Controls.Add(buttonClearCity);
            Controls.Add(buttonClearStreet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxStreet);
            Name = "Form1";
            Text = "Лабораторна робота №2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStreet;
        private TextBox textBoxCity;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCountry;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonClearStreet;
        private Button buttonClearCity;
        private Button buttonClearPostalCode;
        private Button buttonClearCountry;
        private Button buttonSetAddress;
        private Button buttonClear;
        private Label labelResult;
        private Label label5;
    }
}
