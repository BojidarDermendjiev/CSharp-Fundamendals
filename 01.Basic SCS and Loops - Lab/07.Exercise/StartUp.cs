namespace _07.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var typeOfDay = Console.ReadLine();
            var personAge = int.Parse(Console.ReadLine());
            bool isItUnCorrect = false;
            int total = default;
            switch(typeOfDay) 
            {
                case "Weekday":
                    if (0 <= personAge && personAge <= 18 || 64 < personAge && personAge <= 122)
                        total += 12;
                    else if(18 < personAge && personAge <= 64)
                        total += 18;
                    else
                        isItUnCorrect = true;
                    break;
                case "Weekend":
                    if (0 <= personAge && personAge <= 18 || 64 < personAge && personAge <= 122)
                        total += 15;
                    else if (18 < personAge && personAge <= 64)
                        total += 20;
                    else
                        isItUnCorrect = true;
                    break;
                case "Holiday":
                    if (0 <= personAge && personAge <= 18)
                        total += 5;
                    else if (18 < personAge && personAge <= 64)
                        total += 12;
                    else if (64 < personAge && personAge <= 122)
                        total += 10;
                    else
                        isItUnCorrect = true;
                    break;
                    default: isItUnCorrect = true; break;
            }
            if(isItUnCorrect)
                Console.WriteLine("Error!");
            else
                Console.WriteLine($"{total}$");

        }
    }
}
