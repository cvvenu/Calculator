using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String mathOperation = "";
        bool isMathOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        //selecting numbers (0-9) and "." and showing on a result textbox
        private void Btn_Click(object sender, EventArgs e)
        {
            if ((TbResault.Text == "0") || (isMathOperationPressed))
            {
                TbResault.Clear();
            }

            isMathOperationPressed = false;
            Button btn = (Button)sender;
            TbResault.Text = TbResault.Text + btn.Text;
        }

        //clearing textbox
        private void BtnCE_Click(object sender, EventArgs e)
        {
            TbResault.Clear();
            TbResault.Text = "0";
        }

        //selecting an math operation, showing equation
        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mathOperation = btn.Text;
            value = Double.Parse(TbResault.Text);
            isMathOperationPressed = true;
            LabelEquation.Text = value + " " + mathOperation;
        }

        //showing a result depending on selected operation
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (mathOperation)
            {
                case "+":
                    TbResault.Text = CalculatorHelper.Add(value, Double.Parse(TbResault.Text)).ToString();
                    break;
                case "-":
                    TbResault.Text = CalculatorHelper.Subtract(value, Double.Parse(TbResault.Text)).ToString();
                    break;
                case "/":
                    TbResault.Text = CalculatorHelper.Divide(value, Double.Parse(TbResault.Text)).ToString();
                    break;
                case "*":
                    TbResault.Text = CalculatorHelper.Multiply(value, Double.Parse(TbResault.Text)).ToString();
                    break;
                default:
                    break;
            }
            LabelEquation.Text = "";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TbResault.Text = "0";
            value = 0;
        }
    }
}