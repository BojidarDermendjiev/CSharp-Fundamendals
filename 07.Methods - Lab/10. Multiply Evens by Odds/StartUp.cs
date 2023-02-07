namespace _10._Multiply_Evens_by_Odds
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string inputLine;
            int oddNumbers = default;
            int evenNumbers = default;
            GetInfo(out inputLine);
            foreach (var number in inputLine)
                if (char.IsDigit(number))
                    GetMultipleOfEvenAndOdds(ref oddNumbers, ref evenNumbers, number);
            Console.WriteLine(GetMultipli(oddNumbers, evenNumbers));

        }

        private static void GetMultipleOfEvenAndOdds(ref int oddNumbers, ref int evenNumbers, char number)
        {
            if (((int)number) % 2 == 0)
                evenNumbers += (int)number - 48;
            else
                oddNumbers += (int)number - 48;
        }

        private static string GetInfo(out string inputLine)
            => inputLine = Console.ReadLine();

        private static int GetMultipli(int oddNumbers, int evenNumbers)
            => oddNumbers * evenNumbers;
    }
}
