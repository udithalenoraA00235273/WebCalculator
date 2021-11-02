using System;

namespace SharedCalc
{
    public static class Calculator
    {
        public static double Add(double left, double right)
        {
            return left + right;
        }
        public static double Sub(double left, double right)
        {
            return left - right;
        }

        public static double Mul(double left, double right)
        {
            return left * right;
        }

        public static double Div(double left, double right)
        {
            return left / right;
        }
    }
}
