using System;
using static Calculator.Calculator;

namespace Calculator
{

    class Program
    {
        static void Main()
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");

            while (endApp == false)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Type a number, and then press Enter");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number, and then press Enter");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your Choice?");

                string option = Console.ReadLine();

                try
                {
                    result = DoOperation(cleanNum1, cleanNum2, option);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation resulted in a math error");
                    }
                    else Console.WriteLine("Your Result: {0:0.##}\n", result);
                }
                catch (Exception err)
                {
                    Console.WriteLine($"An error has occurred while doing the math!\n Details: {err.Message}");
                }

                Console.WriteLine("------------------------------------------\n");

                Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to cotinue ");
                if (Console.ReadLine() == "n") endApp = true;
            }
            return;
        }
    }
}
