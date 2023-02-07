namespace _09._Greater_of_Two_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string infoAboutType;
            GetInfo(out infoAboutType);
            if (infoAboutType == "int")
                FindBiggestNumber();
            else if (infoAboutType == "char")
                FindBiggestChar();
            else if(infoAboutType == "string")
                FindBiggestString();
        }
        private static string GetInfo(out string infoAboutType)
           => infoAboutType = Console.ReadLine();
        private static void FindBiggestNumber()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber  > secondNumber ? firstNumber : secondNumber);
        }
        private static void FindBiggestChar()
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            Console.WriteLine((int)firstChar > (int)secondChar ? firstChar : secondChar);
        }
        private static void FindBiggestString()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();
            Console.WriteLine(firstString[0] > secondString[0] ? firstString : secondString);
        }
    }
}
