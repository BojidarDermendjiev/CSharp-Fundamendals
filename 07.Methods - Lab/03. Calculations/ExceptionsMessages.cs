using System;

namespace _03._Calculations
{
    public class ExceptionsMessages : Exception
    {
        private const string ExceptionMessage = "You cannot divide with zero number!";
        public ExceptionsMessages() : base(ExceptionMessage) { }
        public ExceptionsMessages(string message) : base(message) { }
    }
}
