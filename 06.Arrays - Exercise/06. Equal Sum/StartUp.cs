namespace _06._Equal_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var readNumbersFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            bool exist  = false;
            for (int currentNumber = 0; currentNumber < readNumbersFromConsole.Length; currentNumber++)
            {
                int leftSum = default;
                for (int leftPossition = currentNumber - 1; leftPossition >= 0; leftPossition--)
                    leftSum += readNumbersFromConsole[leftPossition];
                int rightSum = default;
                for (int rigthPossition = currentNumber + 1; rigthPossition < readNumbersFromConsole.Length; rigthPossition++)
                    rightSum += readNumbersFromConsole[rigthPossition];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(currentNumber);
                    exist = true;
                    break;
                }
            }
            if(!exist)
                Console.WriteLine("no");
        }
    }
}
