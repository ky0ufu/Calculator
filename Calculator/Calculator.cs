using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalc
    {
        private double value = 0;
        private double memory = 0;
        private string operation = string.Empty;

        public Calculator()
        {
            value = 0;
            memory = 0;
        }
        public double GetValue()
        {
            return value;
        }

        public void SetValue(double value)
        {
            this.value = value;
        }
        public void SetOperator(string operation) 
        {
            this.operation = operation;
        }
        public string GetOperator()
        {
            return operation;
        }

        public void ClearValue()
        {
            this.value = 0;
        }
        public double Multiplication(double arg)
        {
            value *= arg;
            return value;
        }
        public double Division(double arg)
        {
            if (arg == 0)
                throw new DivideByZeroException();
            value /= arg;
            return value;
        }
        public double Add(double arg)
        {
            value += arg;
            return value;

        }
        public double Substraction(double arg)
        {
            value -= arg;
            return value;
        }
  
        public double Sqrt()
        {
            value = Math.Sqrt(value);
            return value;
        }
        public double Square()
        {
            value = Math.Pow(value, 2);
            return value;
        }

        public double Inverse()
        {
            if (value != 0)
            {
                value = 1 / value;
                return value;
            }
            else
                throw new Exception();
        }
        public double Precent()
        {
            value /= 100;
            return value;
        }
        public double ChangeSymbol()
        {
            value *= -1;
            return value;
        }
        public double GetMemory()
        {
            return memory;
        }
        public void ClearMemory()
        {
            memory = 0;
        }
        public double MemoryAdd(double arg)
        {
            return value + arg;
        }
        public double MemorySubtract(double arg)
        {
            return value - arg;
        }
    }
}
