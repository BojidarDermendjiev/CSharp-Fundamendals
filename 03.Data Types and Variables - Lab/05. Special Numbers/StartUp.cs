namespace _05._Special_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int operation = int.Parse(Console.ReadLine());
            for (int currenOperation = 1; currenOperation <= operation; currenOperation++)
                Console.WriteLine($"{currenOperation} -> {IsNumberIsSpecial(currenOperation)}");
        }
        static bool IsNumberIsSpecial(int number)
        {
            int digit = default;
            while (number > 0)
            {
                digit += number % 10;
                number /= 10;
            }
            int[] specialNumber = new int[] { 5, 7, 11 };
            return specialNumber.Contains(digit);
        }
    }
}
