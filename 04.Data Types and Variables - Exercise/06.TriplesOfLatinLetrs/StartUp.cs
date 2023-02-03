namespace _06.TriplesOfLatinLetrs
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            for (int first = 97; first < 97 + range; first++)

                for (int second = 97; second < 97 + range; second++)
                    for (int third = 97; third < 97 + range; third++)
                        Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
        }
    }
}
