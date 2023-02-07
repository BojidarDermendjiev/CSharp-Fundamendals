namespace _11._Math_operations
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Func<int, char, int, int> mathFunctionality = (a, symbol, b) => MathFunctions(a, symbol, b);
            char symbol;
            int firstNumber, secondNumber;
            GetInputLines(out firstNumber, out symbol, out secondNumber);
            Console.WriteLine(mathFunctionality(firstNumber, symbol, secondNumber));
        }
        private static void GetInputLines(out int firstNumber, out char symbol, out int secondNumber)
        {
            firstNumber = int.Parse(Console.ReadLine());
            symbol = char.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
        }
        private static int MathFunctions(int firstNumber, char symbol, int secondNumber)
        {
            if (symbol == '+')
                return firstNumber + secondNumber;
            else if (symbol == '-')
                return firstNumber - secondNumber;
            else if (symbol == '*')
                return firstNumber * secondNumber;
            else if (firstNumber == 0 || secondNumber == 0)
                throw new ArgumentException($"You cannot divide zero number!");
            else if (symbol == '/')
                return firstNumber / secondNumber;
            else throw new ArgumentException($"You cannot divide zero number!");
        }
    }
}
