namespace _09.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            int total = default;
            for (int currrentNumber = 0; currrentNumber < readNumberFromConsole; currrentNumber++)
            {
                var number = (currrentNumber * 2) + 1;
                Console.WriteLine(number);
                total += number;
            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
