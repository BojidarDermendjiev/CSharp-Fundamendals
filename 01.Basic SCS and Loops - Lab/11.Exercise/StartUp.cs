namespace _11.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var readNumberFromConsole = int.Parse(Console.ReadLine());
            var integer = int.Parse(Console.ReadLine());
            if (integer > 10)
                Console.WriteLine($"{readNumberFromConsole} X {integer} = {integer * readNumberFromConsole}");
            else
                for (int currentNumber = integer; currentNumber <= 10; currentNumber++)
                    Console.WriteLine($"{readNumberFromConsole} X {currentNumber} = {currentNumber * readNumberFromConsole}");
        }
    }
}
