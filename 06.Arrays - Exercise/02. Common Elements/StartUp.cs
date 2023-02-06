namespace _02._Common_Elements
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var firstInputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var secondInputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var firstElement in secondInputLine)
                foreach (var secondElement in firstInputLine)
                    if(firstElement == secondElement)
                        Console.Write($"{firstElement}");
        }
    }
}
