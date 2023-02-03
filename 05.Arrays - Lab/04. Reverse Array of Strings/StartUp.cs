namespace _04._Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var arrayOfString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", arrayOfString.Reverse()));
        }
    }
}
