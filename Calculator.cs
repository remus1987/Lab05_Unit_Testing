using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Unit_Testing
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        public double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}
