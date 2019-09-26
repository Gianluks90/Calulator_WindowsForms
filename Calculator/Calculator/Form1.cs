using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value;

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox("9");
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox(".");
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox(" + ");
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox(" - ");
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox(" * ");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            AppendToTextBox(" / ");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // ------------------------------------------------------------- -- -

        private void AppendToTextBox(string value)
        {
            textBox1.AppendText(value);
        }
    }
}
