using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyRozszerzające
{
    public partial class Form1 : Form
    {

        private bool isStringType = true;
        private bool isIntegerType = false;

        public Form1()
        {
            InitializeComponent();
            initializeComponents();
        }

        private void initializeComponents()
        {
            StringTypeRB.Checked = true;
            CapitalizeRB.Checked = true;

            IntegerOptionsGB.Enabled = false;
            LetterTB.Enabled = false;
            PositionTB.Enabled = false;
            PowValueTB.Enabled = false;
        }

        private void IntegerTypeRB_CheckedChanged(object sender, EventArgs e)
        {
            saveProperValuesForChangeProperOption();
        }

        private void StringTypeRB_CheckedChanged(object sender, EventArgs e)
        {
            saveProperValuesForChangeProperOption();
        }

        private void saveProperValuesForChangeProperOption()
        {
            StringOptionsGB.Enabled = StringTypeRB.Checked;
            IntegerOptionsGB.Enabled = IntegerTypeRB.Checked;
            isStringType = StringTypeRB.Checked;
            isIntegerType = IntegerTypeRB.Checked;
        }

        private void CountLettersRB_CheckedChanged(object sender, EventArgs e)
        {
            LetterTB.Enabled = CountLettersRB.Checked;
        }

        private void ShowByNByNRB_CheckedChanged(object sender, EventArgs e)
        {
            PositionTB.Enabled = ShowByNByNRB.Checked;
        }

        private void PowRB_CheckedChanged(object sender, EventArgs e)
        {
            PowValueTB.Enabled = PowRB.Checked;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            recognizeTypeOfMainOperation();
        }

        private void recognizeTypeOfMainOperation()
        {
            if (isStringType)
            {
                recognizeStringTypeOperation();
            }
            else if (isIntegerType) {
                reecognizeIntegerTypeOperation();
            }
            else
            {
                MessageBox.Show("Nie ma takiej operacji");
            }
        }

        private void recognizeStringTypeOperation()
        {
            if (CapitalizeRB.Checked)
            {
                ResultDisplay.Text = InputPhraseTB.Text.Capitalize();
            }
            else if (IsCapitalizedRB.Checked)
            {
                ResultDisplay.Text = InputPhraseTB.Text.IsCapitalized().ToString();
            }
            else if (CountWordRB.Checked)
            {
                ResultDisplay.Text = InputPhraseTB.Text.CountWords();
            }
            else if (CountLettersRB.Checked)
            {
                ResultDisplay.Text = InputPhraseTB.Text.CountLetters(LetterTB.Text.ToCharArray());
            }
            else if (ShowByNByNRB.Checked)
            {
                displayResultNByN();
            }

            
        }

        private void displayResultNByN()
        {
            ResultDisplay.Text = "";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var elem in InputPhraseTB.Text.Jump(Int32.Parse(PositionTB.Text)))
            {
                stringBuilder.Append(elem);
                stringBuilder.Append(" ");
            }
            ResultDisplay.Text = stringBuilder.ToString();
        }

        private void reecognizeIntegerTypeOperation()
        {
            if (IsOneDigitRB.Checked)
            {
                ResultDisplay.Text = (Int32.Parse(InputPhraseTB.Text)).IsOneDigit().ToString();
            }
            else if (IsNegativeRB.Checked)
            {
                ResultDisplay.Text = (Int32.Parse(InputPhraseTB.Text)).IsNegative().ToString();
            }
            else if (PowRB.Checked)
            {
                ResultDisplay.Text = (Int32.Parse(InputPhraseTB.Text)).Pow(Int32.Parse(PowValueTB.Text)).ToString();
            }
        }

       

        
    }
}
