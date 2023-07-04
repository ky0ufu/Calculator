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
        public Calculator calculator;
        bool enterVal = false;

        public Form1()
        {
            calculator = new Calculator();
            
            InitializeComponent();
            result.Text = "0";
        }   

   

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            textHistory.Text = string.Empty;

            calculator.ClearValue();
            calculator.SetOperator(string.Empty);           
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (result.Text == "Деление на ноль")
                result.Text = "0";

            double secNumber = Convert.ToDouble(result.Text);
            textHistory.Text = $"{textHistory.Text} {result.Text}=";

            if (result.Text != string.Empty)
            {
                if (result.Text == "0")
                    textHistory.Text = string.Empty;
                switch (calculator.GetOperator())
                {
                    case "+":
                        result.Text = calculator.Add(secNumber).ToString();
                        break;

                    case "-":
                        result.Text = calculator.Substraction(secNumber).ToString();
                        break;

                    case "x":
                        result.Text = calculator.Multiplication(secNumber).ToString();
                        break;

                    case "/":
                        try
                        {
                            result.Text = calculator.Division(secNumber).ToString();
                        }
                        catch(DivideByZeroException)
                        {
                            result.Text = "Деление на ноль";
                            calculator.ClearValue();
                            calculator.SetOperator(string.Empty);
                            textHistory.Text = string.Empty;
                            return;
                        }

                        break;
                    default:
                        textHistory.Text = result.Text;
                        break;
                }
                calculator.SetValue(Convert.ToDouble(result.Text));
                calculator.SetOperator(string.Empty);
            }
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result.Text.Length == 20)
                return;
            if (result.Text.IndexOf(',') != -1 && result.Text.Length - result.Text.IndexOf(',') > 14)
                return;

            if (result.Text == "Деление на ноль")
                result.Text = "0";

            if (result.Text == "0" && button.Text != "," || enterVal)
                result.Text = string.Empty;

            enterVal = false;

            if (button.Text == ",")
            {
                if (!result.Text.Contains(','))
                    result.Text += button.Text;
            }
            else
                result.Text += button.Text;
        }

        private void buttonMath_Click(object sender, EventArgs e)
        {
            if (result.Text == "Деление на ноль")
                result.Text = "0";

            if (calculator.GetValue() != 0)
                buttonResult.PerformClick();
            else
                calculator.SetValue(Convert.ToDouble(result.Text));

            Button button= (Button)sender;

            calculator.SetOperator(button.Text);
            calculator.SetValue(Convert.ToDouble(result.Text));

            enterVal = true;
            if (result.Text != "0")
            {
                textHistory.Text = $"{result.Text} {calculator.GetOperator()}";                
                result.Text = string.Empty;
            }         
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperator(button.Text);
            calculator.SetValue(Convert.ToDouble(result.Text));

            switch (calculator.GetOperator())
            {
                case "√x":
                    textHistory.Text = $"√({result.Text})";
                    result.Text = calculator.Sqrt().ToString();
                    break;

                case "x²":
                    textHistory.Text = $"({result.Text})²";
                    result.Text = calculator.Square().ToString();
                    break;

                case "1/x":
                    try
                    {
                        textHistory.Text = $"1/({result.Text})";
                        result.Text = calculator.Inverse().ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        result.Text = "Деление на ноль";
                        calculator.ClearValue();

                        calculator.SetOperator(string.Empty);
                        textHistory.Text = string.Empty;
                    }
                    break;

                case "%":
                    result.Text = calculator.Precent().ToString();
                    break;
                case "±":

                    result.Text = calculator.ChangeSymbol().ToString();
                    break;
            }
        }

        private void ButtonMemory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text) 
            {
                case "M+":
                    calculator.MemoryAdd(Convert.ToDouble(result.Text));
                    break;
                case "M-":
                    calculator.MemorySubtract(Convert.ToDouble(result.Text));
                    break;
                case "MC":
                    calculator.ClearMemory();
                    break;
                case "MR":
                    result.Text = calculator.GetMemory().ToString();
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonClearEntry.PerformClick();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (result.Text.Length == 1)
                result.Text = "0";

            if (result.Text != "0")
                result.Text = result.Text.Remove(result.Text.Length - 1);            
        }
    }
}
