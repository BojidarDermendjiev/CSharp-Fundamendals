namespace _09._Spice_Must_Flow
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            long totalSpice = 0;
            int days = 0;
            while (yield >= 100)
            {
                days += 1;
                totalSpice += yield - 26;
                yield -= 10;
            }
            totalSpice -= 26;
            if (totalSpice < 0)
                totalSpice = 0;
            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
