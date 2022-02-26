using System;
using System.Windows.Forms;

namespace CurrencyConvrter
{
    public partial class Form1 : Form
    {
        /*
        Dollar($)
        Lari(₾)
        Euro(€)
        Pound(£)
        Ruble(₽)
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(TxtAmount.Text);
            LblConverted.Text = " ";

            //To Lari
            if (CmbFrom.SelectedItem == "Dollar($)" && CmbTo.SelectedItem == "Lari(₾)")
            {
                double converted = amount * 2.9899094;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₾ ";
            }
            if (CmbFrom.SelectedItem == "Euro(€)" && CmbTo.SelectedItem == "Lari(₾)")
            {
                double converted = amount * 3.3966599;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₾";
            }
            if (CmbFrom.SelectedItem == "Ruble(₽)" && CmbTo.SelectedItem == "Lari(₾)")
            {
                double converted = amount * 0.039214678;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₾";
            }
            if (CmbFrom.SelectedItem == "Lari(₾)" && CmbTo.SelectedItem == "Lari(₾)")
            {
                double converted = amount * 1;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₾";
            }


            //To Dollar
            if (CmbFrom.SelectedItem == "Lari(₾)" && CmbTo.SelectedItem == "Dollar($)")
            {
                double converted = amount / 2.9899094;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "$";
            }
            if (CmbFrom.SelectedItem == "Euro(€)" && CmbTo.SelectedItem == "Dollar($)")
            {
                double converted = amount * 1.1361952;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "$";
            }
            if (CmbFrom.SelectedItem == "Ruble(₽)" && CmbTo.SelectedItem == "Dollar($)")
            {
                double converted = amount * 0.013123363;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "$";
            }
            if (CmbFrom.SelectedItem == "Dollar($)" && CmbTo.SelectedItem == "Dollar($)")
            {
                double converted = amount * 1;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "$";
            }

            //To Euro
            if (CmbFrom.SelectedItem == "Lari(₾)" && CmbTo.SelectedItem == "Euro(€)")
            {
                double converted = amount / 3.3966599;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "€";
            }
            if (CmbFrom.SelectedItem == "Euro(€)" && CmbTo.SelectedItem == "Euro(€)")
            {
                double converted = amount * 1;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "€";
            }
            if (CmbFrom.SelectedItem == "Ruble(₽)" && CmbTo.SelectedItem == "Euro(€)")
            {
                double converted = amount * 0.011540242;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "€";
            }
            if (CmbFrom.SelectedItem == "Dollar($)" && CmbTo.SelectedItem == "Euro(€)")
            {
                double converted = amount / 1.1361952;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "€";
            }

            //To Ruble
            if (CmbFrom.SelectedItem == "Lari(₾)" && CmbTo.SelectedItem == "Ruble(₽)")
            {
                double converted = amount / 0.039214678;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₽";
            }
            if (CmbFrom.SelectedItem == "Euro(€)" && CmbTo.SelectedItem == "Ruble(₽)")
            {
                double converted = amount / 0.011540242;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₽";
            }
            if (CmbFrom.SelectedItem == "Ruble(₽)" && CmbTo.SelectedItem == "Ruble(₽)")
            {
                double converted = amount * 1;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₽";
            }
            if (CmbFrom.SelectedItem == "Dollar($)" && CmbTo.SelectedItem == "Ruble(₽)")
            {
                double converted = amount / 0.013123363;
                LblConverted.Text = "Amount Of Money Converted : " + converted + " " + "₽";
            }

        }
    }
}
