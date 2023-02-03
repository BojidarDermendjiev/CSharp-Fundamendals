namespace _01._Ages
{
using System;
    public class StartUp
    {
        static void Main()
        {
            var personAge = int.Parse(Console.ReadLine());
            string outputMessage = String.Empty;
            if (personAge >= 0 && personAge <= 2)
                outputMessage = "baby";
            else if (personAge >= 3 && personAge <= 13)
                outputMessage = "child";
            else if (personAge >= 14 && personAge <= 19)
                outputMessage = "teenager";
            else if (personAge >= 20 && personAge <= 65)
                outputMessage = "adult";
            else if (personAge >= 65)
                outputMessage = "elder";
            else
                outputMessage = "You cannot give negative age! Try again :)";
            Console.WriteLine(outputMessage);
        }
    }
}
