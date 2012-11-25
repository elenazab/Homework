using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            textBox1.ResetText();
            result = 0;
        }

        private int result;
        private int operand1;
        private int operand2;
        private string myOperator;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operand1 = int.Parse(textBox1.Text);
            myOperator = "+";
            textBox1.ResetText();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            operand1 = int.Parse(textBox1.Text);
            myOperator = "-";
            textBox1.ResetText();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operand1 = int.Parse(textBox1.Text);
            myOperator = "*";
            textBox1.ResetText();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operand1 = int.Parse(textBox1.Text);
            myOperator = "/";
            textBox1.ResetText();
        }

        private void buttonEquality_Click(object sender, EventArgs e)
        {
            operand2 = int.Parse(textBox1.Text);
            result = myCalculate.Calc(operand1, operand2, myOperator);
            textBox1.Text = result.ToString();
        }
    }
}
