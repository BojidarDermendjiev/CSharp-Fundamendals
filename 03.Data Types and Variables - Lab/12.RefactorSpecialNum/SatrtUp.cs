namespace _12.RefactorSpecialNum
{
    using System;
    public class SatrtUp
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = default;
            bool isSpecialNumber = false;
            for (int currentOperation = 1; currentOperation <= inputNumber; currentOperation++)
            {
                sum = default;
                int currentNumber = currentOperation;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentOperation, isSpecialNumber);
            }
        }
    }
}
