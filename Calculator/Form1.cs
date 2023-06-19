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
        public int count;
        bool enterVal = false;

        public Form1()
        {
            calculator = new Calculator();
            count = 0;
            
            InitializeComponent();
            result.Text = "0";
        }

        private void CheckNumber()
        {
            if (result.Text.IndexOf("Inf") != -1)
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            if (result.Text[0] == '0' && result.Text[1] != ',')
            {
                result.Text = result.Text.Remove(0, 1);
            }
            if (result.Text[0] == '-' &&  result.Text[1] == '0' && result.Text[2] != ',')
            {
                result.Text = result.Text.Remove(1, 1);
            }

        }
        
        private bool Press()
        {
            if (!buttonAdd.Enabled) return false;
            if (!buttonSub.Enabled) return false;
            if (!buttonMultiplication.Enabled) return false;
            if (!buttonDivision.Enabled) return false;
            return true;
        }

        private void ButtonClear()
        {
            buttonMultiplication.Enabled = true;
            buttonDivision.Enabled = true;
            buttonAdd.Enabled = true;
            buttonSub.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            textHistory.Text = string.Empty;
            calculator.ClearValue();
            ButtonClear();
            count = 0;
            
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {

        }


        private void buttonSqrt_Click(object sender, EventArgs e)
        {

        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {

        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
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
                        result.Text = calculator.Division(secNumber).ToString();
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
            if (result.Text == "0" || enterVal)
                result.Text = string.Empty;

            enterVal = false;
            Button button = (Button)sender;
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
                    textHistory.Text = $"1/({result.Text})";
                    result.Text = calculator.Inverse().ToString();
                    break;
                case "%":
                    textHistory.Text = $"√({result.Text})";
                    result.Text = calculator.Precent().ToString();
                    break;
                case "±":
                    result.Text = calculator.ChangeSymbol().ToString();
                    break;

            }
        }
    }
}
