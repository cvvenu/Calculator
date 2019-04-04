using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class CalculatorHelper
    {
        static internal double Add(double a,double b)
        {
            return a + b;
        }

        static internal double Multiply(double a, double b)
        {
            return a * b;
        }

        static internal double Subtract(double a, double b)
        {
            return a - b;
        }

        static internal double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
