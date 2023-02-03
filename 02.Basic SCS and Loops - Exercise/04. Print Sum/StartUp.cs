namespace _04._Print_Sum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            int total = default;
            for (int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                Console.Write(currentNumber + " ");
                total += currentNumber;
            }
            Console.WriteLine(Environment.NewLine + $"Sum: {total}");
        }
    }
}
