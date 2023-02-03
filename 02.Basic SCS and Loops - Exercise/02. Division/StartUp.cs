namespace _02._Division
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            int[] divisible = new int[] { 10, 7, 6, 3, 2 };
            foreach (var div in divisible)
                if (readNumberFromConsole % div == 0)
                {
                    Console.WriteLine(String.Format($"The number is divisible by {div}"));
                    return;
                }
            Console.WriteLine("Not divisible");
        }
    }
}
