namespace _03._Rounding_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            double[] arrayOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
            foreach (var num in arrayOfNumbers)
            {
                double rounded = (int)Math.Round(num, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {rounded}");
            }
        }
    }
}
