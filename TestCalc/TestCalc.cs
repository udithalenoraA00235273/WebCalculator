using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalc;

namespace TestCalc
{
    [TestClass]
    public class TestCalc
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        public void CalculatorAddMethod(double left, double right, double expected)
        {
            double result;
            result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(2, 0, 2)]
        [DataRow(2, 0, 2)]

        public void CalculatorSubMethod(double left, double right, double expected)
        {
            double result1;
            result1 = Calculator.Sub(left, right);
            Assert.AreEqual(expected, result1);

        }

        [DataTestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(2, 1, 2)]
        public void CalculatorMultiplyMethod(double left, double right, double expected)
        {
            double result2;
            result2 = Calculator.Mul(left, right);
            Assert.AreEqual(expected, result2);

        }

        [DataTestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(2, 1, 2)]
        public void CalculatorDivideMethod(double left, double right, double expected)
        {
            double result3;
            result3 = Calculator.Div(left, right);
            Assert.AreEqual(expected, result3);

        }
    }
}
