using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static double Calculate(double firstNum, double secondNum, string op)
        {
            double result;
            switch (op)
            {
                case string operation  when operation == "+" || operation == "add":
                    result = firstNum + secondNum;
                    break;

                case string operation when operation == "-" || operation == "subtract":
                    if (firstNum > secondNum)
                    {
                        result = firstNum - secondNum;
                        break;
                    }
                    result = secondNum - firstNum;
                    break;

                case string operation when operation == "*" || operation == "multiply":
                    result = firstNum * secondNum;
                    break;

                case string operation when operation == "/" || operation == "divide":
                    if (firstNum > secondNum)
                    {
                        if(secondNum == 0)
                            throw new NotSupportedException("Divide by Zero occured.");
                        result = firstNum / secondNum; ;
                        break;
                    }
                    if (firstNum == 0)
                        throw new NotSupportedException("Divide by Zero occured.");
                    result = secondNum / firstNum; ;
                    break;

                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }
}