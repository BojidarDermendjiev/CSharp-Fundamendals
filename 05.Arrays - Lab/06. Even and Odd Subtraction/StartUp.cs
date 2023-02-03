namespace _06._Even_and_Odd_Subtraction
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int evenSum = default;
            int oddSum = default;
            for (int currentNumber = 0; currentNumber < arrayOfNumbers.Length; currentNumber++)
            { 
                if (arrayOfNumbers[currentNumber] % 2 == 0)
                    evenSum += arrayOfNumbers[currentNumber];
                else
                    oddSum += arrayOfNumbers[currentNumber];
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
