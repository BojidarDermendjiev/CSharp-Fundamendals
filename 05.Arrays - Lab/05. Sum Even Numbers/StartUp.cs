namespace _05._Sum_Even_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int total = default;
            for (int currentNumber = 0; currentNumber < arrayOfNumbers.Length; currentNumber++)
                if (arrayOfNumbers[currentNumber] % 2 == 0)
                    total += arrayOfNumbers[currentNumber];
            Console.WriteLine(total);
        }
    }
}
