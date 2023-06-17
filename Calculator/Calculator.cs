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

        public Calculator()
        {
            value = 0;
            memory = 0;
        }
        public void SetValue(double value)
        {
            this.value = value;
        }

        public void ClearValue()
        {
            this.value = 0;
        }
        public double Multiplication(double arg)
        {
            return value * arg;
        }
        public double Division(double arg)
        {
            if (arg == 0)
                throw new DivideByZeroException();
            return (value / arg);
        }
        public double Sum(double arg)
        {
            return value + arg;

        }
        public double Substraction(double arg)
        {
            return value - arg;
        }
  
        public double Sqrt()
        {
            return Math.Sqrt(value);
        }
        public double Square()
        {
            return Math.Pow(value, 2);
        }

        public double Inverse()
        {
            if (value != 0)
                return 1 / value;
            else
                throw new Exception();
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
