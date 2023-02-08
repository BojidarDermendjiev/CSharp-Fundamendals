namespace _08._Factorial_Division
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double firstNumber, secondNumber;
            GetInfo(out firstNumber, out secondNumber);
            firstNumber = Factorial(firstNumber);
            secondNumber = Factorial(secondNumber);
            Console.WriteLine($"{Divide(firstNumber, secondNumber):f2}");
        }
        private static void GetInfo(out double readNumberFromConsole, out double divideNumber)
        {
            readNumberFromConsole = double.Parse(Console.ReadLine());
            divideNumber = double.Parse(Console.ReadLine());
        }
        private static double Factorial(double FactorailNumber)
        {
            if (FactorailNumber == 0)
                return 1;
            return FactorailNumber * Factorial(FactorailNumber - 1);
        }
        private static double Divide(double firstNumber, double secondNumber)
            => firstNumber / secondNumber;
    }
}
