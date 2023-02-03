namespace _01._Integer_Operations
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int total = int.Parse(Console.ReadLine());
            total += int.Parse(Console.ReadLine());
            total /= int.Parse(Console.ReadLine());
            total *= int.Parse(Console.ReadLine());
            Console.WriteLine(total);
        }
    }
}
