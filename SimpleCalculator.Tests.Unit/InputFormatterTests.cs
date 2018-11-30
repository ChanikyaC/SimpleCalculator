using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.UnitTests
{
    [TestClass]
    public class InputFormatterTests
    {
        [TestMethod]
        public void FormatNumber_ConvertStringToNumber()
        {
            string num = "1";
            double number = Convert.ToDouble(num);
            double formattedNum = InputFormatter.FormatNumber(num);
            Assert.AreEqual(number, formattedNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FormatNumber_FailToConvertStringToNumber()
        {
            string num = "a";
            double formattedNum = InputFormatter.FormatNumber(num);
        }

        [TestMethod]
        public void FormatOperator_ConfirmSymbolicOperationIsSupported()
        {
            string op = "+";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual(op, formattedOp);
        }

        [TestMethod]
        public void FormatOperator_ConfirmNamedOperationIsSupported()
        {
            string op = "add";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual(op, formattedOp);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void FormatOperator_ConfirmInvalidSymbolicOperationsAreNotSupported_Partially()
        {
            string op = "1";
            string formattedOp = InputFormatter.FormatOperator(op);
        }

    }
}
