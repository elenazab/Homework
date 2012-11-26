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
            isEmptyTextBox = true;
            myOperator = " ";
        }

        private int result;
        private int operand1;
        private int operand2;
        private string myOperator;
        private bool isEmptyTextBox;

        private void Button1_Click(object sender, EventArgs e)
        {
            DigitClick(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DigitClick(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DigitClick(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DigitClick(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DigitClick(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DigitClick(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DigitClick(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DigitClick(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DigitClick(9);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            DigitClick(0);
        }

        private void DigitClick(int x)
        {
            if (isEmptyTextBox)
                textBox1.Text = x.ToString();
            else
                textBox1.Text += x.ToString();
            isEmptyTextBox = false;
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            ButtonOperation();
            myOperator = "+";
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            ButtonOperation();
            myOperator = "-";
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            ButtonOperation();
            myOperator = "*";
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            ButtonOperation();
            myOperator = "/";
        }

        private void ButtonOperation()
        {
            if (myOperator != " ")
                SecondOperation();
            else
                OperationClick();
        }

        private void OperationClick()
        {
            if (textBox1.Text == "error")
                operand1 = 0;
            else
                operand1 = int.Parse(textBox1.Text);
            textBox1.ResetText();
        }

        private void SecondOperation()
        {
            operand1 = MyCalculate.Calc(operand1, int.Parse(textBox1.Text), myOperator);
            textBox1.ResetText();
        }

        private void ButtonEquality_Click(object sender, EventArgs e)
        {
            operand2 = int.Parse(textBox1.Text);
            if (operand2 == 0 && myOperator == "/")
                textBox1.Text = "error";
            else
            {
                result = MyCalculate.Calc(operand1, operand2, myOperator);
                textBox1.Text = result.ToString();
            }
            isEmptyTextBox = true;
            operand1 = result;
            myOperator = " ";
        }
    }
}
