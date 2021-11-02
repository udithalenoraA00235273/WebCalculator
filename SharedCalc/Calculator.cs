using System;

namespace SharedCalc
{
    public static class Calculator
    {
        public static float Add(float left, float right)
        {
            return left + right;
        }
        public static float Sub(float left, float right)
        {
            return left - right;
        }

        public static float Mul(float left, float right)
        {
            return left * right;
        }

        public static float Div(float left, float right)
        {
            return left / right;
        }
    }
}
