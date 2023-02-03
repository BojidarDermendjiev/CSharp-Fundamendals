namespace _07._Water_Overflow
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const int CAPACITY = 255;
            int tankLiters = default;
            int attempts = int.Parse(Console.ReadLine());
            for (int currentAttempt = 1; currentAttempt <= attempts; currentAttempt++)
            {
                int littersToPour = int.Parse(Console.ReadLine());
                if (littersToPour + tankLiters > CAPACITY)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    continue;
                }
                tankLiters += littersToPour;
            }
            Console.WriteLine(tankLiters);
        }
    }
}
