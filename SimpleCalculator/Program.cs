using System;

namespace SimpleCalculator
{
    class Program
    {
        private static void Main()
        {
            string choice = "n";
            do
            {
                try
                {
                    Console.WriteLine("Enter the first Number");
                    double firstNumber = InputFormatter.FormatNumber(Console.ReadLine());

                    Console.WriteLine("Enter the second Number");
                    double secondNumber = InputFormatter.FormatNumber(Console.ReadLine());

                    Console.WriteLine("Enter the operator");
                    string op = InputFormatter.FormatOperator(Console.ReadLine());

                    double result = Calculator.Calculate(firstNumber, secondNumber, op);
                    Console.WriteLine("The output of the operation is {0}",result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Exception encountered while performing calculation. Error: {0}", ex.Message));
                }
                finally
                {

                    Console.WriteLine("Do you want to  continue(y/n)?");
                    choice = Console.ReadLine().ToLower();
                    while (choice != "y" && choice != "n")
                    {
                    Console.WriteLine("Do you want to  continue(y/n)?");
                    choice = Console.ReadLine().ToLower();
                    }

                }
            } while (choice == "y");
        }
    }
}
