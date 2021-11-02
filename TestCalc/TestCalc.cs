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
        public void CalculatorAddMethod(float left, float right, float expected)
        {
            float result;
            result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(2, 0, 2)]
        [DataRow(2, 0, 2)]

        public void CalculatorSubMethod(float left, float right, float expected)
        {
            float result1;
            result1 = Calculator.Sub(left, right);
            Assert.AreEqual(expected, result1);

        }

        [DataTestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(2, 1, 2)]
        public void CalculatorMultiplyMethod(float left, float right, float expected)
        {
            float result2;
            result2 = Calculator.Mul(left, right);
            Assert.AreEqual(expected, result2);

        }

        [DataTestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(2, 1, 2)]
        public void CalculatorDivideMethod(float left, float right, float expected)
        {
            float result3;
            result3 = Calculator.Div(left, right);
            Assert.AreEqual(expected, result3);

        }
    }
}
