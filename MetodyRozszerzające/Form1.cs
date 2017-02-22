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
            throw new NotImplementedException();
        }

        private void reecognizeIntegerTypeOperation()
        {
            throw new NotImplementedException();
        }

        private void ShowByNByNRB_CheckedChanged(object sender, EventArgs e)
        {
            PositionTB.Enabled = ShowByNByNRB.Checked;
        }
    }
}
