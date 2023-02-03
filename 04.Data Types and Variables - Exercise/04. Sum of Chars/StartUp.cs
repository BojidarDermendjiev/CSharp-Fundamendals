namespace _04._Sum_of_Chars
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int countOfCharaters = int.Parse(Console.ReadLine());
            int total = default;
            for (int i = 0; i < countOfCharaters; i++)
                total += char.Parse(Console.ReadLine());
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
