using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"The result of {num1} {operation} {num2} is {result}");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
