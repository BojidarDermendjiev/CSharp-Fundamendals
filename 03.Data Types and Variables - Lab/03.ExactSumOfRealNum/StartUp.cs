namespace _03.ExactSumOfRealNum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int operations = int.Parse(Console.ReadLine());
            decimal sum = default;
            for (int i = 0; i < operations; i++)
            {
                decimal readNumber = decimal.Parse(Console.ReadLine());
                sum += readNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
