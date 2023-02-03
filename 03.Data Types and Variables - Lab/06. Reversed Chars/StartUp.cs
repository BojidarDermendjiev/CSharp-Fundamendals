namespace _06._Reversed_Chars
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            //tricky one
            //char firstPut = char.Parse(Console.ReadLine());
            //char secondPut = char.Parse(Console.ReadLine());
            //char thirdPut = char.Parse(Console.ReadLine());
            //Console.WriteLine($"{thirdPut} {secondPut} {firstPut}");
            char[] symbols = new char[3];
            for (int i = 2; i >= 0; i--)
                symbols[i] = char.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(" ", symbols));
        }
    }
}
