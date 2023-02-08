namespace _04._Password_Validator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string readPasswordFromConsole;
            var outputMessage = new List<string>();
            GetInfo(out readPasswordFromConsole);
            PasswordValidator(readPasswordFromConsole, ref outputMessage);
            PrintCurrentMessage(outputMessage);
        }


        private static void GetInfo(out string readInputLineFromConsole)
        {
            readInputLineFromConsole = Console.ReadLine();
        }
        private static List<string> PasswordValidator(string readPasswordFromConsole, ref List<string> outputMessage)
        {
            bool isItCorrect = true;
            isItCorrect = ValidationLength(readPasswordFromConsole, outputMessage, isItCorrect);
            isItCorrect = IsItLetterOrDigits(readPasswordFromConsole, outputMessage, isItCorrect);
            isItCorrect = IsItDigitCountLessThenTwo(readPasswordFromConsole, outputMessage, isItCorrect);
            Correctly(outputMessage, isItCorrect);
            return outputMessage;
        }

        private static void Correctly(List<string> outputMessage, bool isItCorrect)
        {
            if (isItCorrect)
                outputMessage.Add("Password is valid");
        }

        private static bool IsItDigitCountLessThenTwo(string readPasswordFromConsole, List<string> outputMessage, bool isItCorrect)
        {
            if (readPasswordFromConsole.Count(x => char.IsDigit(x)) < 2)
            {
                outputMessage.Add("Password must have at least 2 digits");
                isItCorrect = false;
            }

            return isItCorrect;
        }

        private static bool IsItLetterOrDigits(string readPasswordFromConsole, List<string> outputMessage, bool isItCorrect)
        {
            if (!(readPasswordFromConsole.Any(x => char.IsLetter(x) && readPasswordFromConsole.Any(x => char.IsDigit(x)))) && readPasswordFromConsole.Length >= 6 && readPasswordFromConsole.Length <= 10)
            {
                outputMessage.Add("Password must consist only of letters and digits");
                isItCorrect = false;
            }

            return isItCorrect;
        }

        private static bool ValidationLength(string readPasswordFromConsole, List<string> outputMessage, bool isItCorrect)
        {
            if (readPasswordFromConsole.Length < 6 || readPasswordFromConsole.Length > 10)
            {
                outputMessage.Add("Password must be between 6 and 10 characters");
                isItCorrect = false;

            }

            return isItCorrect;
        }

        private static void PrintCurrentMessage(List<string> outputMessage)
        {
            Console.WriteLine(String.Join(Environment.NewLine, outputMessage));
        }
    }
}
