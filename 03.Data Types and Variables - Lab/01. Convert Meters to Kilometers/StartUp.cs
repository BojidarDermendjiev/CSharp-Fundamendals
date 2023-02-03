namespace _01._Convert_Meters_to_Kilometers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double kilometers = 1.0 * distanceInMeters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
