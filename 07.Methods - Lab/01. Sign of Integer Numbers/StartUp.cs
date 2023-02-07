namespace _01._Sign_of_Integer_Numbers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var readNumberFromConsole = int.Parse(Console.ReadLine());
            if (readNumberFromConsole == 0)
                Console.WriteLine(NumberIsZero(readNumberFromConsole));
            else
                Console.WriteLine(readNumberFromConsole > 0 ? NumberIsPositive(readNumberFromConsole) : NumberIsNegative(readNumberFromConsole));
        }
        private static string NumberIsZero(int number)
           => $"The number {number} is zero.";
        private static string NumberIsNegative(int readNumberFromConsole)
            => $"The number {readNumberFromConsole} is negative.";
        private static string NumberIsPositive(int readNumberFromConsole)
            => $"The number {readNumberFromConsole} is positive.";
    }
}
