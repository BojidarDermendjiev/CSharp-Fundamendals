namespace _03._Zig_Zag_Arrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];
            for (int currentLine = 0; currentLine < size; currentLine++)
            {
                int[] readInputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                int firstNumber = readInputLine[0];
                int secondNumber = readInputLine[1];
                if (currentLine % 2 == 0)
                {
                    firstArray[currentLine] = firstNumber;
                    secondArray[currentLine] = secondNumber;
                }
                else
                {
                    firstArray[currentLine] = secondNumber;
                    secondArray[currentLine] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
