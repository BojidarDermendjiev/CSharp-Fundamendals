namespace _10._Top_Number
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
                if (IsTopNUmber(currentNumber))
                    Console.WriteLine(currentNumber);
        }
        private static bool IsTopNUmber(int number)
        {
            return IsDivisivleBy(number, 8) && ContainsOddDigite(number);
        }
        private static bool IsDivisivleBy(int number, int divider)
        {
            int sum = default;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % divider == 0;
        }
        private static bool ContainsOddDigite(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                    return true;
                number /= 10;
            }
            return false;
        }
    }
}
