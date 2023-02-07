namespace _03._Calculations
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            try
            {
                Func<string, int, int, int> mathFunctionality = (operation, a, b) => MathFunctions(operation, a, b);
                string operation;
                int firstNumber, secondNumber;
                GetInputLines(out operation, out firstNumber, out secondNumber);
                Console.WriteLine(mathFunctionality(operation, firstNumber, secondNumber));
            }
            catch (ExceptionsMessages em)
            {
                Console.WriteLine(em);
            }
        }

        private static int MathFunctions(string operation, int firstNumber, int secondNumber)
        {
            if (operation == "add")
                return firstNumber + secondNumber;
            else if (operation == "subtract")
                return firstNumber - secondNumber;
            else if (operation == "multiply")
                return firstNumber * secondNumber;
           else if (firstNumber == 0 || secondNumber == 0)
                throw new ExceptionsMessages();
            else if (operation == "divide")
                return firstNumber / secondNumber;
            else throw new ExceptionsMessages();
        }
        private static void GetInputLines(out string operation, out int firstNumber, out int secondNumber)
        {
            operation = Console.ReadLine();
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
        }
    }
}
