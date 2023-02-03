namespace _09._Chars_to_String
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            char[] ch = new char[3];
            for (int i = 0; i < 3; i++)
                ch[i] = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);
        }
    }
}
