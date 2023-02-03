namespace _08._Town_Info
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string town = Console.ReadLine();
            string population = Console.ReadLine();
            string area = Console.ReadLine();
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
