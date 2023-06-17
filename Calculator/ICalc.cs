using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalc
    {
        void SetValue(double arg);
        void ClearValue();
        double Multiplication(double arg);
        double Division(double arg);
        double Sum(double arg);
        double Substraction(double arg);
        double Sqrt();
        double Square();
        double Inverse();
        double GetMemory();
        void ClearMemory();

        double MemoryAdd(double arg);
        double MemorySubtract(double arg);

    }
}
