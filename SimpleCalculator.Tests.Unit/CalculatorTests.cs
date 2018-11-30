using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        double firstNumber = 5;
        double secondNumber = 2; 

        [TestMethod]
        public void Addition_FirstNumberAndSecondNumber()
        {
            double result = Calculator.Calculate(firstNumber, secondNumber, "+");
            Assert.AreEqual(firstNumber + secondNumber, result);
        }

        [TestMethod]
        public void Addition_FirstNumberAddSecondNumber()
        {
            double result = Calculator.Calculate(firstNumber, secondNumber, "add");
            Assert.AreEqual(firstNumber + secondNumber, result);
        }

        [TestMethod]
        public void Subtraction_FirstNumberAndSecondNumber()
        {
            double result = Calculator.Calculate(5, 2, "-");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtraction_FromFirstNumberSubtractSecondNumber()
        {
            double result = Calculator.Calculate(5, 2, "subtract");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtraction_SecondNumberAndFirstNumber()
        {
            double result = Calculator.Calculate(2, 5, "-");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Subtraction_FromSecondNumberSubtractFirstNumber()
        {
            double result = Calculator.Calculate(2, 5, "subtract");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Multiplication_FirstNumberAndSecondNumber()
        {
            double result = Calculator.Calculate(firstNumber, secondNumber, "*");
            Assert.AreEqual(firstNumber * secondNumber, result);
        }

        [TestMethod]
        public void Multiplication_FirstNumberMultiplySecondNumber()
        {
            double result = Calculator.Calculate(firstNumber, secondNumber, "multiply");
            Assert.AreEqual(firstNumber * secondNumber, result);
        }

        [TestMethod]
        public void Division_FirstNumberAndSecondNumber()
        {
            double result = Calculator.Calculate(6, 3, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Division_FromFirstNumberDivideSecondNumber()
        {
            double result = Calculator.Calculate(6, 3, "divide");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Division_SecondNumberAndFirstNumber()
        {
            double result = Calculator.Calculate(3, 6, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Calculate_FromSecondNumberAndFirstNumber()
        {
            double result = Calculator.Calculate(3, 6, "divide");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Calculate_FirstNumberGreaterThanSecondNumber_Error()
        {
            double result = Calculator.Calculate(firstNumber, 0, "/");
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Calculate_FirstNumberLesserThanSecondNumber_Error()
        {
            double result = Calculator.Calculate(0, firstNumber, "/");
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Calculate_ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(firstNumber, secondNumber, "%");
        }
    }
}
