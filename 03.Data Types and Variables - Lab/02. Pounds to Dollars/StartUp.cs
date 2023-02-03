namespace _02._Pounds_to_Dollars
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const decimal BRIDISHPOUND = 1.31m;
            int inputLine = int.Parse(Console.ReadLine());
            decimal total = BRIDISHPOUND * (decimal)inputLine;
            Console.WriteLine($"{total:f3}");
        }
    }
}
