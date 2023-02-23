namespace _04._Word_Filter
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split().Where(x => x.Length % 2 == 0)));
        }
    }
}
