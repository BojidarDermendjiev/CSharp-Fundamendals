namespace _10._Lower_or_Upper
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch.ToString() == ch.ToString().ToLower() ? " lower-case" : "upper-case");
        }
    }
}
