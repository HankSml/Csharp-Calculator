using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double numOne, double numTwo, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = numOne + numTwo;
                    break;
                case "s":
                    result = numOne - numTwo;
                    break;
                case "m":
                    result = numOne * numTwo;
                    break;
                case "d":
                    while (numTwo == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor:");
                        numTwo = Convert.ToDouble(Console.ReadLine());
                    }
                    result = numOne / numTwo;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
