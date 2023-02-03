namespace _12.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole;
            while ((readNumberFromConsole = int.Parse(Console.ReadLine())) % 2 != 0)
                Console.WriteLine("Please write an even number.");
            Console.WriteLine($"The number is: {readNumberFromConsole}");
        }
    }
}
