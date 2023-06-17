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
            calculator.ClearValue();
            ButtonClear();
            count = 0;
            
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (result.Text[0] == '-')
            {
                result.Text = result.Text.Remove(0, 1);
            }
            else
                result.Text = "-" + result.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((result.Text.IndexOf(",") == -1) && (result.Text.IndexOf("Inf") == -1))
            {
                result.Text += ",";
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            result.Text += '0';
            CheckNumber();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            result.Text += '1';
            CheckNumber();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            result.Text += '2';
            CheckNumber();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            result.Text += '3';
            CheckNumber();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            result.Text += '4';
            CheckNumber();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            result.Text += '5';
            CheckNumber();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            result.Text += '6';
            CheckNumber();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            result.Text += '7';
            CheckNumber();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            result.Text += '8';
            CheckNumber();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            result.Text += '9';
            CheckNumber();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));
                buttonAdd.Enabled = false;
                result.Text = "0";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));
                buttonAdd.Enabled = false;
                result.Text = "0";
            }
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));
                buttonMultiplication.Enabled = false;
                result.Text = "0";
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if(Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));
                buttonDivision.Enabled = false;
                result.Text = "0";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));

                result.Text = calculator.Sqrt().ToString();

                calculator.ClearValue();
                ButtonClear();
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));

                result.Text = calculator.Square().ToString();

                calculator.ClearValue();
                ButtonClear();
            }
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            if (Press())
            {
                calculator.SetValue(Convert.ToDouble(result.Text));
                
                result.Text = calculator.Inverse().ToString();

                calculator.ClearValue();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

        }
    }
}
