namespace _02._Sum_Digits
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFrom = int.Parse(Console.ReadLine());
            int total = default;
            Console.WriteLine(GetSumOfLengthFromNumber(readNumberFrom, total));
        }

        private static int GetSumOfLengthFromNumber(int readNumberFrom, int total)
        {
            if (readNumberFrom > 0)
                return GetSumOfLengthFromNumber(readNumberFrom / 10, total += readNumberFrom % 10);
            return total;
        }
    }
}
