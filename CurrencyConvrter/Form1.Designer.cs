namespace CurrencyConvrter
{
    partial class Form1
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
            this.CmbFrom = new System.Windows.Forms.ComboBox();
            this.LblOne = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblTwo = new System.Windows.Forms.Label();
            this.LblThree = new System.Windows.Forms.Label();
            this.CmbTo = new System.Windows.Forms.ComboBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.LblConverted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbFrom
            // 
            this.CmbFrom.FormattingEnabled = true;
            this.CmbFrom.Items.AddRange(new object[] {
            "Dollar($)",
            "Lari(₾)",
            "Euro(€)",
            "Ruble(₽)"});
            this.CmbFrom.Location = new System.Drawing.Point(220, 120);
            this.CmbFrom.Name = "CmbFrom";
            this.CmbFrom.Size = new System.Drawing.Size(150, 21);
            this.CmbFrom.TabIndex = 0;
            // 
            // LblOne
            // 
            this.LblOne.AutoSize = true;
            this.LblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOne.Location = new System.Drawing.Point(10, 70);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(203, 17);
            this.LblOne.TabIndex = 1;
            this.LblOne.Text = "Amount Of Money To Convert :";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(220, 70);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(150, 20);
            this.TxtAmount.TabIndex = 2;
            // 
            // LblTwo
            // 
            this.LblTwo.AutoSize = true;
            this.LblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTwo.Location = new System.Drawing.Point(112, 120);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(101, 17);
            this.LblTwo.TabIndex = 3;
            this.LblTwo.Text = "Convert From :";
            // 
            // LblThree
            // 
            this.LblThree.AutoSize = true;
            this.LblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThree.Location = new System.Drawing.Point(127, 170);
            this.LblThree.Name = "LblThree";
            this.LblThree.Size = new System.Drawing.Size(86, 17);
            this.LblThree.TabIndex = 4;
            this.LblThree.Text = "Convert To :";
            // 
            // CmbTo
            // 
            this.CmbTo.FormattingEnabled = true;
            this.CmbTo.Items.AddRange(new object[] {
            "Dollar($)",
            "Lari(₾)",
            "Euro(€)",
            "Ruble(₽)"});
            this.CmbTo.Location = new System.Drawing.Point(220, 170);
            this.CmbTo.Name = "CmbTo";
            this.CmbTo.Size = new System.Drawing.Size(150, 21);
            this.CmbTo.TabIndex = 5;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(220, 253);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(150, 50);
            this.BtnConvert.TabIndex = 6;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // LblConverted
            // 
            this.LblConverted.AutoSize = true;
            this.LblConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConverted.Location = new System.Drawing.Point(188, 220);
            this.LblConverted.Name = "LblConverted";
            this.LblConverted.Size = new System.Drawing.Size(198, 17);
            this.LblConverted.TabIndex = 7;
            this.LblConverted.Text = "Amount Of Money Converted :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 371);
            this.Controls.Add(this.LblConverted);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.CmbTo);
            this.Controls.Add(this.LblThree);
            this.Controls.Add(this.LblTwo);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.LblOne);
            this.Controls.Add(this.CmbFrom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFrom;
        private System.Windows.Forms.Label LblOne;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblTwo;
        private System.Windows.Forms.Label LblThree;
        private System.Windows.Forms.ComboBox CmbTo;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label LblConverted;
    }
}

