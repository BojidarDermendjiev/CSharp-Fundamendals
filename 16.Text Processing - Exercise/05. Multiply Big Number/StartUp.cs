namespace _05._Multiply_Big_Number
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            string readNumberFromConsole;
            int numberOfCopyOriginal;
            GetInfo(out readNumberFromConsole, out numberOfCopyOriginal);
            string result = Engine(readNumberFromConsole, numberOfCopyOriginal);
            IO(result);
        }
        private static void GetInfo(out string readNumberFromConsole, out int numberOfCopyOriginal)
        {
            readNumberFromConsole = Console.ReadLine();
            numberOfCopyOriginal = int.Parse(Console.ReadLine());
        }
        private static string Engine(string readNumberFromConsole, int multiplier)
        {
            if (multiplier == 0)
                return "0";
            int reminder = 0;
            StringBuilder result = new StringBuilder();
            for (int i = readNumberFromConsole.Length - 1; i >= 0; i--)
            {
                int digit = readNumberFromConsole[i] - '0';
                reminder += multiplier * digit;
                if (reminder > 9)
                {
                    int remainderLastDigit = reminder % 10;
                    reminder /= 10;
                    result.Append(remainderLastDigit.ToString());
                }
                else
                {
                    result.Append(reminder.ToString());
                    reminder = 0;
                }
            }
            if (reminder > 0)
            {
                result.Append(reminder.ToString());
            }
            return string.Concat(result.ToString().Reverse());
        }
        private static void IO(string result)
        {
            Console.WriteLine(result);
        }
    }
}
